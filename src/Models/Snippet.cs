namespace youtube_indistract.Models;
public class Snippet
{
    public DateTime PublishedAt { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string ChannelId { get; set; } = default!;
    public string ChannelTitle { get; set; } = default!;
    public ThumbnailCollection Thumbnails { get; set; } = default!;

}
