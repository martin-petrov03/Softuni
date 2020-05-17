namespace StudentSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        [Required]
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string ContentType { get; set; }

        [Required]
        public int SubmissionTime { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StuedntId { get; set; }
        public virtual Student Student { get; set; }

        [Required]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
