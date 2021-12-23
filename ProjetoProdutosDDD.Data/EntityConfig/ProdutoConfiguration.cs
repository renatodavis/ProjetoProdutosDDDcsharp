using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

using System.Text;
using ProjetoProdutosDDD.Domain.Entities;

namespace ProjetoProdutosDDD.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.Id);

            


    }
    }
}
