using System;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid CepId { get; set; }
        public CepEntity Cep { get; set; }
    }
}
