using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using Api.Domain.Models.Uf;
using Api.Domain.Models.Users;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();
            #endregion;

            #region Endereco
            CreateMap<UfModel, UfDto>().ReverseMap();

            CreateMap<MunicipioModel, MunicipioDto>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>().ReverseMap();

            CreateMap<CepModel, CepDto>().ReverseMap();
            CreateMap<CepModel, CepDtoCreate>().ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>().ReverseMap();
            #endregion;
        }
    }
}
