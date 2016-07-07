namespace Vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.FormasDePagamento",
                c => new
                    {
                        FormaDePagamentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.FormaDePagamentoId);
            
            CreateTable(
                "dbo.ItensVenda",
                c => new
                    {
                        ItensVendaId = c.Int(nullable: false, identity: true),
                        QuantidadeVendida = c.Int(nullable: false),
                        PrecoUnitario = c.Double(nullable: false),
                        Produto_ProdutoId = c.Int(),
                        Venda_VendaId = c.Int(),
                    })
                .PrimaryKey(t => t.ItensVendaId)
                .ForeignKey("dbo.Produtos", t => t.Produto_ProdutoId)
                .ForeignKey("dbo.Vendas", t => t.Venda_VendaId)
                .Index(t => t.Produto_ProdutoId)
                .Index(t => t.Venda_VendaId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        PrecoCompra = c.Double(nullable: false),
                        Markup = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        DataDaCompra = c.DateTime(nullable: false),
                        Cliente_ClienteId = c.Int(),
                        FormaDePagamento_FormaDePagamentoId = c.Int(),
                        Vendedor_VendedorId = c.Int(),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.FormasDePagamento", t => t.FormaDePagamento_FormaDePagamentoId)
                .ForeignKey("dbo.Vendedores", t => t.Vendedor_VendedorId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.FormaDePagamento_FormaDePagamentoId)
                .Index(t => t.Vendedor_VendedorId);
            
            CreateTable(
                "dbo.Vendedores",
                c => new
                    {
                        VendedorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Comissao = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.VendedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Vendedor_VendedorId", "dbo.Vendedores");
            DropForeignKey("dbo.ItensVenda", "Venda_VendaId", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "FormaDePagamento_FormaDePagamentoId", "dbo.FormasDePagamento");
            DropForeignKey("dbo.Vendas", "Cliente_ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.ItensVenda", "Produto_ProdutoId", "dbo.Produtos");
            DropIndex("dbo.Vendas", new[] { "Vendedor_VendedorId" });
            DropIndex("dbo.Vendas", new[] { "FormaDePagamento_FormaDePagamentoId" });
            DropIndex("dbo.Vendas", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.ItensVenda", new[] { "Venda_VendaId" });
            DropIndex("dbo.ItensVenda", new[] { "Produto_ProdutoId" });
            DropTable("dbo.Vendedores");
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtos");
            DropTable("dbo.ItensVenda");
            DropTable("dbo.FormasDePagamento");
            DropTable("dbo.Clientes");
        }
    }
}
