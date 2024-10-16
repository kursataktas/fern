using System.Text.Json.Serialization;

#nullable enable

namespace SeedApi;

public record CreateMovieRequest
{
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("rating")]
    public required double Rating { get; init; }
}
