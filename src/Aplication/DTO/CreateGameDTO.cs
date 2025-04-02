using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.DTO;

public record class CreateGameDTO(
    [Required][StringLength(50)] string name, 
    int genreId, 
    [Required][Range(1,1000)]decimal price,
    DateOnly releaseDate
    );


    