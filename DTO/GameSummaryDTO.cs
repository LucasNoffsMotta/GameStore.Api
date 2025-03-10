namespace GameStore.Api.DTO;

public record class GameSummaryDTO(
    int id,
    string name, 
    string genre, 
    decimal price,
    DateOnly releaseDate);

