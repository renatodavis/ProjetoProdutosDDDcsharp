using ProjetoProdutosDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoProdutosDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarporNome(string nome);
    }
}
