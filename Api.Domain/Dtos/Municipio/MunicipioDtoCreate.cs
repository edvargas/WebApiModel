using Api.Domain.Dtos.Uf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoCreate
    {
        [Required(ErrorMessage = "Nome de município é um campo obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome de município deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "Codigo do IBGE inválido.")]
        public int CodIbge { get; set; }
        
        [Required(ErrorMessage = "Codigo de UF é obrigatório.")]
        public Guid UfId { get; set; }
    }
}
