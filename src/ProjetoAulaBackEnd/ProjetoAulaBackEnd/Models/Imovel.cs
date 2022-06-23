using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAulaBackEnd.Models
{
    [Table("Imovel")]
    public class Imovel
    {
        [Key]
        public int IdImovel { get; set; }

        public int HospedeId { get; set; }

        [ForeignKey("HospedeId")]
        public Hospede Hospede { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public string Endereco { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public string Bairro { get; set; }

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

        [Display(Name = "Quantidade de Camas")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int QtdeCamas { get; set; }

        [Display(Name = "Quantidade de Quartos")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int QtdeQuartos { get; set; }

        [Display(Name = "Quantidade de Banheiros")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int QtdeBanheiros { get; set; }

        [Display(Name = "Foto 01")]
        public string Foto1 { get; set; }

        [Display(Name = "Foto 02")]
        public string Foto2 { get; set; }

        [Display(Name = "Foto 03")]
        public string Foto3 { get; set; }

        [Display(Name = "Foto 04")]
        public string Foto4 { get; set; }

        //[Display(Name = "O que seu espaço tem a oferecer?")]
        //[Required(ErrorMessage = "Obrigatório informar este campo!")]

        public bool Academia { get; set; }

        [Display(Name = "Aceita PET")]
        public bool PET { get; set; }

        [Display(Name = "Ar Condicionado")]
        public bool ArCondicionado { get; set; }

        [Display(Name = "Churrasqueira")]
        public bool Churrasqueira { get; set; }

        [Display(Name = "Cozinha")]
        public bool Cozinha { get; set; }

        [Display(Name = "Ducha Externa")]
        public bool DuchaExterna { get; set; }

        [Display(Name = "Elevador")]
        public bool Elevador { get; set; }

        [Display(Name = "Estacionamento")]
        public bool Estacionamento { get; set; }

        [Display(Name = "Jogos")]
        public bool Jogos { get; set; }

        [Display(Name = "Lareira")]
        public bool Lareira { get; set; }

        [Display(Name = "Máquina de Lavar")]
        public bool MaquinaLavar { get; set; }

        [Display(Name = "Pátio")]
        public bool Patio { get; set; }

        [Display(Name = "Piscina")]
        public bool Piscina { get; set; }

        [Display(Name = "Rampas")]
        public bool Rampa { get; set; }

        [Display(Name = "Sauna")]
        public bool Sauna { get; set; }

        [Display(Name = "Suíte")]
        public bool Suite { get; set; }

        [Display(Name = "Vista para o Mar")]
        public bool VistaMar { get; set; }

        [Display(Name = "Wi-Fi")]
        public bool WiFi { get; set; }

        [Display(Name = "Horário Check-In")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int CheckIn { get; set; }

        [Display(Name = "Horário Check-Out")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int CheckOut { get; set; }

        [Display(Name = "Distância para a Praia")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int DistanciaPraia { get; set; }

        [Display(Name = "Valor da Diária")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public int ValorDiaria { get; set; }

        [Display(Name = "Disponibilizar Imóvel")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public DisponImovel DispImovel { get; set; }

        [Display(Name = "Desativar Imóvel")]
        [Required(ErrorMessage = "Obrigatório informar este campo!")]
        public DesativarImovel DesativarImovel { get; set; }
    }

    public enum TipoEspaco
    {
        [Display(Name = "Escolha o Tipo de Espaço")] EscolhaEspaco, 
        Quarto, Flat, Apartamento, Casa, Loft
    }

    public enum TipoAcomodacao
    {
        [Display(Name = "Escolha o Tipo de Acomodação")] EscolhaAcomodacao, 
        [Display(Name = "Espaço Completo")] EspacoCompleto,
        [Display(Name = "Quarto Inteiro")] QuartoInteiro,
        [Display(Name = "Quarto Compartilhado")] QuartoCompartilhado
    }

    public enum DisponImovel
    {
        [Display(Name = "Disponibilizar Imóvel")] Disponibilizar,
        [Display(Name = "Somente Cadastrar Imóvel")] Cadastrar,
    }

    public enum DesativarImovel
    {
        [Display(Name = "Manter Imóvel Ativo")] ImovelAtivo,
        [Display(Name = "Desativar Imóvel")] Desativar,
    }

}