using System;
using System.Globalization;

namespace Course
{

    public class Triangulo //defindo a classe publica triangulo
    { 
        public double A { get; set; } //criando variaveis publicas para essa classe
        public double B { get; set; } //criando variaveis publicas para essa classe
        public double C { get; set; } //criando variaveis publicas para essa classe

        public double CalcularArea() //definindo uma função publica da classe triangulo
        {
            double p = (A + B + C)/2.0; //calculo
            double area = Math.Sqrt(p *(p - A) * (p - B) * (p - C)); //calculo com raiz quadrada
            return area; //retorne a area
        }
    }

    public class Program //abrindo a classe principal
    {
        public static void Main(string[] args) //abrindo o bloco principal
        {
            Triangulo x = LerTriangulo("X"); //criando um objeto da classe triangulo
            Triangulo y = LerTriangulo("Y"); //criando um objeto da classe triangulo

            double areax = x.CalcularArea(); //definindo uma variavel e chamando uma função da outra classe
            double areay = y.CalcularArea(); //definindo uma variavel e chamando uma função da outra classe

            Console.WriteLine("Area de X: " + areax.ToString("F4", CultureInfo.InvariantCulture)); //mostrando na interface do usuario
            Console.WriteLine("Area de Y: " + areay.ToString("F4", CultureInfo.InvariantCulture)); //mostrando na interface do usuario

            if (areax > areay)// se a area de x for maior
            {
                Console.WriteLine("Area de X é maior "); //mostre para o usuario
            }
            else //se não
            {
                Console.WriteLine("Area de Y é maior "); //mostre para o usuario
            }
        }
        public static Triangulo LerTriangulo(string nomeTriangulo) //Defindo outra função da classe triangulo
        { 
            Triangulo tri = new Triangulo(); //defindo um objeto para chamar as variaveis publicas
            Console.WriteLine("Entre com os valores do triangulo " + nomeTriangulo); //mostre na tela do usario
            tri.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pedindo para o usuario inputar o valor
            tri.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pedindo para o usuario inputar o valor
            tri.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pedindo para o usuario inputar o valor

            return tri; //retorne o objeto
        }
    }
}
