using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="Informe o nome do contato.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Informe o email.")]
        [EmailAddress(ErrorMessage ="E-mail inválido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Informe o celular")]
        [Phone(ErrorMessage ="Celular inválido.")]
        public string Celular { get; set; }
    }
}
