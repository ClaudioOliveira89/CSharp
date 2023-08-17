namespace EstruturaSwitch
{
    class Switch
    {
        static void Main()
        {
            Console.WriteLine("Qual a nota você da para o menu:? 0, 5 ou 10");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Comida muito ruim!.");
                break;
                case 5:
                    Console.WriteLine("Comida razoável.");
                break;
                case 10:
                    Console.WriteLine("Comidade muito boa!!.");
                break;
                default:
                    Console.WriteLine("Nota inexistente!");
                break;
            }

        }
    }
}