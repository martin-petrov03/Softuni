namespace HospitalDatabase.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Medicament
    {
        [Required]
        public int MedicamentId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
