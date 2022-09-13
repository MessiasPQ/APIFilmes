using AutoMapper;
using APIFilmes.Data.Dtos;
using APIFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIFilmes.Data.Dtos.Cinema;

namespace APIFilmes.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateEnderecoDto, Cinema>();
            CreateMap<Cinema, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Cinema>();
        }
    }
}
