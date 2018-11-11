using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.ViewModels
{
    public class CertificadosViewModel
    {
        public int IDCertificado { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Médico")]
        public Nullable<long> IDMedico { get; set; }
        public bool Certificado1 { get; set; }
        public bool Certificado2 { get; set; }
        public bool Certificado3 { get; set; }
        public bool Certificado4 { get; set; }
        public bool Certificado5 { get; set; }
        public bool Certificado6 { get; set; }
        public Nullable<int> CargaHoraria { get; set; }

        public virtual Medicos Medicos { get; set; }
    }
}