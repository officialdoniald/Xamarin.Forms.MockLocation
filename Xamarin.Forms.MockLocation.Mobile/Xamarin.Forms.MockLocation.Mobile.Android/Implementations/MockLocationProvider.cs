using System;
using Android.Content;
using Android.Hardware;
using Android.Locations;
using Xamarin.Forms.MockLocation.Implementation;
using Xamarin.Forms.MockLocation.Mobile.Droid.Implementations;

[assembly: Xamarin.Forms.Dependency(typeof(MockLocationProvider))]
namespace Xamarin.Forms.MockLocation.Mobile.Droid.Implementations
{
    public class MockLocationProvider : IMockLocationProvider
    {
        public void SendMockLocation(MockPosition position)
        {
            Location location = new Location(LocationManager.GpsProvider)
            {
                Latitude = position.Latitude,
                Longitude = position.Longitude,
                Altitude = position.Altitude,
                Time = DateTime.Now.Ticks,
                ElapsedRealtimeNanos = 100,
                Speed = 0.0f,
                Bearing = 0.0f,
                Accuracy = 0
            };

            LocationManager locationManager = MainActivity.Context.GetSystemService(Context.LocationService) as LocationManager;

            locationManager.AddTestProvider(LocationManager.GpsProvider, false, false, false, false, false, false, false, Power.Low, SensorStatus.AccuracyHigh);
            locationManager.SetTestProviderLocation(LocationManager.GpsProvider, location);
            locationManager.SetTestProviderEnabled(LocationManager.GpsProvider, true);
        }
    }
}