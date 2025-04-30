namespace youtube_indistract.Models;
public class VideoPlayerItem
{
    public string Id { get; set; } = default!;
    public string Kind { get; set; } = default!;
    public string Etag { get; set; } = default!;
    public VideoStatistics Statistics { get; set; } = default!;
    public Snippet Snippet { get; set; } = default!;
    public Player Player { get; set; } = default!;

}
