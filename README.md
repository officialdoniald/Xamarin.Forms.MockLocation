# Xamarin.Forms.MockLocation
Mocking Location with Xamarin Forms

This will only work on Android. You can use this source code just in Android too, but this NuGet Package is especially for Xamarin.Forms.

0. Set your AndroidManifest.xml:

https://github.com/officialdoniald/Xamarin.Forms.MockLocation/blob/master/Xamarin.Forms.MockLocation.Mobile/Xamarin.Forms.MockLocation.Mobile.Android/Properties/AndroidManifest.xml

<!-- wp:paragraph -->
<p>Deploy your app to the phone and close it. </p>
<!-- /wp:paragraph -->

<!-- wp:paragraph -->
<p>One more important thing: only the System app can send mock locations, so we have to call for the operation system, that this will send mock locations. So if you haven’t already, let’s enable developer mode on your phones and go to developer options. </p>
<!-- /wp:paragraph -->

<!-- wp:image {"align":"center","id":150,"sizeSlug":"large","linkDestination":"none"} -->
<div class="wp-block-image"><figure class="aligncenter size-large"><img src="https://officialdoniald.com/wp-content/uploads/2020/12/Inkedhow-to-enabling-mock-location-etp_LI-575x1024-1.jpg" alt="" class="wp-image-150"/></figure></div>
<!-- /wp:image -->

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
