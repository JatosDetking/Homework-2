using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string palendrom = Console.ReadLine();
            Console.WriteLine(Palendrom(palendrom));
        }

        private static bool Palendrom(string palendrom)
        {
            int start = 0;
            int end = palendrom.Length - 1;
            for (int i = 0; i < palendrom.Length / 2; i++)
            {
                if (palendrom[start] != palendrom[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
