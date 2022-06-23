using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAulaBackEnd.Models
{
    public class FaleConosco
    {
        [Required(ErrorMessage = ("Obrigatório informar o nome completo"))]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Deixe aqui sua mensagem.")]
        [DisplayName("Mensagem")]
        [StringLength(5000, MinimumLength = 20)]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

    }
}
