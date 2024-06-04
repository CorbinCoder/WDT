using System;
using System.IO;
//Newtonsoft.json
//official page: https://www.newtonsoft.com/json
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestApp
{
    class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //serialize into JSON
            Movie movie = new Movie
            {
                Name = "Starwars the rise of skywalker",
                Year = 2019
            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText("movie.json", JsonConvert.SerializeObject(movie));
            Console.WriteLine("File written");

            //// serialize JSON directly to a file
            //using (StreamWriter file = File.CreateText(@"c:\movie.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, movie);
            //}

            Console.WriteLine("************");
            //deserialize
            var myJsonString = File.ReadAllText("movie.json");
            var myJObject = JObject.Parse(myJsonString);
            Console.WriteLine(myJObject.ToString());
        }
    }
}
