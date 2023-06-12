using AutoMapper;
using PingPong.Application.DTOs;
using PingPong.Application.DTOs.GroupDto;
using PingPong.Application.DTOs.PlayerDto;
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
            CreateMap<PlayerModel, CreatePlayerDto>().ReverseMap();
            CreateMap<PlayerModel, GetPlayerDto>().ReverseMap();
            CreateMap<PlayerModel, PlayerScoreDto>().ReverseMap();
            CreateMap<GroupModel, GroupDto>().ReverseMap();
        }
    }
}
