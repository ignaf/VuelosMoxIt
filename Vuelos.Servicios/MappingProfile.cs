using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Data.Models;
using Vuelos.ViewModels;

namespace Vuelos.Servicios
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vuelo, VueloViewModel>();
            CreateMap<VueloViewModel, Vuelo>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}
