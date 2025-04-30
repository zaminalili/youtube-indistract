namespace youtube_indistract.Models;
public class SearchResult
{
    public string Kind { get; set; } = default!;
    public string Etag { get; set; } = default!;
    public string NextPageToken { get; set; } = default!;
    public List<VideoItem> Items { get; set; } = default!;
    //public string RegionCode { get; set; } = default!;
    //public PageInfo PageInfo { get; set; } = default!;
}
