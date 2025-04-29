using Microsoft.JSInterop;
using youtube_indistract.Services.Abstract;

namespace youtube_indistract.Services.Concrete;
public class LocalStorageService : ILocalStorageService
{
    private readonly IJSRuntime jsRuntime;

    public LocalStorageService(IJSRuntime jsRuntime)
    {
        this.jsRuntime = jsRuntime;
    }

    public async Task<string?> GetItemAsync(string key)
    {
        return await jsRuntime.InvokeAsync<string>("localStorageHelper.getItem", key);
    }

    public async Task SetItemAsync(string key, string value)
    {
        await jsRuntime.InvokeVoidAsync("localStorageHelper.setItem", key, value);
    }
}
