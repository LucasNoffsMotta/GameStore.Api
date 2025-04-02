using System.Numerics;
using GameStore.Api.Data;
using GameStore.Api.DTO;
using GameStore.Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

GenreEndPoints.MapGenresEndpoints(app);
GamesEndPoints.MapGamesEndPoints(app);

await app.MigrateDBAsync();

app.Run();
