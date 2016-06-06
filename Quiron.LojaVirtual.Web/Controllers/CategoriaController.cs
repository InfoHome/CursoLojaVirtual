using Quiron.LojaVirtual.Aplicacao;
using Quiron.LojaVirtual.Aplicacao.ServicoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ProdutoServicoApp _srvProduto;
        public CategoriaController()
        {
            _srvProduto = ProdutoServicoConstrutor.ProdutoRepositorio();
        }
        
 
        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            IEnumerable<string> categorias = _srvProduto.ListarProdutdos()
                .Select(c => c.Categoria)
                .Distinct()
                .OrderBy(c => c);

            return PartialView(categorias);

        }
    }
}