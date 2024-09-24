using System.Data;
using System.Net.NetworkInformation;

namespace CSharpInClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Bai 3
            //ExerciseAboutCats();

            // Bai 4
            //ExerciseAboutBooks();

            // Bai 5
            //ExerciseAboutOrganizations();

            // Bai 6
            //ExerciseAboutTriangle();
        }

        // Class Bai 3
        public static void ExerciseAboutCats()
        {
            List<Cat> cats = new List<Cat>();
            while (true)
            {
                Cat obj = new Cat();
                obj.Read();
                cats.Add(obj);

                Console.Write("--- Tiep tuc nhap nua khong [Y/N]? ");
                char ans = char.Parse(Console.ReadLine());
                if (ans == 'y' || ans == 'Y')
                {
                    Console.WriteLine();
                }
                else if (ans == 'n' || ans == 'N')
                {
                    Console.WriteLine();
                    break;
                }
            }

            foreach (var item in cats)
            {
                item.WriteDetails();
            }

            Console.WriteLine($"\nCo {new Cat().CountTheNumberOfCats(cats)} be meo trong danh sach.");
        }

        // Class Bai 4
        public static void ExerciseAboutBooks()
        {
            Book book = new Book();
            book.Read();
            book.WriteDetails();
        }

        // Class Bai 5
        public static void ExerciseAboutOrganizations()
        {
            Organization organization = new Organization();
            bool isValid = organization.Read();
            if (isValid)
            {
                organization.WriteDetails();
            }
            else
            {
                Console.WriteLine("~~~ Input Error ~~~");
            }
        }

        // Class Bai 6
        public static void ExerciseAboutTriangle()
        {
            Triangle triangle = new Triangle();
            while (true)
            {
                PrintMenu();
                Console.Write("\nYour choice: ");
                string choice = Console.ReadLine();
                bool isExit = false;
                switch (choice)
                {
                    case "1":
                        triangle.Read();
                        Thread.Sleep(1500);
                        break;
                    case "2":
                        if (!triangle.CheckTriangle())
                        {
                            Console.WriteLine("\n-- Invalid, Please choice option 1 again --");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine($"Permeter of Triangle: {triangle.CalculatePerimeter()}.");
                            Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}.");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "3":
                        triangle.WriteDetails();
                        Thread.Sleep(3000);
                        break;
                    case "0":
                        isExit = true;
                        break;
                }
                if (isExit) break;
                Console.Clear();
            }
        }
        public static void PrintMenu()
        {
            string str = "MENU";
            Console.WriteLine(str.PadLeft((50 - str.Length) / 2 + str.Length, '-').PadRight(50, '-'));
            Console.WriteLine(" 1 - Input a, b, c is length of triangle.");
            Console.WriteLine(" 2 - Caculate Perimeter and Area of triangle.");
            Console.WriteLine(" 3 - Print a, b, c.");
            Console.WriteLine(" 0 - Exit program.");
            Console.WriteLine(new string('-', 50));
        }
    }
}