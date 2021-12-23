using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

using System.Text;
using ProjetoProdutosDDD.Domain.Entities;

namespace ProjetoProdutosDDD.Data.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.Id);

            Property(c => c.Nome)
                 .IsRequired()
                 .HasMaxLength(150);





    }
    }
}
