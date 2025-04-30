namespace youtube_indistract.Models;
public class ContentResponse<T> where T : class
{
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
    //public List<string>? Errors { get; set; }
    

    public ContentResponse<T> Success(T data)
    {
        IsSuccess = true;
        Data = data;
        return this;
    }
    
    public ContentResponse<T> Failed(string message)
    {
        IsSuccess = false;
        Message = message;
        return this;
    }
}
