namespace Revisoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            op1();
        }
        static void op1()
        {

            int op;
            //do
            {
                Console.Clear();
                Console.WriteLine("1 - soma");
                Console.WriteLine("2 - subtraçao");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        soma();
                        break;

                    case 2:
                        subtracao();
                        break;
                    case 3:
                        multiplicacao();
                        break;
                    case 4:
                        divisao();
                        break;
                    default: op1(); break;
                }

                //} while (op != 0);

                void soma()
                {
                    Console.Clear();
                    Console.WriteLine("Insira o primeiro valor:");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o segundo valor: ");
                    float v2 = float.Parse(Console.ReadLine());

                    float resultado = v1 + v2;

                    Console.WriteLine("O resultado da soma de v1 e v2: " + resultado);
                    //Console.WriteLine($"O resultado da soma de v1 e v2: {resultado}");
                    //Console.WriteLine("O resultaod da soma de v1 e v2: " +(v1+v2));
                    Console.ReadKey();
                    op1();

                }
                void subtracao()
                {
                    Console.Clear();
                    Console.WriteLine("Insira o primeiro valor");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o segundo valor");
                    float v2 = float.Parse(Console.ReadLine());

                    float resultado = v1 - v2;

                    Console.WriteLine("O resultado dessa subtração: " + resultado);
                    Console.ReadKey();
                    op1();
                }

                void multiplicacao()
                {
                    Console.Clear();
                    Console.WriteLine("Insira primeiro valor: ");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o segundo valor: ");
                    float v2 = float.Parse(Console.ReadLine());

                    float resultado = v1 * v2;
                    Console.WriteLine("Resultado dessa multiplicaçao: " + resultado);
                    Console.ReadKey();
                    op1();
                }
                void divisao()
                {
                    Console.Clear();
                    Console.WriteLine("Insira o primeiro valor: ");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o segundo valor: ");
                    float v2 = float.Parse(Console.ReadLine());

                    float resultado = v1 / v2;
                    Console.WriteLine("O resultado dessa divisão: " + resultado);
                    Console.ReadKey();
                    op1();
                }
            }
        }
    }
}