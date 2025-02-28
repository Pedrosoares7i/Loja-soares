using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaDoSoares.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(50)]
    public string Nome { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }

    [Display(Name = "Exibir na Home?")]
    public bool ExibirHome { get; set; } = false;


}
