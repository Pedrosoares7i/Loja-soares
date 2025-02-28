using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaDoSoares.Models;

[Table("produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    [Display(Name = "Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [StringLength(1000, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }

    [Display(Name = "Quantidade em Estoque")]
    [Required(ErrorMessage = "Por favor, informe a quantidade em estoque para continuar")]
    [Range(0, int.MaxValue)]
    public int QtdeEstoque { get; set; }

    [Display(Name = "Valor de custo")]
    [Required(ErrorMessage = "Por favor, informe o valor de custo")]
    [Column(TypeName = "numeric(10,2)")]
    [Range(0, double.MaxValue)]
    public decimal ValorCusto { get; set; }

    [Display(Name = "Valor de venda")]
    [Required(ErrorMessage = "Por favor, informe o valor de venda")]
    [Column(TypeName = "numeric(10,2)")]
    [Range(0, double.MaxValue)]
    public decimal ValorVenda { get; set; }

    public bool Destaque { get; set; } = false;


    public List<ProdutoFoto> Fotos { get; set; }

}
