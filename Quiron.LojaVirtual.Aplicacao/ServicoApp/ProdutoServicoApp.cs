
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Dominio.RepositorioEF;
using System.Collections.Generic;
using System.Linq;

namespace Quiron.LojaVirtual.Aplicacao.ServicoApp
{


    public class ProdutoServicoApp
        
    {
        private readonly ProdutoRepositorio _prodoRepositorio;
        public ProdutoServicoApp(ProdutoRepositorio repProduto)
        {
            _prodoRepositorio = repProduto;
        }

        public IEnumerable<Produto> ListarProdutdos()
        {
            return _prodoRepositorio.Produtos;
        }

        public IEnumerable<Produto> ListarTopProdutdos(int valor)
        {
            return _prodoRepositorio.Produtos.Take(valor);
        }

    }

}
