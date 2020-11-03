using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte valByte = 16;
            short valShort = 16;
            int valInt = 16;
            long valLong = 16;
            ulong valLLong = 16;
            //Konwersja niejawna byte -> short
            valShort = valByte;
            //Konwersja niejawna short -> int
            valInt = valShort;
            float fl = 2.2f;
            //Konwersja niejawna float -> double
            double flD = fl;
            UInt16 val16 = 1;
            //Konwersja niejawna UInt16 -> Uint64
            UInt64 val64 = val16;

            //Konwersje jawne
            uint uintVal = (uint)valInt;
            float floatVal = (float)valInt;
            byte byteVal = (byte)valLong;
            double doubleVal = (double)valLLong;
        }
    }
}
