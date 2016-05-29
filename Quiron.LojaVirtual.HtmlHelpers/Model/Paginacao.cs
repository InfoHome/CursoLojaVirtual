using System;

namespace Quiron.LojaVirtual.HtmlHelpers.Model
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalDePagina
        {
            get
            {
                var qtds = (int)Math.Ceiling((decimal)(ItensTotal / ItensPorPagina));

                if ((ItensTotal % ItensPorPagina) > 0)
                {
                    ++qtds;
                }

                return qtds;
            }
        }
    }
}
