using GameStore.Api.Data;
using GameStore.Api.GenreMapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.EndPoints;

public static class GenreEndPoints
{
    public static WebApplication MapGenresEndpoints(this WebApplication app)
    {
        var groups = app.MapGroup("genres");

        //GET/GENRES
        groups.MapGet("/", async (GameStoreContext dbContext) => 

        await dbContext.Genres
                        .Select(genre => genre.ToDto())
                        .AsNoTracking()
                        .ToListAsync()
        );
        return app;
    }
}
