using System;

namespace ProjetoProdutosDDD.Domain.Entities
{
    public class Produto
    {
        
        public int Id { get; set; }
        
        public String DescricaoProduto { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int CodFornecedor { get; set; }
        public String DescricaoFornecedor { get; set; }
        //public String Cnpj { get; set; }
         
        public bool VerificaDataFabricacao(Produto produto)
        {
            return (produto.Situacao) && (produto.DataFabricacao < produto.DataValidade);
        }

        


    }
}
