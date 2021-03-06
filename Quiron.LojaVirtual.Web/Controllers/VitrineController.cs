﻿using Quiron.LojaVirtual.Aplicacao;
using Quiron.LojaVirtual.Aplicacao.ServicoApp;
using Quiron.LojaVirtual.HtmlHelpers.Model;
using Quiron.LojaVirtual.Web.ViewModels;
using System.Linq;
using System.Web.Mvc;


namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private readonly ProdutoServicoApp _srvProduto;
        
        public int ProdutosPorPagina = 10;

        public VitrineController()
        {
            _srvProduto = ProdutoServicoConstrutor.ProdutoRepositorio();
        }

        public ActionResult VitrineListaDeProdutos(int pagina = 1)
        {

            var lstProduto = _srvProduto.ListarProdutdos()
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina).OrderBy(p => p.ProdutoId);
            
            return View(lstProduto);
        }

        public ViewResult VitrineListaProdutoViewModel(string categoria, int pagina = 1)

       {
            VitrineViewModel model = new VitrineViewModel()
            {
                Produtos = _srvProduto.ListarProdutdos()
                 .Where(p => categoria == null || p.Categoria == categoria)
                 .OrderBy(p => p.Descricao)
                 .Skip((pagina - 1) * ProdutosPorPagina)
                 .Take(ProdutosPorPagina).OrderBy(p => p.ProdutoId),

                Paginacao = new Paginacao()
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _srvProduto.ListarProdutdos().Where(p => categoria == null || p.Categoria == categoria).Count()
                },

                CategoriaAtual = categoria
            };
            return View(model);

        }
    }
}