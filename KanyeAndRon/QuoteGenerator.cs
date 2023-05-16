using System;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        private HttpClient client;

        public QuoteGenerator(HttpClient client)
        {
            this.client = client;
        }

        public string Kanye()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string Ron()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }
    }
}