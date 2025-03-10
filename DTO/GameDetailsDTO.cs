namespace GameStore.Api.DTO;

public record class GameDetailsDTO(
    int id,
    string name, 
    int genreId, 
    decimal price,
    DateOnly releaseDate);

