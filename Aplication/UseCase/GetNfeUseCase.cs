﻿using Aplication.Interfaces;
using Domain.Models;
using System.Text.Json;

namespace Aplication.UseCase
{
    public class GetNfeUseCase
    {
        private readonly IApiService _apiService;

        public GetNfeUseCase(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<DetalhesNfe>Execute(Usuario usuario)
        {
            var endpoint = "https://back-dfe.4lions.com.br/dfe/v1/public/GetListaNFe";

            var data = await _apiService.GetDataAsync(endpoint, usuario);
            return JsonSerializer.Deserialize<DetalhesNfe>(data);
        }
    }
}
