namespace StudentSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public int Name { get; set; }
        
        public string PhoneNumber { get; set; }

        [Required]
        public bool RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
