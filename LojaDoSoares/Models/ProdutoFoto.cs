using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaDoSoares.Models;

[Table("ProdutoFoto")]
public class ProdutoFoto
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Por favor, informe o Produto")]
    public int ProdutoId { get; set; }

    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Required(ErrorMessage = "Por favor, informe a foto do produto")]
    [StringLength(100, ErrorMessage = "A descrição deve possuir no máximo 100 car")]
    public string Foto { get; set; }
    public string Descricao { get; set; }
}

