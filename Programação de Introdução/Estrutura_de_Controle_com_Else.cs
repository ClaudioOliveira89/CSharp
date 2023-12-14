    namespace EstruturadeControleElse
{
    class Program
    {
        static void Main()
        {
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if (n1 < n2)
            {
                Console.WriteLine("Condição 1 ´satisfeita !!");
                Console.WriteLine("Resultado da soma ´{0}", n1 + n2);
            }
            if (n3 < n2)
            {
                Console.WriteLine(n3 + n2);
            }
            else
            {
                Console.WriteLine("Condição 2 não é satisfeita!!.");
            }

        }
    }
}
