using Quiron.LojaVirtual.Dominio.Contexto;
using Quiron.LojaVirtual.Dominio.Entidade;
using System.Collections.Generic;


namespace Quiron.LojaVirtual.Dominio.RepositorioEF
{

    public class ProdutoRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }

        }

        public IEnumerable<Produto> ListarProdutdos()
        {
            return _context.Produtos;
        }
    }
}
