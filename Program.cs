namespace Assignment_5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nRecursion: Print the first n natural numbers in reverse order:\n");
            Console.Write("----------------------------\n");
            Console.Write("How many numbers to print: ");
            int ctr = Convert.ToInt32(Console.ReadLine()); 

            PrintNatural(1, ctr);
            Console.Write("\n\n");
        }
        static void PrintNatural(int n, int c)
        {
            
            if (c < 1)
            {
                return;
            }
            Console.Write($"{c} "); 
                                      
            PrintNatural(n, c - 1);
        }

    }
}
