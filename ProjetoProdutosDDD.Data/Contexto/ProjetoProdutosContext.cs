

using ProjetoProdutosDDD.Data.EntityConfig;
using ProjetoProdutosDDD.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoProdutosDDD.Infra.Data.Contexto
{
    public class ProjetoProdutosContext : DbContext

    {
        public ProjetoProdutosContext()
            : base("ProjetoProdutosDDD")
        {
            
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //deleta em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(150));


            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());




        }
    }
}

