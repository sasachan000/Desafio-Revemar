using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControledeEstoqueVeiculos.Models;
public class Veiculo
{
    [Key]
    public int Id {get; set;}

    [Required(ErrorMessage = "A escolha de marca é obrigatória.")]
    [StringLength(50, ErrorMessage = "A marca não pode ter mais de 50 caracteres.")]
    public string Marca {get; set;} = string.Empty;

    [Required(ErrorMessage = "A escolha de modelo é obrigatória.")]
    [StringLength(50, ErrorMessage = "O modelo não pode ter mais de 50 caracteres.")]
    public string Modelo {get; set;} = string.Empty;

    [Required(ErrorMessage = "A escolha do ano é obrigatória.")]
    [Range(1900, 2030, ErrorMessage = "Informe um ano válido.")]
    public int Ano {get; set;}

    [Required(ErrorMessage = "A seleção de cor é obrigatória.")]
    [StringLength(25, ErrorMessage = "A cor não pode ter mais de 25 caracteres.")]
    public string Cor {get; set;} = string.Empty;

    [Display(Name = "Preço")]
    [Required(ErrorMessage = "O preço é obrigatório.")]
    [Range(0.01, 10000000.00, ErrorMessage = "Informe o valor do veículo.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco {get; set;}

    [Required(ErrorMessage = "A escolha do tipo de veículo é obrigatória.")]
    [StringLength(30, ErrorMessage = "O tipo não pode ter mais de 30 caracteres.")]
    public string Tipo {get; set;} = string.Empty;
    
    [Display(Name = "Situação")]
    [Required(ErrorMessage = "Por favor, escolha se o veículo está Disponível, Vendido ou Reservado.")]
    [StringLength(30, ErrorMessage = "A situação não pode ter mais de 30 caracteres.")]
    public string Situacao { get; set; } = string.Empty;

    public bool IsAtivo {get; set;} = true;
}