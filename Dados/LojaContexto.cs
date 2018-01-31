using LojaWebEF.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaWebEF.Dados
{
    public class LojaContexto:DbContext //ajuda na interface com o banco de dados, crud que não vemos
    {
        public LojaContexto(DbContextOptions<LojaContexto> options):
        base(options){} //método construtor é executado quando instanciamos a classe, quando criamos um objeto

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Pedido>().ToTable("Pedido");
        }
    }
}