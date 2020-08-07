using Api.Domain.Dtos.Cep;
using System;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public Guid CepId { get; set; }
        public CepDto Cep { get; set; }
    }
}
