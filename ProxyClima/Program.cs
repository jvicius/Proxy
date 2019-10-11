using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyClima.Services;

namespace ProxyClima
{
    class Program
    {
        static void Main(string[] args)
        {
            IProxy proxy = new Proxy();
            var response = proxy.weather("rome");
            Console.WriteLine($"Ciudad:{response.name}");
            Console.WriteLine($"Temperatura:{response.main.temp}");
            Console.WriteLine($"Min:{response.main.temp_min}");
            Console.WriteLine($"Max:{response.main.temp_max}");
            
            var response2 = proxy.forecast("rome");
            Console.WriteLine();
            int i = 0;
            foreach (var item in response2.list.Take(5))
            {
                i++;
                Console.WriteLine($"{DateTime.Now.AddDays(i).DayOfWeek}");
                Console.WriteLine($"Temperatura:{item.main.temp}");
                Console.WriteLine($"Min:{item.main.temp_min}");
                Console.WriteLine($"Max:{item.main.temp_max}");
            }

            Console.ReadKey();
        }
    }
}
