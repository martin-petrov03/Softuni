namespace HospitalDatabase.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    
    public class Patient
    {
        [Required]
        public int PatientId { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(80)]
        [Required]
        public string Email { get; set; }

        [Required]
        public bool HasInsurance { get; set; }
    }
}
