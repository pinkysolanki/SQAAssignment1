using System;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            Console.ReadKey();
        }

        public void Run()
        {

            String sside1, sside2, sside3;
            int side1 = 0, side2 = 0, side3 = 0;
            string soption = string.Empty;
            int option = 0;
            bool boolIterate = false;

            do
            {
                Console.WriteLine("1] Enter 1 to form a triangle. ");
                Console.WriteLine("2] Enter 2 for Exit");
                Console.Write("Input 1 or 2 to continue: ");
                soption = Console.ReadLine();

                if ((!int.TryParse(soption, out option)) || (option <= 0) || (option > 2))
                {
                    Console.WriteLine("Please input valid value");
                    boolIterate = true;
                }
                if (option == 2)
                {
                    break;
                }

                if (!boolIterate)
                {
                    bool IsSide1Valid = false,IsSide2Valid=false,IsSide3Valid=false;
                    do
                    {
                        Console.Write("Side 1: ");
                        sside1 = Console.ReadLine();
                        int.TryParse(sside1, out side1);
                    } while (side1 <= 0 && !IsSide1Valid);
                    do
                    {
                        Console.Write("Side 2: ");
                        sside2 = Console.ReadLine();
                        int.TryParse(sside2, out side2);
                    } while (side2 <= 0 && !IsSide2Valid);
                    do
                    {
                        Console.Write("Side 3: ");
                        sside3 = Console.ReadLine();
                        int.TryParse(sside3, out side3);
                    } while (side3 <= 0 && !IsSide3Valid);

                    Console.WriteLine(TriangleSolver.TriangleAnalyze(side1, side2, side3));
                    boolIterate = true;
                }
            } while (boolIterate);
        }

    }
}
