using APIFilmes.Data.Dtos.Gerente;
using APIFilmes.Models;
using AutoMapper;

namespace APIFilmes.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}
