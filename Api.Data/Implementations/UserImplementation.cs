using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Apt.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;
        public UserImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

        public new async Task<UserEntity> SelectAsync(Guid id)
        {
            return await _dataset.Include(c => c.Cep)
                .ThenInclude(m => m.Municipio)
                .ThenInclude(u => u.Uf)
                .FirstOrDefaultAsync(c => c.Id.Equals(id));
        }
    }
}
