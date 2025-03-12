using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Context
{
    public class HelloGreetingContext : DbContext
    {
        public HelloGreetingContext(DbContextOptions<HelloGreetingContext> options) : base(options)
        {

        }
        public virtual DbSet<GreetingEntity> Greetings { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }
    }
}