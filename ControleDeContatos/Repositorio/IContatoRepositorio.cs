using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio //Depois implementar dentro da Classe ContatoRepositorio
    {
        //Buscar contato pela Id
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos();

        //Contrato Adicionar que recebe como parametro um objeto Contrato
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
    }
}
