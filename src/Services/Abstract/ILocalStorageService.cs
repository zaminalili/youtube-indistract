namespace youtube_indistract.Services.Abstract;
public interface ILocalStorageService
{
    Task SetItemAsync(string key, string value);
    Task<string?> GetItemAsync(string key);
}
