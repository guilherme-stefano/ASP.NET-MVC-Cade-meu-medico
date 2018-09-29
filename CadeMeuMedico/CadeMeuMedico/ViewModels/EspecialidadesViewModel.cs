using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.ViewModels
{
    public class EspecialidadesViewModel
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no mínimo 80 caracteres")]
        public string Nome { get; set; }

        public int IDEspecialidade { get; set; }

        public virtual ICollection<MedicosViewModel> Medicos { get; set; }
    }
}