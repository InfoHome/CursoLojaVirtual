using Quiron.LojaVirtual.Aplicacao.ServicoApp;

using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoServicoApp _srvProduto;
      
        public ActionResult Index()
        {
            var lstProduto = _srvProduto.ListarProdutdos(10);
            return View(lstProduto);
        }
    }
}