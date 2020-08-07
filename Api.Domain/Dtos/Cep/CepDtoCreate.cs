using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoCreate
    {
        [Required(ErrorMessage = "Logradouro é um campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero é um campo obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "CEP é um campo obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é um campo obrigatório")]
        public Guid MunicipioId { get; set; }
    }
}
