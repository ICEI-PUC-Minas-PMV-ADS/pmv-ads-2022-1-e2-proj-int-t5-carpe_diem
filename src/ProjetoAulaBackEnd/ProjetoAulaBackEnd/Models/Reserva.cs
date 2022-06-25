using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAulaBackEnd.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

        //public int IdHospede { get; set; }

        //[ForeignKey("IdHospede")]

        //public Hospede Hospede { get; set; }

        public int IdImovel { get; set; }

        [ForeignKey("IdImovel")]
        public Imovel Imovel { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar Checkin"))]
        public DateTime Checkin { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar Checkout"))]

        public DateTime Checkout { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
    }
}
