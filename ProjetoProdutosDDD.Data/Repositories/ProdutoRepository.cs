using ProjetoProdutosDDD.Domain.Entities;
using ProjetoProdutosDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoProdutosDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarporNome(string nome)
        {
            return Db.Produtos.Where(p => p.DescricaoProduto == nome);           
        }
    }
}
