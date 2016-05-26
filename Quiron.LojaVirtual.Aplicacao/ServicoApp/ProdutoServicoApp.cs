
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Dominio.RepositorioEF;
using System.Collections.Generic;
using System.Linq;

namespace Quiron.LojaVirtual.Aplicacao.ServicoApp
{


    public class ProdutoServicoApp : ProdutoRepositorio
        
    {
        private readonly ProdutoRepositorio _prodoRepositorio;

        public ProdutoServicoApp(ProdutoRepositorio repProduto)
        {
            _prodoRepositorio = repProduto;
        }

        public IEnumerable<Produto> ListarProdutdos(int quant)
        {
           return _prodoRepositorio.Produtos.Take(quant);
        }

    }

}
