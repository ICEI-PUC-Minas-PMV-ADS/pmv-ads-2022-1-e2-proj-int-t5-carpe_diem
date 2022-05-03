using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAulaBackEnd.Models
{
    [Table("Hospede")]
    public class Hospede
    {
        [Key]
        public int IdHospede { get; set; }
        [Required (ErrorMessage=("Obrigatório informar o nome completo!"))]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar a data de nascimento!"))]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar o endereço!"))]
        public string Endereco { get; set; }
        
        [Required(ErrorMessage = ("Obrigatório informar o telefone!"))]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = ("Obrigatório informar o email!"))]
        public string Email { get; set; }

        [Required(ErrorMessage = ("Obrigatório informar senha!"))]
        public string  Senha { get; set; }

    }
}
