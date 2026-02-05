using System;

namespace GCDRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("محاسبه‌ی بزرگترین مقسوم‌علیه مشترک (GCD) با روش بازگشتی");
            Console.WriteLine("=====================================================");
            
            // دریافت اعداد از کاربر
            Console.Write("عدد اول را وارد کنید: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("عدد دوم را وارد کنید: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            // فراخوانی تابع بازگشتی
            int gcd = CalculateGCD(num1, num2);
            
            // نمایش نتیجه
            Console.WriteLine($"\nبزرگترین مقسوم‌علیه مشترک ({num1}, {num2}) = {gcd}");
            
            Console.ReadKey();
        }
        
        /// <summary>
        /// تابع بازگشتی برای محاسبه‌ی GCD با استفاده از الگوریتم اقلیدس
        /// </summary>
        /// <param name="a">عدد اول</param>
        /// <param name="b">عدد دوم</param>
        /// <returns>بزرگترین مقسوم‌علیه مشترک</returns>
        static int CalculateGCD(int a, int b)
        {
            // حالت پایه: اگر b برابر 0 باشد، a همان GCD است
            if (b == 0)
                return Math.Abs(a); // مقدار مطلق برای اعداد منفی
            
            // فراخوانی بازگشتی
            return CalculateGCD(b, a % b);
        }
    }
}
