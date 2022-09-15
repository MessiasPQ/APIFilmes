using System.ComponentModel.DataAnnotations;

namespace APIFilmes.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public String Nome { get; set; }

    }
}
