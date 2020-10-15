using System;

namespace FuncaoSegundoGrau.app
{
    class Program
    {
        static void Main(string[] args)
        {            
            double a, b, c;

            Console.WriteLine("\t|| Função do segundo grau ||\n");

            Console.Write("Insira o valor de A: ");
            Double.TryParse(Console.ReadLine(), out a);

            Console.Write("Insira o valor de B: ");
            Double.TryParse(Console.ReadLine(), out b);

            Console.Write("Insira o valor de C: ");
            Double.TryParse(Console.ReadLine(), out c);            

            delta(a, b, c);
            funcao2(a, b, c);
        }

        static void delta(double a1, double b1, double c1)
        {
            double delta = Math.Sqrt(Math.Pow(b1, 2) - (4 * a1 * c1));
            string valorX1;
            double x1 = (((b1 * (-1)) + delta) / (2 * a1));

            Console.WriteLine("Delta é igual a: " + (Math.Pow(b1, 2) - (4 * a1 * c1)));

            if (delta > 0)
            {
                valorX1 = String.Format("\nx1 é igual a: " + x1);
            }
            else if (delta == 0)
            {
                valorX1 = String.Format("Valor descriminante igual a 0\n\tentão x é igual a: " + x1);
            }
            else
            {
                valorX1 = "Equação sem raízes reais, descriminante menor que 0.";
            }

            Console.WriteLine(valorX1);
        }

        static void funcao2(double a2, double b2, double c2)
        {
            double delta = Math.Sqrt(Math.Pow(b2, 2) - (4 * a2 * c2));

            if (delta > 0)
            {
                double x2 = (((b2 * (-1)) - delta) / 2 * a2);
                Console.WriteLine("x2 é igual a: " + x2 + "\n\n");
            }
        }
    }
}
