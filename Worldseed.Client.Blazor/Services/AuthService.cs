using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Worldseed.Client.Blazor.DTOs;

namespace Worldseed.Client.Blazor.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public async Task<LoginTokenResponseDTO?> EnsureValidTokenAsync()
        {
            var tokenInfo = await _localStorage.GetItemAsync<LoginTokenResponseDTO>("JWT");
            if (tokenInfo == null)
            {
                return null;
            }

            if (tokenInfo.ValidTo <= DateTime.UtcNow.AddMinutes(1))
            {
                using var response = await _httpClient.PostAsJsonAsync(
                    "api/Auth/refresh-token",
                    tokenInfo.RefreshTokenDTO);
                if (response.IsSuccessStatusCode)
                {
                    var newToken = await response.Content.ReadFromJsonAsync<LoginTokenResponseDTO>();
                    if (newToken != null)
                    {
                        await _localStorage.SetItemAsync("JWT", newToken);
                        tokenInfo = newToken;
                    }
                }
            }

            return tokenInfo;
        }

        public async Task SetAuthHeaderAsync()
        {
            var token = await EnsureValidTokenAsync();
            if (token != null && !string.IsNullOrEmpty(token.Token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token.Token);
            }
        }
    }
}
