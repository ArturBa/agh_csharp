using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static char[] vovels = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'y' };
        static void Main(string[] args)
        {
            while(true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine('\n');
                Program.displayType(c);
            }
        }

        static void displayType(char c)
        {
            if (Program.isVovel(c))
            {
                Console.WriteLine("Its a vovel");
            }
            else if (Program.isNmber(c))
            {
                Console.WriteLine("Its a number");
            } else
            {
                Console.WriteLine("Its another char");
            }

        }

        static Boolean isVovel(char c)
        {
            if (Program.vovels.Contains(c)) {
                return true;
            }
            return false;
        }

        static Boolean isNmber(char c)
        {
            return Char.IsDigit(c);
        }
    }
}
