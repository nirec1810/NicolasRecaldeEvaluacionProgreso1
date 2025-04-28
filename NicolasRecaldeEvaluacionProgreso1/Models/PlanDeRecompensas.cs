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
        public string? Nombre { get; set; }

        [Required]
        public DateOnly FechaInicio { get; set; }

        [Required]
        public int PuntosAcumulados { get; set; }

        [NotMapped]
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }

        [ForeignKey("ClienteId")]
        public Clientes? Cliente { get; set; }

        [ForeignKey("ReservaId")]
        public Reserva? Reserva { get; set; }

        public void AgregarPuntosPorReserva()
        {
            PuntosAcumulados += 100;
        }
    }
}
