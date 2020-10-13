using System;
using System.Reflection;

namespace Aplikacja5
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawRectangle(4, 6);
        }

        static void DrawRectangle(int width, int height)
        {
            if(width < 2 || height < 2)
            {
                return;
            }
            string body = prepareString(' ', '9', width);
            string top = prepareString('9', ' ', width);

            Console.WriteLine(top);
            for(int i=0; i< height; i++)
            {
                Console.WriteLine(body);
            }
            Console.WriteLine(top);
        }

        static string prepareString(char inner, char outsite, int length)
        {
            string body = "";
            body += outsite;
            for(int i = 0; i < length; i++)
            {
                body += inner;
            }
            body += outsite;
            return body;
        }
    }
}
