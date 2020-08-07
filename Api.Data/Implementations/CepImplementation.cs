using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Apt.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class CepImplementation : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _dataset;

        public CepImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CepEntity>();
        }

        public new async Task<CepEntity> SelectAsync(Guid id)
        {
            return await _dataset.Include(c => c.Municipio)
                .ThenInclude(m => m.Uf)
                .FirstOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<CepEntity> SelectAsync(string cep)
        {
            return await _dataset.Include(c => c.Municipio)
                .ThenInclude(m => m.Uf)
                .FirstOrDefaultAsync(c => c.Cep.Equals(cep));
        }
    }
}
