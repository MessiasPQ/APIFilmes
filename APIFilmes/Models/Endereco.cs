using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using APIFilmes.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public virtual Cinema Cinema { get; set; }
    }
}
