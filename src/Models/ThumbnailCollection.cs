namespace youtube_indistract.Models;

public class ThumbnailCollection
{
    public Thumbnail Default { get; set; } = default!;
    public Thumbnail Medium { get; set; } = default!;
    public Thumbnail High { get; set; } = default!;
}
