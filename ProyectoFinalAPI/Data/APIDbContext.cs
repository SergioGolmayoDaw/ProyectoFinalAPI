using Microsoft.EntityFrameworkCore;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAPI.Data
{
    public class APIDbContext :DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Curriculum> Curricula { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Valoration> Valorations { get; set; }

    }
}
