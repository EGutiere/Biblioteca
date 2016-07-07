namespace BiblioTecca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Biblioteca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        IdLivro = c.Int(nullable: false, identity: true),
                        LivroNome = c.String(),
                        LivroColetanea = c.String(),
                        LivroClassificacao = c.String(),
                        LivroSituacao = c.String(),
                        LivroStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdLivro);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        IdPessoa = c.Int(nullable: false, identity: true),
                        PessoaNome = c.String(),
                        PessoaCpf = c.String(),
                    })
                .PrimaryKey(t => t.IdPessoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
            DropTable("dbo.Livros");
        }
    }
}
