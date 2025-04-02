using System;
using System.Net.Http.Headers;
using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
: DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new {id = 1, Name = "Fighting"},
            new {id= 2, Name = "Roleplaying" },
            new {id = 3, Name = "RPG"},
            new {id = 4, Name = "Racing"},
            new {id = 5, Name = "Kids and Family"}
        );
    }
}
