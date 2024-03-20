namespace ATV4_CJ3022251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, op, resultado;

            Console.WriteLine("digite o primeiro número.");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número.");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite 1 para adição");
            Console.WriteLine("digite 2 para subtração");
            Console.WriteLine("digite 3 para multiplicação");
            Console.WriteLine("digite 4 para divisão ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine(resultado);
                    break;
                case 4:
                    resultado = num1 / num2;
                    Console.WriteLine(resultado);
                    break;













            }
        }
    }
}
