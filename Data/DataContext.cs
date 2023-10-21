using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Entity.User> User { get; set; }
        public DbSet<Entity.Messages> Messages { get; set; }
        public DbSet<Entity.Contents> Contents { get; set; }

        public DataContext() : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder         // налаштування підключення до БД
                .UseSqlServer(     // з пакету SqlServer - драйвери МS SQL
                    @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SocialNetwork;Integrated Security=True"
                );                 // рядок підключення - до неіснуючої (або порожної) БД
        }
    }
}
