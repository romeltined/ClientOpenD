using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Default;
using HelloOpenData.Models;

namespace ClientOpenD
{
    class Program
    {
        static void Main(string[] args)
        {
            ListReader().Wait();
        }

        static async Task ListReader()
        {
            var serviceRoute = @"https://localhost:44398/odata";
            var context = new Container(new Uri(serviceRoute));

            IEnumerable<Reader> reader = await context.AllReaders().ExecuteAsync();
            
                

            foreach(var r in reader)
            {
                Console.WriteLine("{0}, {1}", r.UserName, r.IsReaderActive);
            }

        }

 
    }

}
