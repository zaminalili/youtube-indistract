namespace youtube_indistract.Endpoints;

public static class VideoEndpoints
{
    public static string GetVideoById(string videoId, string apiKey)
        => $"videos?part=snippet,contentDetails,statistics,player&id={videoId}&key={apiKey}";
    public static string GetVideoPlayerById(string videoId, string apiKey)
        => $"videos?part=statistics,player&id={videoId}&key={apiKey}";
    public static string GetVideoStatisticsById(string videoId, string apiKey)
        => $"videos?part=statistics&id={videoId}&key={apiKey}";

    public static string GetVideosByChannelId(string channelId, string apiKey, string nextPageToken, int maxResult)
        => $"search?part=snippet&channelId={channelId}&type=video&maxResults={maxResult}&{nextPageToken}&key={apiKey}";

    public static string GetVideosByQuery(string query, string apiKey, string nextPageToken, int maxResult)
        => $"search?part=snippet&q={query}&type=video&maxResults={maxResult}&{nextPageToken}&key={apiKey}";

    public static string GetVideoComments(string videoId, string apiKey)
        => $"commentThreads?part=snippet&videoId={videoId}&maxResults=20&key={apiKey}";

    public static string GetVideoRatings(string videoId, string apiKey)
        => $"videos/getRating?id={videoId}&key={apiKey}";
}