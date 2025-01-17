using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades
{
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(155)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Marca { get; set; }

        [Required]
        public int Ano { get; set; }

    }
}