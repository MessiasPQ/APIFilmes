using System.ComponentModel.DataAnnotations;

namespace APIFilmes.Data.Dtos.Filmes
{
    public class UpdateFilmeDto
    {

        [Required(ErrorMessage = "O campo título é obrigatorio!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatorio!")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O gênero deve conter no maximo 30 caracteres.")]
        public string Genero { get; set; }

        [Range(1, 300, ErrorMessage = "A duração deve do filme deve estar entre 1-300 minutos.")]
        public int Duracao { get; set; }
    }
}
