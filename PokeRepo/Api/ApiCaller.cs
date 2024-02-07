using Newtonsoft.Json;
using PokeRepo.Models;

namespace PokeRepo.Api
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://pokeapi.co/");
        }

        public async Task<Root> MakeCall(string Url)
        {

            HttpResponseMessage response = await Client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    return result;
                }
            }
            throw new HttpRequestException("Could not deserialize Json");
        }
    }
}
