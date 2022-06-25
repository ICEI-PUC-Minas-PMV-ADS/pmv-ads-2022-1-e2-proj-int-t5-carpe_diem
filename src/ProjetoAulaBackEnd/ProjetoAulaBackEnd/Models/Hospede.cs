using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAulaBackEnd.Models
{
    [Table("Hospede")]
    public class Hospede
    {
        [Key]
        public int IdHospede { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = ("Obrigatório informar o nome completo"))]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o CPF"))]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = ("Obrigatório informar a data de nascimento"))]
        public string DataDeNascimento { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = ("Obrigatório informar o endereço"))]
        public string Endereco { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o telefone"))]
        public string Telefone { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o email"))]
        public string Email { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar senha"))]
        public string Senha { get; set; }

        [Required(ErrorMessage = ("Obrigatório repetir a  senha"))]
        public string Senha2 { get; set; }

        [Display(Name = "Tipo de Usuário")]
        public TipoUsuario TipoUsuario { get; set; }

        public ICollection<Imovel> Imoveis { get; set; }

        //public ICollection<Reserva> Reservas { get; set; }
    }    

    
    public enum TipoUsuario
    {
        [Display(Name ="Hóspede")]
        TipoHospede,
        [Display(Name ="Anfitrião")]
        TipoAnfitriao

    }
}
