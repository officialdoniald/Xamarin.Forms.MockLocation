using Android.Content;
using Android.Hardware;
using Android.Locations;
using System;
using Xamarin.Forms;

namespace Plugin.MockLocationPlugin
{
    /// <summary>
    /// Interface for MockLocationPlugin
    /// </summary>
    public class MockLocationPluginImplementation : IMockLocationPlugin
    {
        public void SendMockLocation(IMockLocationPlugin.MockPosition position)
        {
            Location location = new Location(LocationManager.GpsProvider)
            {
                Latitude = position.Latitude,
                Longitude = position.Longitude,
                Altitude = position.Altitude,
                Time = DateTime.Now.Ticks,
                ElapsedRealtimeNanos = 100,
                Speed = position.Speed,
                Bearing = position.Bearing,
                Accuracy = position.Accuracy
            };

            LocationManager locationManager = Forms.Context.GetSystemService(Context.LocationService) as LocationManager;

            locationManager.AddTestProvider(LocationManager.GpsProvider, false, false, false, false, false, false, false, Power.Low, SensorStatus.AccuracyHigh);
            locationManager.SetTestProviderLocation(LocationManager.GpsProvider, location);
            locationManager.SetTestProviderEnabled(LocationManager.GpsProvider, true);
        }
    }
}