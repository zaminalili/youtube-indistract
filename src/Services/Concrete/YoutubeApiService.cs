using youtube_indistract.Endpoints;
using youtube_indistract.Extensions;
using youtube_indistract.Models;
using youtube_indistract.Services.Abstract;

namespace youtube_indistract.Services.Concrete;
public class YoutubeApiService : IYoutubeApiService
{
    //private readonly string apiKey;
    private readonly ILogger<YoutubeApiService> logger;
    private readonly HttpClient httpClient;

    public YoutubeApiService(HttpClient httpClient, ILogger<YoutubeApiService> logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<ContentResponse<SingleVideoResult>> GetVideoPlayerByIdAsync(string videoId, string apiKey)
    {
        try
        {
            logger.LogInformation("Getting video by id {videoId}", videoId);

            var response = await httpClient
                .GetAsync(VideoEndpoints.GetVideoById(videoId, apiKey));

            if (!response.IsSuccessStatusCode)
            {
                logger.LogError("Error: {statusCode}", response.StatusCode);
                return new ContentResponse<SingleVideoResult>().Failed($"Response status code: {response.StatusCode}.");
            }


            logger.LogInformation("Response status code {statusCode}", response.StatusCode);

            var content = await response.ToResponseAsync<SingleVideoResult>();

            return new ContentResponse<SingleVideoResult>().Success(content);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return new ContentResponse<SingleVideoResult>().Failed(ex.Message);
        }
    }

    public async Task<ContentResponse<SearchResult>> SearchVideosAsync(string query, string apiKey, string nextPageToken = "", int maxResult = 15)
    {
        try
        {
            logger.LogInformation("Getting video by query {query}", query);

            var response = await httpClient
                .GetAsync(VideoEndpoints.GetVideosByQuery(query, apiKey, nextPageToken, maxResult));

            if(!response.IsSuccessStatusCode)
            {
                logger.LogError("Error: {statusCode}", response.StatusCode);
                return new ContentResponse<SearchResult>().Failed($"Response status code: {response.StatusCode}.");
            }

            logger.LogInformation("Response status code {statusCode}", response.StatusCode);

            var content = await response.ToResponseAsync<SearchResult>();

            return new ContentResponse<SearchResult>().Success(content);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
            return new ContentResponse<SearchResult>().Failed(ex.Message);
        }
    }
}
