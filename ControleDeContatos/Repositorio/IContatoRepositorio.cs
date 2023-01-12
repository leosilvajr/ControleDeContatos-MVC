using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio //Depois implementar dentro da Classe ContatoRepositorio
    {

        List<ContatoModel> BuscarTodos();

        //Contrato Adicionar que recebe como parametro um objeto Contrato
        ContatoModel Adicionar(ContatoModel contato);
    }
}
