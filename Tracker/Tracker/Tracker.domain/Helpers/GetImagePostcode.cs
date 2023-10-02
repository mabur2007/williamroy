using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;
using Geocoding;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Maps;

namespace Tracker.domain.Helpers
{
    public class GetImagePostcode
    {

        public async Task<List<string>> GetAddressesFromImage(string Path)
        {
            double latitude, longitude;
            using (var reader = new ExifReader(Path))
            {
                // Get the GPS coordinates from the EXIF data.

                reader.GetTagValue(ExifTags.GPSLatitude, out latitude);
                reader.GetTagValue(ExifTags.GPSLongitude, out longitude);
            }

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
