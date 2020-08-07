using Api.Domain.Dtos;
using Api.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services
{
    public interface ILoginService
    {
        Task<Object> FindByLogin(LoginDto login);
    }
}
