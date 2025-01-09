using Aplication.DTO;
using Domain.Models;

namespace Aplication.Interfaces
{
    public interface IApiService
    {
        Task<ResponseDefault<string>> GetDataAsync(string endpoint, Usuario usuario, Parametros parametros);
        Task<ResponseDefault<string>> PostDataAsync(string endpoint, string jsonContent);
    }
}
