namespace Aplication.Interfaces
{
    public interface IApiService
    {
        Task<string> GetDataAsync(string endpoint);

        Task<string> PostDataAsync(string endpoint, string jsonContent);
    }
}
