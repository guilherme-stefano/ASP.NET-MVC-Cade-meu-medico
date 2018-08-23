using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(EspecialidadeMetadado))]
    public partial class Especialidades { }
    public class EspecialidadeMetadado
    {
        [Required(ErrorMessage ="O campo nome é obrigatório")]
        [StringLength(80, ErrorMessage ="O nome deve possuir no mínimo 80 caracteres")]
        public string Nome { get; set; }
    }
}