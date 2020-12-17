using Plugin.MockLocationPlugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin.Forms.MockLocation.Mobile
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Thread thread = new Thread(async () =>
            {
                while (true)
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                    var location = await Geolocation.GetLocationAsync(request);

                    if (location != null)
                    {
                        if (location.IsFromMockProvider)
                        {
                            //Detect mocking location
                        }
                        else
                        {
                            //Detect normal location
                        }
                    }
                }
            });

            DependencyService.Get<IMockLocationPlugin>().SendMockLocation(new IMockLocationPlugin.MockPosition()
            {
                Longitude = 24.234234,
                Latitude = 46.3213123,
                Accuracy = 1.0f,
                Altitude = 15,
                Bearing = 5f,
                Speed = 50f
            });
        }
    }
}
