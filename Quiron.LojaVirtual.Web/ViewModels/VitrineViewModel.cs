using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.HtmlHelpers.Model;
using System.Collections.Generic;

namespace Quiron.LojaVirtual.Web.ViewModels
{
    public class VitrineViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }
        public string CategoriaAtual { get; set; }
    }
}