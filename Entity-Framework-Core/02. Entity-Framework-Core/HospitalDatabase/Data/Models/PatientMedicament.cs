namespace HospitalDatabase.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PatientMedicament
    {
        [Required]
        public ICollection<PatientMedicament> Prescriptions { get; set; } 
    }
}
