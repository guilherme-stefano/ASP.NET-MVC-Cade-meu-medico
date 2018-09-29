using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.ViewModels
{
    public class CidadesViewModel
    {

        [Required(ErrorMessage = "Obrigatório Informar a Cidade")]
        [StringLength(80, ErrorMessage = "O nome deve possuir no mínimo 80 caracteres")]
        public string Nome { get; set; }

        public Nullable<int> IDEstado { get; set; }

        public virtual ICollection<MedicosViewModel> Medicos { get; set; }
    }
}