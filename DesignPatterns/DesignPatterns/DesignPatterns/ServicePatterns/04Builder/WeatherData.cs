namespace DesignPatterns.ServicePatterns._04Builder
{
    public class WeatherData
    {
        public DateTime Date { get; private set; }
        public int TemperatureC { get; private set; }
        public string Summary { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private WeatherData() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public class Builder
        {
            private DateTime _date = DateTime.Now;
            private int _temperatureC = 20;
            private string _summary = "Sunny";

            public Builder WithDate(DateTime date)
            {
                _date = date;
                return this;
            }

            public Builder WithTemperature(int temperatureC)
            {
                _temperatureC = temperatureC;
                return this;
            }

            public Builder WithSummary(string summary)
            {
                _summary = summary;
                return this;
            }

            public WeatherData Build()
            {
                return new WeatherData
                {
                    Date = _date,
                    TemperatureC = _temperatureC,
                    Summary = _summary
                };
            }
        }
    }

}
