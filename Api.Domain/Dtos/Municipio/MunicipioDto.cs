using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIbge { get; set; }
        public Guid UfId { get; set; }
    }
}
