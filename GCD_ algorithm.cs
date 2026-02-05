using System;

class Program
{
    static long Gcd(long a, long b)
    {
        if (b == 0)
            return a;

        return Gcd(b, a % b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("محاسبه بزرگترین مقسوم علیه مشترک");

        Console.Write("عدد اول: ");
        string s1 = Console.ReadLine();

        Console.Write("عدد دوم: ");
        string s2 = Console.ReadLine();

        // بررسی ورودی
        if (!long.TryParse(s1, out long x) || !long.TryParse(s2, out long y))
        {
            Console.WriteLine("ورودی نامعتبر است");
            return;
        }

        x = Math.Abs(x);
        y = Math.Abs(y);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("GCD تعریف نشده است");
            return;
        }

        long result = Gcd(x, y);

        Console.WriteLine($"GCD({x}, {y}) = {result}");
    }
}
