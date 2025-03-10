using GameStore.Api.Data;
using GameStore.Api.DTO;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
    public static Game ConvertToEntity(this CreateGameDTO newGame)
    {
         return new Game()
            {
                Name = newGame.name,
                GenreID = newGame.genreId,
                Price = newGame.price,
                ReleaseDate = newGame.releaseDate
            };
    }

     public static Game ConvertUpdatedToEntity(this UpdateGameDTO newGame, int _id)
        {
            return new Game()
                {
                    id = _id,
                    Name = newGame.name,
                    GenreID = newGame.genreID,
                    Price = newGame.price,
                    ReleaseDate = newGame.releaseDate
                };
        }

    public static GameSummaryDTO CovertToGameSummaryDTO(this Game game)
    {
        return new(
            game.id,
            game.Name,
            game.Genre!.Name,
            game.Price,
            game.ReleaseDate   
        );   
    }

     public static GameDetailsDTO CovertToGameDetailsDTO(this Game game)
    {
        return new(
            game.id,
            game.Name,
            game.GenreID,
            game.Price,
            game.ReleaseDate   
        );   
    }


}
