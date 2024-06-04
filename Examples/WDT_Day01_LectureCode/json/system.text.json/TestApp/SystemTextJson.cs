using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//add
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestApp
{
    class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
    }
    class SystemTextJson
    {
        //create JSON
        static void Main(string[] args)
        {
            var w = new WeatherForecast() { Date = DateTime.Now, TemperatureC = 30, Summary = "Hot" };
            //print JSON as a string
            string jsonstring = JsonSerializer.Serialize<WeatherForecast>(w);
            Console.WriteLine(jsonstring);
            Console.WriteLine("*******************");
            //convert to a file ie serialize
            string fileName = "weather.json";
            File.WriteAllText(fileName, jsonstring);
            //deserialize ie read from a file

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var jsonString = File.ReadAllText("weather.json");
            var jsonModel = JsonSerializer.Deserialize<WeatherForecast>(jsonString,options);
            var modelJson = JsonSerializer.Serialize(jsonModel, options);
            Console.WriteLine(modelJson);
        }
    }
}
