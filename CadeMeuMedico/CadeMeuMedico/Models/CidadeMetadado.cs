using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidades { }
    public class CidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatório Informar a Cidade")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no mínimo 80 caracteres")]
        public string Nome { get; set; }
    }
}