using System.ComponentModel.DataAnnotations;

namespace TP1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required,StringLength(20, ErrorMessage = "Taille max 20 characters")]
        public string Name { get; set; }
        [Required]
        public string Departement { get; set; }
        [Required]
        public int Salary { get; set; }

    }
}
