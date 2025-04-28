using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NicolasRecaldeEvaluacionProgreso1.Models
{
    public class Plan_de_recompensas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        public DateOnly FechaInicio { get; set; }
        public int PuntosAcumulados { get; set; }
        [ForeignKey("Reserva")]
        public Reserva? Reserva { get; set; }
    }
}
