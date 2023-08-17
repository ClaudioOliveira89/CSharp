namespace Conversão
{ 
    class program
    {
        static void Main()
        {
            Console.WriteLine("Digite qual é o número da sua casa:");
            String numeroCasa = Console.ReadLine();
            int numero = int.Parse(numeroCasa);
            Console.WriteLine("Numero da casa: {0}", numero);

            numero = Convert.ToInt32(numeroCasa);


            Console.WriteLine(numero);




        }


    }



}


