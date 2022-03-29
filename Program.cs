using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex: 1,63");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é: {0}", imc);

            if (imc < 17.0)
            {
                Console.WriteLine("Você está muito abaixo do peso");
            }
            else if (imc >= 17 && imc < 18.50)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc >= 18.50 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obesidade I");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Obesidade II (severa)");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade III (mórbida)");
            }
        }
    }
}
