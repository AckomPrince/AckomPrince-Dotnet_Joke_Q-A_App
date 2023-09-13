using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokeGenius.Models;

namespace MvcJoke.Data
{
    public class MvcJokeContext : DbContext
    {
        public MvcJokeContext (DbContextOptions<MvcJokeContext> options)
            : base(options)
        {
        }

        public DbSet<JokeGenius.Models.Joke> Joke { get; set; } = default!;
    }
}
