﻿namespace Cinema.DataProcessor
{
    using Data;
    using System;
    using Newtonsoft.Json;
    using Cinema.DataProcessor.ImportDto;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Cinema.Data.Models;
    using System.Text;
    using System.Xml.Serialization;
    using System.IO;
    using System.Linq;
    using System.Globalization;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";
        private const string SuccessfulImportMovie 
            = "Successfully imported {0} with genre {1} and rating {2}!";
        private const string SuccessfulImportHallSeat 
            = "Successfully imported {0}({1}) with {2} seats!";
        private const string SuccessfulImportProjection 
            = "Successfully imported projection {0} on {1}!";
        private const string SuccessfulImportCustomerTicket 
            = "Successfully imported customer {0} {1} with bought tickets: {2}!";

        public static string ImportMovies(CinemaContext context, string jsonString)
        {
            var moviesDtos = JsonConvert.DeserializeObject<MovieImportDto[]>(jsonString);
            var movies = new List<Movie>();
            StringBuilder sb = new StringBuilder();

            foreach (var dto in moviesDtos)
            {
                if (IsValid(dto))
                {
                    var movie = new Movie
                    {
                        Title = dto.Title,
                        Genre = dto.Genre,
                        Duration = dto.Duration,
                        Rating = dto.Rating,
                        Director = dto.Director
                    };

                    movies.Add(movie);
                    sb.AppendLine(string.Format(SuccessfulImportMovie, dto.Title, dto.Genre, dto.Rating.ToString("F2")));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Movies.AddRange(movies);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validator, validationResult, true);
        }

        public static string ImportHallSeats(CinemaContext context, string jsonString)
        {
            var objects = JsonConvert.DeserializeObject<HallSeatsImportDto[]>(jsonString);
            StringBuilder sb = new StringBuilder();

            foreach (var dto in objects)
            {
                if (IsValid(dto))
                {
                    var hall = new Hall
                    {
                        Name = dto.Name,
                        Is4Dx = dto.Is4Dx,
                        Is3D = dto.Is3D
                    };

                    context.Halls.Add(hall);
                    AddSeatsInDatabase(context, hall.Id, dto.Seats);
                    var projectionType = GetProjectionType(hall);
                    sb.AppendLine(string.Format(SuccessfulImportHallSeat, dto.Name, projectionType, dto.Seats));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.SaveChanges();
            return sb.ToString().Trim();
        }

        private static object GetProjectionType(Hall hall)
        {
            var result = "Normal";

            if (hall.Is4Dx && hall.Is3D)
            {
                result = "4Dx/3D";
            }
            else if(hall.Is3D)
            {
                result = "3D";
            }
            else if (hall.Is4Dx)
            {
                result = "4Dx";
            }

            return result;
        }

        private static void AddSeatsInDatabase(CinemaContext context, int hallId, int seatsCount)
        {
            var seats = new List<Seat>();

            for (int i = 0; i < seatsCount; i++)
            {
                seats.Add(new Seat() { HallId = hallId });
            }

            context.AddRange(seats);
            context.SaveChanges();
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ProjectionImportDto[]), new XmlRootAttribute("Projections"));
            var objects = (ProjectionImportDto[])serializer.Deserialize(new StringReader(xmlString));            
            StringBuilder sb = new StringBuilder();

            foreach (var dto in objects)
            {
                if (IsValid(dto) && IsValidMovieId(context, dto.MovieId) && IsValidHallId(context, dto.HallId))
                {
                    var projection = new Projection
                    {
                        MovieId = dto.MovieId,
                        HallId = dto.HallId,
                        DateTime = DateTime.ParseExact(
                            dto.DateTime,
                            "yyyy-MM-dd HH:mm:ss",
                            CultureInfo.InvariantCulture)
                    };

                    context.Projections.Add(projection);
                    var dateTimeResult = projection.DateTime.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    sb.AppendLine(String.Format(SuccessfulImportProjection, projection.Movie.Title, dateTimeResult));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }
            
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        private static bool IsValidHallId(CinemaContext context, int hallId)
        {
            return context.Halls.Any(h => h.Id == hallId);
        }

        private static bool IsValidMovieId(CinemaContext context, int movieId)
        {
            return context.Movies.Any(m => m.Id == movieId);
        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(CustomerImportDto[]), new XmlRootAttribute("Customers"));
            var objects = (CustomerImportDto[])serializer.Deserialize(new StringReader(xmlString));
            StringBuilder sb = new StringBuilder();

            foreach (var dto  in objects)
            {
                if (IsValid(dto))
                {
                    var customer = new Customer
                    {
                        FirstName = dto.FirstName,
                        LastName = dto.LastName,
                        Age = dto.Age,
                        Balance = dto.Balance
                    };

                    context.Customers.Add(customer);
                    AddCustomerTickets(context, customer.Id, dto.Tickets);
                    sb.AppendLine(string.Format(SuccessfulImportCustomerTicket, dto.FirstName, dto.LastName, dto.Tickets.Length));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.SaveChanges();
            return sb.ToString().Trim();
        }

        private static void AddCustomerTickets(CinemaContext context, int customerId, TicketCustomerImportDto[] ticketsDto)
        {
            var tickets = new List<Ticket>();

            foreach (var dto in ticketsDto)
            {
                if (IsValid(dto))
                {
                    var ticket = new Ticket
                    { 
                        ProjectionId = dto.ProjectionId,
                        CustomerId = customerId,
                        Price = dto.Price
                    };

                    tickets.Add(ticket);
                }
            }

            context.Tickets.AddRange(tickets);
            context.SaveChanges();
        }
    }
}