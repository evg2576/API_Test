using System;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace API_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.binance.com/api/v3/exchangeInfo?symbol=BNBBTC";
            APIHandler.Execute(url);
            ExchangeInfoResponse exchangeInfoResponse = JsonConvert.DeserializeObject<ExchangeInfoResponse>(APIHandler.Response);
            foreach (var symbol in exchangeInfoResponse.symbols)
            {
                Console.WriteLine($"{exchangeInfoResponse.TimeZone} \n{exchangeInfoResponse.ServerTime} \n{symbol.Symbol}");
                foreach (var filter in symbol.filters)
                {
                    Console.WriteLine($"\n{filter.FilterType}");
                }
            }
            Console.ReadKey();
        }
    }
}
