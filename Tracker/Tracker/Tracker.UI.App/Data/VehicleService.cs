namespace Tracker.UI.App.Data
{ 
        public class VehicleService
        {
            public async Task<VehicleDTO[]> GetVehiclesAsync()
            {
                HttpClient client = new HttpClient();
                var response = await client.GetFromJsonAsync<VehicleDTO[]>("https://localhost:7164/WeatherForecast");
         
            return response;
            }
        }

}
