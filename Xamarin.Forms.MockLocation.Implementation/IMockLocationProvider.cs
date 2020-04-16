namespace Xamarin.Forms.MockLocation.Implementation
{
    public interface IMockLocationProvider
    {
        void SendMockLocation(MockPosition mockPosition);
    }

    public class MockPosition
    {
        public double Longitude { get; set; }

        public double Latitude { get; set; }

        /// <summary>
        /// Default value: 1.0.
        /// </summary>
        public double Altitude { get; set; } = 1.0;
    }
}