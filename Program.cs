using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Chon mot trong cac lua chon sau: ");
        Console.WriteLine("1. In hinh chu nhat");
        Console.WriteLine("2. In hinh tam giac vuong");
        Console.WriteLine("3. In hinh tam giac can");
        Console.WriteLine("4. Thoat khoi chuong trinh");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else if (number == 2)
        {
            for (int i = 1; i <= 5; i++)
            {
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine(" ");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(("*"));
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j > 5-i)

                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(" ");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j >=i)

                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
        else if (number == 3)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else 
        {
            Console.WriteLine("Thoat khoi chuong trinh.");
        }
    }
}