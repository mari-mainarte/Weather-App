using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherAppService
    {
        //21a98e40b60436fb3cc8fe3abc8f3f4b

        private HttpClient httpClient;
        private Cidade cidade;
        private JsonSerializerOptions jsonSerializerOptions;
        private string apiKey = "21a98e40b60436fb3cc8fe3abc8f3f4b";

        public WeatherAppService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<Cidade> GetCidadeAsync(string cityName)
        {
            Uri uri = new Uri($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}");
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    cidade = JsonSerializer.Deserialize<Cidade>(content, jsonSerializerOptions);
                }
            }
            catch
            {

            }
            return cidade;
        }
    }
}
