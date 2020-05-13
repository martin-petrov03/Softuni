namespace HospitalDatabase.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Diagnose
    {
        [Required]
        public int DiagnoseId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Comments { get; set; }

        [Required]
        public Patient Patient { get; set; }
    }
}
