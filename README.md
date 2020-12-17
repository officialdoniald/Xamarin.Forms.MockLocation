# Xamarin.Forms.MockLocation
Mocking Location with Xamarin Forms

This will only work on Android. You can use this source code just in Android too, but this NuGet Package is especially for Xamarin.Forms.

1. Detect mock location:

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
            
2. Sending mock lockation from Standard Library:

DependencyService.Get<IMockLocationPlugin>().SendMockLocation(new IMockLocationPlugin.MockPosition()
{
  Longitude = 24.234234,
  Latitude = 46.3213123,
  Accuracy = 1.0f,
  Altitude = 15,
  Bearing = 5f,
  Speed = 50f
});
