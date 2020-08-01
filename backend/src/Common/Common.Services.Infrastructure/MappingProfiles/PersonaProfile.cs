using AutoMapper;
using Common.Entities;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Services.Infrastructure.MappingProfiles
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            CreateMap<Persona, PersonaDTO>().ReverseMap();
        }
    }
}
