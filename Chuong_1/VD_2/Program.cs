
namespace Quynh_ngu
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            float f = float.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double f_t = Math.Round(f, 2);
            double d_t = Math.Round(d, 9);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(c);
            Console.WriteLine(f_t);
            Console.WriteLine(d_t);
        }
    }
}