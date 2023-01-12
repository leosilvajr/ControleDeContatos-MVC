using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{                                   
    public class BancoContext : DbContext  //Adicionar a referencia herdada do EntityFrameWorkCore
    {
        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }   
    }
}
