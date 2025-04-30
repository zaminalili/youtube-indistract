using youtube_indistract.Models;

namespace youtube_indistract.Services.Abstract;
public interface IYoutubeApiService
{
    Task<ContentResponse<SingleVideoResult>> GetVideoPlayerByIdAsync(string videoId, string apiKey);
    Task<ContentResponse<SearchResult>> SearchVideosAsync(string query, string apiKey, string nextPageToken = "", int maxResult = 15);
}
