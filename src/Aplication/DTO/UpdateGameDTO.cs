using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.DTO;

public record class UpdateGameDTO(
    [Required][StringLength(50)] string name, 
    int genreID, 
    [Required][Range(1,1000)]decimal price,
    DateOnly releaseDate
    );

