using PlatformService.Dtos;
using System.Text;
using System.Text.Json;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        async Task ICommandDataClient.SendProfileToCommand(ProfileReadDtos profile)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(profile),
                Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("http://localhost:5037/api/c/profiles", httpContent);
            
            
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("---> Sync POST to CommandService was OK!");
            }
            else
            {
                Console.WriteLine("---> Sync POST to CommandServices was NOT OK!");
            }
        }
    }
}
