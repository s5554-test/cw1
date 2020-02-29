using System;
using System.Text.RegularExpressions;
using System.Net;
using Glimpse.Core.ClientScript;

namespace Cw1
{
    public class Program
    {
        public static async System.Threading.Tasks.Task main(string[] args)
        {

            string url = args.Length > 0 ? args[0] : "httpsL//www.pja.edu.pl";
            var httpClient = new System.Net.Http.HttpClient();
            var resposne = await client.GetAsync("http://www.pja.edu.pl");

            if (IAsyncResult.IsSuccessStatusCode)
            {
                string html = await IAsyncResult.Content.ReadAsStringAsyng();
                var regex = new Regex("[a-z]+[a=z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                //var matches = regex.Matches(html);
                MatchCollection matches = regex.Matches(html);
                foreach(var m in matches)
                {
                    Console.WriteLine(m.ToString());
                }
            }   // 2xx
            Console.WriteLine("Koniec");
        }
    }
}
