namespace Aplication.Interfaces
{
    public interface IApiService
    {
        Task<string> GetDataAsync(string endpoint);
    }
}
