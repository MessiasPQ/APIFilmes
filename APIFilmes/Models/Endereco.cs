using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using APIFilmes.Models;
using System.Linq;
using System.Threading.Tasks;

namespace APIFilmes.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public Cinema Cinema { get; set; }
    }
}
