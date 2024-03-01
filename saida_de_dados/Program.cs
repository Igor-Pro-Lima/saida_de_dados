using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace saida_de_dados {
    internal class Program {
        static void Main(string[] args) {

            //Podemos declarar também a váriavel e CultureInfo e utilizar apenas o nome declarado na variável com a biblioteca
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine();

            //Alteração de vírgula para ponto com exemplo em double usando a biblioteca Globalization
            double a, b, salario;
            a = 1.234;
            b = 2.3456;
            Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(b.ToString("F3", CI));

            Console.WriteLine();

            int x, y, idade;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine();

            string nome;
            char sexo;

            idade = 25;
            salario = 4000.50;
            nome = "Igor";
            sexo = 'M';

            Console.WriteLine("O " + nome + " é do sexo " + sexo + ", tem " + idade + " anos de idade, e ganha " + salario.ToString("F2", CI));

            Console.WriteLine();

            //Exemplo em como imprimir na tela sem declarar a variável
            Console.WriteLine("__PROGRAMACAO___");
            Console.WriteLine("♥C#♥");
        }
    }
}
