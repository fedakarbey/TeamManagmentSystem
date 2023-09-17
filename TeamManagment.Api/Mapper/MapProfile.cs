using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Api.Models.DTOs;
using TeamManagment.Api.Models.Entities;

namespace TeamManagment.Api.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Kisi, KisiDTO>();
            CreateMap<KisiDTO, Kisi>();
        }
    }
}
