using Quiron.LojaVirtual.Aplicacao.ServicoApp;
using Quiron.LojaVirtual.Dominio.RepositorioEF;


namespace Quiron.LojaVirtual.Aplicacao
{
    public class ProdutoServicoConstrutor
    {
        public static ProdutoServicoApp ProdutoRepositorio()
        {
            return new ProdutoServicoApp(new ProdutoRepositorio());
        }
    }
}
