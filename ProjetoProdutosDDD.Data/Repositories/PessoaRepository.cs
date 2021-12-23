using ProjetoProdutosDDD.Domain.Entities;
using ProjetoProdutosDDD.Domain.Interfaces;
using ProjetoProdutosDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoProdutosDDD.Infra.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
    }
}
