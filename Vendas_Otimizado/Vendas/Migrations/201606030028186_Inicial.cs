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
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Rua = c.String(),
                        Numero = c.Int(nullable: false),
                        Cep = c.String(),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
            CreateTable(
                "dbo.FormasPagamento",
                c => new
                    {
                        FormaPagamentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.FormaPagamentoId);
            
            CreateTable(
                "dbo.ItensVendas",
                c => new
                    {
                        ItensVendasId = c.Int(nullable: false, identity: true),
                        QuantidadeVendida = c.Int(nullable: false),
                        PrecoUnitario = c.Double(nullable: false),
                        Produto_ProdutosId = c.Int(),
                        Venda_ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.ItensVendasId)
                .ForeignKey("dbo.Produtos", t => t.Produto_ProdutosId)
                .ForeignKey("dbo.Vendas", t => t.Venda_ClienteId)
                .Index(t => t.Produto_ProdutosId)
                .Index(t => t.Venda_ClienteId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutosId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        PrecoCompra = c.Double(nullable: false),
                        Markup = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutosId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        DataDaCompra = c.DateTime(nullable: false),
                        Cliente_ClienteId = c.Int(),
                        Endereco_EnderecoId = c.Int(),
                        FormaPagamento_FormaPagamentoId = c.Int(),
                        Vendedor_VendedoresId = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.Enderecos", t => t.Endereco_EnderecoId)
                .ForeignKey("dbo.FormasPagamento", t => t.FormaPagamento_FormaPagamentoId)
                .ForeignKey("dbo.Vendedores", t => t.Vendedor_VendedoresId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Endereco_EnderecoId)
                .Index(t => t.FormaPagamento_FormaPagamentoId)
                .Index(t => t.Vendedor_VendedoresId);
            
            CreateTable(
                "dbo.Vendedores",
                c => new
                    {
                        VendedoresId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Comissao = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.VendedoresId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Vendedor_VendedoresId", "dbo.Vendedores");
            DropForeignKey("dbo.ItensVendas", "Venda_ClienteId", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "FormaPagamento_FormaPagamentoId", "dbo.FormasPagamento");
            DropForeignKey("dbo.Vendas", "Endereco_EnderecoId", "dbo.Enderecos");
            DropForeignKey("dbo.Vendas", "Cliente_ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.ItensVendas", "Produto_ProdutosId", "dbo.Produtos");
            DropIndex("dbo.Vendas", new[] { "Vendedor_VendedoresId" });
            DropIndex("dbo.Vendas", new[] { "FormaPagamento_FormaPagamentoId" });
            DropIndex("dbo.Vendas", new[] { "Endereco_EnderecoId" });
            DropIndex("dbo.Vendas", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.ItensVendas", new[] { "Venda_ClienteId" });
            DropIndex("dbo.ItensVendas", new[] { "Produto_ProdutosId" });
            DropTable("dbo.Vendedores");
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtos");
            DropTable("dbo.ItensVendas");
            DropTable("dbo.FormasPagamento");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Clientes");
        }
    }
}
