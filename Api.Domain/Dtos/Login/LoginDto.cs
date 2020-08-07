using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email é obrigatório para o login")]
        [EmailAddress(ErrorMessage = "Formato do Email inválido")]
        [StringLength(100, ErrorMessage = "Tamanho máximo é {1} caracteres")]
        public string Email { get; set; }
    }
}
