using Microsoft.AspNetCore.Components;

namespace youtube_indistract.Statics;

public static class Embed
{
    public static MarkupString Decode(string videoId, int width = 560, int height = 315)
    {
        return new MarkupString($"<iframe  src='https://www.youtube.com/embed/{videoId}?rel=0'  frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen> </iframe>");
    }
}
