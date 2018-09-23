namespace AplicacaoComCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Categoria = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Long(nullable: false, identity: true),
                        TituloPost = c.String(),
                        ResumoPost = c.String(),
                        ConteudoPost = c.String(),
                        DataPostagem = c.DateTime(nullable: false),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Posts", new[] { "CategoriaID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Categorias");
        }
    }
}
