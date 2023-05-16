using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using RestSharp;
using System.Security.Cryptography.X509Certificates;
using System;

namespace KanyeAndRon
{
    public class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine($"Ron Swanson: {quote.Ron()}");
            }
        }
    }
}