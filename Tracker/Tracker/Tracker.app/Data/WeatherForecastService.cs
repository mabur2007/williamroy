using Tracker.domain.Entities;
using static System.Net.WebRequestMethods;

namespace Tracker.app.Data
{
    public class WeatherForecastService
    {
        /*     private static readonly string[] Summaries = new[]
             {
             "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
         };

             public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
             {
                 return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                 {
                     Date = startDate.AddDays(index),
                     TemperatureC = Random.Shared.Next(-20, 55),
                     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                 }).ToArray());
             }*/

        //HttpClient client = new HttpClient();
        //HttpResponseMessage response = await client.GetAsync("https://localhost:5001/api/products");
        public async Task<VehicleDTO[]> GetVehiclesAsync()
        {
            //var products = await Http.GetFromJsonAsync<Vehicle[]>("https://yourapiurl/products");
            HttpClient client = new HttpClient();
            //HttpResponseMessage response = await client.GetAsync("https://localhost:5001/api/products");
            var response = await client.GetFromJsonAsync<VehicleDTO[]>("https://localhost:7164/WeatherForecast");
            return response;
        }
    }



}