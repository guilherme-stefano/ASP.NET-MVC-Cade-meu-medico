using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.ViewModels
{
    public class EstadosViewModel
    {

        public int IDEstado { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<CidadesViewModel> Cidades { get; set; }


    }
}