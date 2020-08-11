using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWestUI
{
    class Program
    {
        static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye says: \"{kanyeQuote}.\"");
        }

        static void SwansonQuote()
        {
            var client = new HttpClient();
            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var swansonResponse = client.GetStringAsync(swansonURL).Result;
            var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"Ron responds: {swansonQuote}");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                KanyeQuote();
                SwansonQuote();
            }

        }
    }
}
