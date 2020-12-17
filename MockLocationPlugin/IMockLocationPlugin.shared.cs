namespace Plugin.MockLocationPlugin
{
    public interface IMockLocationPlugin
    {
        void SendMockLocation(MockPosition mockPosition);

        public class MockPosition
        {
            public double Longitude { get; set; }

            public double Latitude { get; set; }

            /// <summary>
            /// Default value: 1.0.
            /// </summary>
            public double Altitude { get; set; } = 1.0;

            /// <summary>
            /// Default value: 1.0.
            /// </summary>
            public float Bearing { get; set; } = 1.0f;

            /// <summary>
            /// Default value: 0.0.
            /// </summary>
            public float Accuracy { get; set; } = 0.0f;

            /// <summary>
            /// Default value: 0.0.
            /// </summary>
            public float Speed { get; set; } = 0.0f;
        }
    }
}