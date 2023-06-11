using AutoMapper;
using PingPong.Application.DTOs;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.MappingProfile
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            CreateMap<PlayerModel, PlayerDto>().ReverseMap();
            CreateMap<TeamModel, TeamDto>().ReverseMap();
        }
    }
}
