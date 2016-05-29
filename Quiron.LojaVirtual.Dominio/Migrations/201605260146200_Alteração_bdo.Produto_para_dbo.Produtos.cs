namespace Quiron.LojaVirtual.Dominio.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Alteração_bdoProduto_para_dboProdutos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produto", newName: "Produtos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produtos", newName: "Produto");
        }
    }
}
