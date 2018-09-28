using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    { 
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }
        [Range(18,70, ErrorMessage = "A idade tem que estar entre 18 e 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O Login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já está definido")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O Senha é obrigatório")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não se coincidem")]
        public string ConfirmarSenha { get; set; }

    }
}