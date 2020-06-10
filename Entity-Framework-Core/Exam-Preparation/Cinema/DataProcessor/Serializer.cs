namespace Cinema.DataProcessor
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;    
    using Cinema.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportTopMovies(CinemaContext context, int rating)
        {
            var movies = context.Movies
                .Where(m => m.Rating >= rating
                && m.Projections.Any(p => p.Tickets.Count > 0))
                .OrderByDescending(m => m.Rating)
                .ThenByDescending(m => m.Projections.Sum(p => p.Tickets.Sum(t => t.Price)))
                .Select(m => new
                {
                    Title = m.Title,
                    Rating = m.Rating.ToString("F2"),
                    TotalIncomes = m.Projections.Sum(p => p.Tickets.Sum(t => t.Price)).ToString("F2"),
                    Customers =  m.Projections
                        .SelectMany(p => p.Tickets)
                            .Select(t => t.Customer)
                            .Select(c => new CustomerMovieExportDto
                            {
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                Balance = c.Balance.ToString("F2")
                            })
                            .OrderByDescending(c => c.Balance)
                            .ThenBy(c => c.FirstName)
                            .ThenBy(c => c.LastName)
                        .ToList()
                })
                .Take(10)
                .ToList();

            var resultMovies = JsonConvert.SerializeObject(movies, Formatting.Indented);
            return resultMovies;
        }

        public static string ExportTopCustomers(CinemaContext context, int age)
        {
            var customers = context.Customers
                .Where(c => c.Age >= age)
                .Select(c => new CustomerExportDto
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    SpentMoney = c.Tickets.Sum(t => t.Price).ToString("F2"),
                    SpentTime = new DateTime(c.Tickets
                        .Sum(t => t.Projection.Movie.Duration.Ticks)
                        )
                    .ToString("hh\\:mm\\:ss")
                })
                .ToList();

            var serializer = new XmlSerializer(typeof(CustomerExportDto[]), new XmlRootAttribute("Customers"));

            var sb = new StringBuilder();

            serializer.Serialize(new StringWriter(sb), customers);

            return sb.ToString();
        }
    }
}