using SEARCHFIGHT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCHFIGHT
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a query to search....");
                args = Console.ReadLine()?.Split(' ');
            }

            Console.WriteLine("Executing Search Fight....");
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            await SearchFightKernel.ExecuteSearchFight(args.ToList());
            SearchFightKernel.Reports.ForEach(report => Console.WriteLine(report));
        }
    }
}
