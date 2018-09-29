using AutoMapper;
using CadeMeuMedico.Models;
using CadeMeuMedico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Mapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Medicos, MedicosViewModel>();
            CreateMap<Cidades, CidadesViewModel>();
            CreateMap<Especialidades, EspecialidadesViewModel>();
            CreateMap<Estados, EstadosViewModel>();
        }
    }
}