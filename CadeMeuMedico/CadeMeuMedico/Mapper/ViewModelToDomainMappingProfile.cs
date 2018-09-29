using AutoMapper;
using CadeMeuMedico.Models;
using CadeMeuMedico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MedicosViewModel, Medicos>();
            CreateMap<CidadesViewModel, Cidades>();
            CreateMap<EspecialidadesViewModel, Especialidades>();
            CreateMap<EstadosViewModel, Estados>();
        }
    }
}