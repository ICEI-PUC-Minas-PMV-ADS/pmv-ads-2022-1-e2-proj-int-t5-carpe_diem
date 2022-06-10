using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAulaBackEnd.Models
{
    [Table("Imovel")]
    public class Imovel
    {
        [Key]

        public int IdImovel { get; set; }

        [ForeignKey("IdImovel")]
        public Hospede IdHospede { get; set; }


        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public string Cidade { get; set; }

        [Display(Name = "Tipo do Espaço")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public TipoEspaco TipoEsp { get; set; }

        [Display(Name = "Tipo da Acomodação")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public TipoAcomodacao TipoAc { get; set; }

        [Display(Name = "Quantidade de Hospedes")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int QtdeHospedes { get; set; }

        [Display(Name = "Foto 01")]
        public char Foto1 { get; set; }

    }

    public enum TipoEspaco
    {
        Quarto, Flat, Apartamento, Casa, Loft
    }

    public enum TipoAcomodacao
    {
        [Display(Name = "Espaço Completo")] EspacoCompleto,
        [Display(Name = "Quarto Inteiro")] QuartoInteiro,
        [Display(Name = "Quarto Compartilhado")] QuartoCompartilhado
    }

}
