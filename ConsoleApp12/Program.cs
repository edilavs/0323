using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitablarin sayini daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine($"{i + 1}ci Kitabi daxil edin:");
                for (int j = 0; j <= count; j++)
                {
                    if (Book[i].No != Book[j].No)
                    {
                        Console.WriteLine("ok");
                    }
                }

            }
            if (Product.Price > 0 && Product.No > 0 && Product.Count > 0)
            {
                Console.WriteLine("ok");
            }
            Console.WriteLine("Filterlemek isteyirsinizmi?y/n");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case y:
                    Console.WriteLine("1-Genre adina gore,2-Qiymet intervalina gore");
                    byte answer1 = Convert.ToInt32(Console.WriteLine());
                    switch (answer1)
                    {
                        case 1:
                            Console.WriteLine("Axtardiginiz janri daxil edin:");
                            string nesGenre = Console.ReadLine();
                            for (int i = 0; i <= count; i++)
                                if (Book[i].Genre == nesGenre)
                                    Console.WriteLine(Book[i]);
                            break;
                        case 2:
                            Console.WriteLine("Minprice daxil edin:");
                            double minPrice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Maxprice daxil edin:");
                            double maxPrice = Convert.ToDouble(Console.ReadLine());
                            if (books.Price >= minPrice && books.Price < max)
                            {
                                Console.WriteLine("uygundur");
                            }
                            break;
                    }
                    break;
                case n:
                    Console.WriteLine(book.info);
                    break;
                    default
                    Console.WriteLine("Duzgun cavab daxil edin:");
                    break;
            }
        }
}
