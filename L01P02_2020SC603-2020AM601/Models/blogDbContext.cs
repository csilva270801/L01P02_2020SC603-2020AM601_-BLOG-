using Microsoft.EntityFrameworkCore;
using L01P02_2020SC603_2020AM601.Models;

namespace L01P02_2020SC603_2020AM601.Models
{
    public class blogDbcontext : DbContext
    {

        public blogDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set; }
    }
}
