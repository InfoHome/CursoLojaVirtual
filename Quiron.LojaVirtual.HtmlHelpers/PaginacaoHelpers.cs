using Quiron.LojaVirtual.Web.ViewModels;
using System.Web.Mvc;
using System;
using System.Text;

namespace Quiron.LojaVirtual.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString LinksDaPagina(this HtmlHelper html, Paginacao paginacao, Func<int,string> paginaUrl )
        {
            StringBuilder lpResult = new StringBuilder();
            
            for (int i = 0; i < paginacao.TotalDePagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();
                tag.AddCssClass("btn btn-default");

                if(i== paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn btn - primary");

                }

                lpResult.Append(tag);
            }

            return MvcHtmlString.Create(lpResult.ToString());
        }
    }
}
