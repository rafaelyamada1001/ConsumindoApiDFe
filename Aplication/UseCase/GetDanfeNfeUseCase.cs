using Aplication.DTO;
using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class GetDanfeNfeUseCase
    {
        private readonly IApiService _apiService;

        public GetDanfeNfeUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<ResponseDefault<DanfeNfe>> Execute(Usuario usuario, Parametros parametros, string outputPath)
        {
            var endpoint = "https://backend.4lions.tec.br/dfe/v1/public/GetDANFE";

            var response = await _apiService.GetDataAsync(endpoint, usuario, parametros);

            if (!response.Sucesso)return new ResponseDefault<DanfeNfe>(false, $"Erro ao obter DANFE: {response.Mensagem}", null);
            

            try
            {
                var danfeNfe = JsonSerializer.Deserialize<DanfeNfe>(response.Dados);

                // Converte o Base64 em bytes
                var pdfBytes = Convert.FromBase64String(danfeNfe.msg);

                // Garante que o diretório existe
                var directory = Path.GetDirectoryName(outputPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Salva o PDF no caminho especificado
                await File.WriteAllBytesAsync(outputPath, pdfBytes);

                return new ResponseDefault<DanfeNfe>(true, "PDF salvo com sucesso.", null);
            }
            catch (FormatException)
            {
                return new ResponseDefault<DanfeNfe>(false, "O conteúdo recebido não é um Base64 válido.", null);
            }
            catch (Exception ex)
            {
                return new ResponseDefault<DanfeNfe>(false, $"Erro ao salvar PDF: {ex.Message}", null);
            }
        }
    }
}
