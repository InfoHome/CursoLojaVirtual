using Quiron.LojaVirtual.Aplicacao;
using Quiron.LojaVirtual.Aplicacao.ServicoApp;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
  
    public class ProdutoController : Controller
    {
        private readonly ProdutoServicoApp _srvProduto ;
        public ProdutoController()
        {
            _srvProduto = ProdutoServicoConstrutor.ProdutoRepositorio();
        }

        public ActionResult Index()
        {
        
            var lstProduto = _srvProduto.ListarProdutdos();
            return View(lstProduto);
        }
    }
}