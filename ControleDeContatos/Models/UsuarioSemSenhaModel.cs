using ControleDeContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o login do usuário.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe o email do usuário.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o perfil do usuário.")]
        public PerfilEnum? Perfil { get; set; }
    }
}
