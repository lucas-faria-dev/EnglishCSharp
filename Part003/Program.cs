using System;

class Program
{
    static void Main(string[] args)
    {
        bool b = true;
        int i = 0;
        Console.WriteLine("You can use Byte [byte] as: the minimum {0} until the maximum {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("You can use SByte [sbyte] as: the minimum {0} until the maximum {1}", sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("You can use Int16 [short] as: the minimum {0} until the maximum {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("You can use UInt16 [ushort] as: the minimum {0} until the maximum {1}", ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("You can use Int32 [int] as: the minimum {0} until the maximum {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("You can use UInt32 [uint] as: the minimum {0} until the maximum {1}", uint.MinValue, uint.MaxValue);
        Console.WriteLine("You can use Int64 [long] as: the minimum {0} until the maximum {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("You can use UInt64 [ulong] as: the minimum {0} until the maximum {1}", ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("You can use Single [float] as: the minimum {0} until the maximum {1}", float.MinValue, float.MaxValue);
        Console.WriteLine("You can use Double [double] as: the minimum {0} until the maximum {1}", decimal.MinValue, decimal.MaxValue);
        Console.WriteLine("You can use Char [Char] as: the minimum {0} until the maximum {1}", char.MinValue, char.MaxValue);
        Console.WriteLine("You can use Boolean [bool] as: the minimum {0} until the maximum {1}", "True", "False");
        Console.WriteLine("You can use DateTime as: the minimum {0} until the maximum {1}", DateTime.MinValue, DateTime.MaxValue);
       


    }
}
