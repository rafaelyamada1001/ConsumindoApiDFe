using Domain.Models;

namespace Aplication.Interfaces
{
    public interface IApiService
    {
        Task<string> GetDataAsync(string endpoint, Usuario usuario);
        Task<string> PostDataAsync(string endpoint, string jsonContent);
    }
}
