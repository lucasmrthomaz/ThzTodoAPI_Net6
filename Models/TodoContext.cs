using Microsoft.EntityFrameworkCore;

namespace ThzTodoAPI.Models
{
    public class TodoContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        
        public TodoContext(IConfiguration configuration, DbContextOptions<TodoContext> options)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Uses SQLite3 for simple data storage.
            options.UseSqlite("DataSource=ThzTodoListAPI.db");
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}