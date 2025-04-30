using System.Text.Json.Serialization;
using System.Text.Json;

namespace youtube_indistract.Extensions;
public static class ResponseExtensions
{
    public static async Task<T?> ToResponseAsync<T>(this HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            ReferenceHandler = ReferenceHandler.Preserve
        });

        return result;
    }
}
