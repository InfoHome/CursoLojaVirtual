﻿using Quiron.LojaVirtual.Aplicacao;
using Quiron.LojaVirtual.Aplicacao.ServicoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}