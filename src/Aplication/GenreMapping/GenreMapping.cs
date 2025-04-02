using System;
using GameStore.Api.DTO;
using GameStore.Api.Entities;

namespace GameStore.Api.GenreMapping;

public static class GenreMapping
{
    public static GenreDTO ToDto(this Genre genre)
    {
        return new GenreDTO(genre.id, genre.Name);
    }
}
