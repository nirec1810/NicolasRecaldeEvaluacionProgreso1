using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NicolasRecaldeEvaluacionProgreso1.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateOnly Entrada { get; set; }
        [Required]
        public DateOnly Salida { get; set; }
        [Required]
        public float Precio { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Informacion { get; set; }

        [ForeignKey("Clientes")]
        public Clientes? Cliente { get; set; }
    }
}
