


namespace Projeto1.Data{

    public class DataContext : DbContext
    {
        public DbSet <Categoria> Categorias  { get; set; }

        public DbSet <User> Users  { get; set; }


    }
}