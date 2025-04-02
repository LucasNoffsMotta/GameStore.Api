using GameStore.Api.Data;
using GameStore.Api.DTO;
using GameStore.Api.Entities;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.EndPoints;

public static class GamesEndPoints
{
    const string GetGameEndPointName = "GetGame";

    public static WebApplication MapGamesEndPoints(this WebApplication app)
    {
        var groups = app.MapGroup("games").WithParameterValidation();

        //GET /games
        groups.MapGet("/", async (GameStoreContext dbContext) => 
        await dbContext.Games
                .Include(game => game.Genre)
                .Select(game => game.CovertToGameSummaryDTO())
                .AsNoTracking()
                .ToListAsync()  
        );

        //GET /games/1
        groups.MapGet("/{id}", async (int id, GameStoreContext dbContext) => {
            
            Game? game = await dbContext.Games.FindAsync(id);

            return game is null ? Results.NotFound() : Results.Ok(game.CovertToGameDetailsDTO());
        })
        .WithName(GetGameEndPointName);

        //POST /games
        groups.MapPost("/", async (CreateGameDTO newGame, GameStoreContext dbContext) =>
        {
            Game game = newGame.ConvertToEntity();

            dbContext.Games.Add(game);
            await dbContext.SaveChangesAsync();
       
            return Results.CreatedAtRoute(GetGameEndPointName, new {id = game.id}, game.CovertToGameDetailsDTO());
        }).WithParameterValidation();

        //PUT//games/id
        groups.MapPut("/{id}", async (int id, UpdateGameDTO updatedGame, GameStoreContext dbContext) =>
        {
        
        Game? game = await dbContext.Games.FindAsync(id);

        if (game is null)
        {
            return Results.NotFound();
        }

        dbContext.Games.Entry(game)
        .CurrentValues
        .SetValues(updatedGame.ConvertUpdatedToEntity(id));  

        await dbContext.SaveChangesAsync();

        return Results.NoContent();

        });

        //Delete//Games/1
        groups.MapDelete("/{id}", async (int id, GameStoreContext dbContext) => 
        {
            await dbContext.Games
                    .Where(game => game.id == id)
                    .ExecuteDeleteAsync();

            return Results.NoContent();
        });
        return app;
    }
}
