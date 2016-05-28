using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Quiron.LojaVirtual.Web.ViewModels;
using System.Web.Mvc;
using System;
using Quiron.LojaVirtual.HtmlHelpers;

namespace Quiron.LojaVirtual.UnitTest
{

    [TestClass]
    public class UnitTestQuiron
    {

        [TestMethod]
        public void CT_Take()
        {
            int[] nums = { 1, 3, 4, 6, 8, 9, 7, 5, 6, 0 };
            var lista = from p in nums.Take(3) select p;
            int[] teste = { 1, 3, 4 };

            CollectionAssert.AreEqual(teste,lista.ToArray());
        }

        [TestMethod]
        public void CT_Skip()
        {
            int[] nums = { 1, 3, 4, 6, 8, 9, 7, 5, 6, 0 };

            var lista = from p in nums.Take(10).Skip(5) select p;
            int[] teste = { 9, 7, 5, 6, 0 };

            CollectionAssert.AreEqual(teste, lista.ToArray());
        }
        [TestMethod]
        public void CT_PaginacaoHelpers_LinksDaPagina()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };
            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act
            MvcHtmlString ctResult = html.LinksDaPagina(paginacao, paginaUrl);

            //Acessert

            Assert.AreEqual(ctResult.ToString(),
                  @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>");

           
        }
    }
}
