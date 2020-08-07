using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Apt.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class MunicipioImplementation : BaseRepository<MunicipioEntity>, IMunicipioRepository
    {
        private DbSet<MunicipioEntity> _dataset;

        public MunicipioImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<MunicipioEntity>();
        }

        public async Task<MunicipioEntity> GetCompleteByIbge(int codIbge)
        {
            return await _dataset.Include(m => m.Uf)
                .FirstOrDefaultAsync(m => m.CodIbge.Equals(codIbge));
        }

        public async Task<MunicipioEntity> GetCompleteById(Guid id)
        {
            return await _dataset.Include(m => m.Uf)
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
        }
    }
}
