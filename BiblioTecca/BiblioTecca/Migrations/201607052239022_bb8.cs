namespace BiblioTecca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bb8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "LocacaoDataAluguel", c => c.DateTime(nullable: false));
            AddColumn("dbo.Locacao", "LocacaoDataLimite", c => c.DateTime(nullable: false));
            AddColumn("dbo.Locacao", "LocacaoDataDevolucao", c => c.DateTime(nullable: false));
            DropColumn("dbo.Locacao", "LocacaoData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locacao", "LocacaoData", c => c.DateTime(nullable: false));
            DropColumn("dbo.Locacao", "LocacaoDataDevolucao");
            DropColumn("dbo.Locacao", "LocacaoDataLimite");
            DropColumn("dbo.Locacao", "LocacaoDataAluguel");
        }
    }
}
