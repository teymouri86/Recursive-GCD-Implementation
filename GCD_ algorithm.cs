using System;

class Program
{
    // متد بازگشتی برای محاسبه‌ی GCD با الگوریتم اقلیدس
    // ورودی‌ها به صورت قدر مطلق درآمده‌اند تا با اعداد منفی هم کار کند.
    static long Gcd(long a, long b)
    {
        // پایهٔ بازگشت
        if (b == 0) return a;
        // گام بازگشتی
        return Gcd(b, a % b);
    }

    static void Main()
    {
        Console.WriteLine("محاسبهٔ بزرگ‌ترین مقسوم‌علیهٔ مشترک (GCD) دو عدد - الگوریتم بازگشتی");
        Console.Write("عدد اول را وارد کنید: ");
        string s1 = Console.ReadLine();
        Console.Write("عدد دوم را وارد کنید: ");
        string s2 = Console.ReadLine();

        if (!long.TryParse(s1, out long x) || !long.TryParse(s2, out long y))
        {
            Console.WriteLine("ورودی نامعتبر است. لطفاً اعداد صحیح وارد کنید.");
            return;
        }

        // تبدیل به قدر مطلق تا با ورودی منفی نیز درست کار کند
        x = Math.Abs(x);
        y = Math.Abs(y);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("بزرگ‌ترین مقسوم‌علیهٔ مشترک تعریف نشده (هر دو ورودی صفر هستند).");
            return;
        }

        long a = Math.Max(x, y); // برای خوانایی می‌توانیم بزرگ‌تر را در a قرار دهیم
        long b = Math.Min(x, y);

        long result = Gcd(a, b);
        Console.WriteLine($"GCD({x}, {y}) = {result}");
    }
}
