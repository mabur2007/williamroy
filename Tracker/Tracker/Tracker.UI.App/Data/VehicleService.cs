using ExifLib;
using Xamarin.Forms.Maps;
using Geocoding;
using System.Text.Json;
using System.Text;
using Geocoding.Microsoft.Json;

namespace Tracker.UI.App.Data
{
    public class VehicleService
    {
        public async Task<VehicleDTO[]> GetVehiclesAsync()
        {
                HttpClient client = new HttpClient();
                var response = await client.GetFromJsonAsync<VehicleDTO[]>("https://localhost:7164/Vehicle");
         
            return response;
        }

        public async Task<bool> AddVehiclesAsync(VehicleDTO vehicle)
        {
            var jsonPayload = JsonSerializer.Serialize(vehicle);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            var resp = await client.PostAsync("https://localhost:7164/Vehicle", content);

            if (resp.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<List<string>> GetAddressesFromImage(string Path)
        {
            //double latitude, longitude;
            //using (var reader = new ExifReader(Path))
            //{
            // Get the GPS coordinates from the EXIF data.

            //    reader.GetTagValue(ExifTags.GPSLatitude, out latitude);
            //    reader.GetTagValue(ExifTags.GPSLongitude, out longitude);
            // }

            var reader = new ExifReader(Path);
            reader.GetTagValue(ExifTags.GPSLatitude, out double latitude);
            reader.GetTagValue(ExifTags.GPSLongitude, out double longitude);

            var geocoder = new Geocoder();
            var position = new Position(latitude, longitude);
            var address = await geocoder.GetAddressesForPositionAsync(position);

            foreach (var s in address)
            {
                Console.WriteLine(s);
            }
            return address.ToList();

        }
    }



}
