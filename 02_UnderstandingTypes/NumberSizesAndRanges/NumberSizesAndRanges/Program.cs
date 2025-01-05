using System;

namespace NumberSizesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "Type", "Bytes", "Min Value", "Max Value");
            Console.WriteLine(new string('-', 60));

            PrintTypeInfo("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            PrintTypeInfo("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            PrintTypeInfo("short", sizeof(short), short.MinValue, short.MaxValue);
            PrintTypeInfo("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            PrintTypeInfo("int", sizeof(int), int.MinValue, int.MaxValue);
            PrintTypeInfo("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            PrintTypeInfo("long", sizeof(long), long.MinValue, long.MaxValue);
            PrintTypeInfo("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            PrintTypeInfo("float", sizeof(float), float.MinValue, float.MaxValue);
            PrintTypeInfo("double", sizeof(double), double.MinValue, double.MaxValue);
            PrintTypeInfo("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }

        static void PrintTypeInfo<T>(string typeName, int size, T min, T max)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", typeName, size, min, max);
        }
    }
}