namespace StudentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public virtual ICollection<Resource> Resources { get; set; } = new HashSet<Resource>();

        public virtual ICollection<Homework> Homeworks { get; set; } = new HashSet<Homework>();
    }
}
