using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NicolasRecaldeEvaluacionProgreso1.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Required]        
        public int Edad { get; set; }
        [Required]        
        public float Salario { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Nombre { get; set; }
        [AllowNull]
        public Boolean EsMayorEdad { get; set; }
        [Required]
        public DateOnly FechaNacimiento { get; set; }
    }
}
