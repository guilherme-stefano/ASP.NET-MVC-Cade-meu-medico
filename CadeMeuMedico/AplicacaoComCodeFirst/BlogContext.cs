namespace AplicacaoComCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-5LSHH6H; Database= testechulo; Integrated Security=SSPI; Uid=auth_windows;";
        }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Posts> Posts { get; set; }
    }
}