using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Olá, seja bem vindo ao projeto integrado criado por Ronaldo Rodrigues.");

            Console.WriteLine();

            string sn = "S";
            while (sn.ToUpper().Equals("S"))
            {
                Console.WriteLine("     Escolha o Programa que Deseja Executar: ");

                Console.WriteLine();

                int escolha = 0;

                Console.WriteLine("          Digite uma das opções listados abaixo: \n \n               1 - Verificar qual é o Maior Valor com Variáveis: \n               2 - Tabuada com Variáveis: \n               3 - Gráfico de Barras com Variáveis: \n               4 - Busca Nomes com Vetor: \n               5 - Gasolina OU Etanol com Variáveis: \n");

                escolha = int.Parse(Console.ReadLine());

                string nome;
                if (escolha > 5)
                {
                    Console.WriteLine($"     Você escolheu uma Opção Invalida!");
                }
                else if (escolha < 1)
                {
                    Console.WriteLine($"     Você escolheu uma Opção Invalida!");
                }
                else if (escolha == 1)
                {
                    nome = "Maior Número";
                    Console.WriteLine($"     Você escolheu a opção: {escolha} - {nome}!");
                }
                else if (escolha == 2)
                {
                    nome = "Tabuada";
                    Console.WriteLine($"     Você escolheu a opção: {escolha} - {nome}!");
                }
                else if (escolha == 3)
                {
                    nome = "Gráfico de Barras";
                    Console.WriteLine($"     Você escolheu a opção: {escolha} - {nome}!");
                }
                else if (escolha == 4)
                {
                    nome = "Busca Nomes";
                    Console.WriteLine($"     Você escolheu a opção: {escolha} - {nome}!");
                }
                else if (escolha == 5)
                {
                    nome = "Gasolina OU Etanol";
                    Console.WriteLine($"     Você escolheu a opção: {escolha} - {nome}!");
                }

                Console.WriteLine();

                if (escolha == 1)
                {
                    Maior(0
                        ); // Chama a função Maior
                }
                else if (escolha == 2)
                {
                    Tabuada(0
                        ); // Chama a função Tabuada
                }
                else if (escolha == 3)
                {
                    GraficoBarras(0
                        ); // Chama a função GraficoBarras
                }
                else if (escolha == 4)
                {
                    Nomes(0
                        ); // Chama a função Nomes
                }
                else if (escolha == 5)
                {
                    GasolinaEtanol(0
                        ); // Chama a função Gasolina OU Etanol
                }

                Console.Write("     Deseja Acessar Outro Programa (S/N): ");
                sn = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static int Maior(int A1)
        {
            //Esse programa foi desenvolvido com Variáveis e Função:
            Console.WriteLine("     Digite até cinco números inteiros que deseja comparar: \n");

            int retornoA = 0;
            string sn = "S";
            while (sn.ToUpper().Equals("S"))
            {
                Console.Write("          Digite o 1º Número: ");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("          Digite o 2º Número: ");
                int v2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("          Digite o 3º Número: ");
                int v3 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("          Digite o 4º Número: ");
                int v4 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("          Digite o 5º Número: ");
                int v5 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                retornoA = MaiorCalculo(v1, v2, v3, v4, v5);

                Console.Write("     Deseja uma Nova Comparação (S/N): ");
                sn = Console.ReadLine();
                Console.WriteLine();
            }
            return retornoA;
        }
        public static int MaiorCalculo(int n1, int n2, int n3, int n4, int n5)
        {

            int maior = 0;

            if ((n1 > n2) && (n1 > n3) && (n1 > n4) && (n1 > n5))
            {
                maior = n1;
                Console.WriteLine($"          O 1º Número é Maior = {maior}\n");
            }
            else if ((n2 > n1) && (n2 > n3) && (n2 > n4) && (n2 > n5))
            {
                maior = n2;
                Console.WriteLine($"          O 2º Número é Maior = {maior}\n");
            }
            else if ((n3 > n1) && (n3 > n2) && (n3 > n4) && (n3 > n5))
            {
                maior = n3;
                Console.WriteLine($"          O 3º Número é Maior = {maior}\n");
            }
            else if ((n4 > n1) && (n4 > n2) && (n4 > n3) && (n4 > n5))
            {
                maior = n4;
                Console.WriteLine($"          O 4º Número é Maior = {maior}\n");
            }
            else if ((n5 > n1) && (n5 > n2) && (n5 > n3) && (n5 > n4))
            {
                maior = n5;
                Console.WriteLine($"          O 5º Número é Maior = {maior}\n");
            }
            else
            {
                n1 = n2 = n3 = n4 = n5;
                Console.WriteLine($"          Existe Números Maiores Iguais!\n");
            }
            return maior;

        }

        public static int Tabuada(int B1)
        {
            //Esse programa foi desenvolvido com Variáveis e Função:
            Console.WriteLine("          Digite o número que deseja a tabuada: ");
            Console.WriteLine();

            string sn = "S";
            int retornoB = 0;
            while (sn.ToUpper().Equals("S"))
            {
                Console.Write("               Informe um Número Inteiro: ");

                int N = int.Parse(Console.ReadLine());
                Console.WriteLine($"\n               Você escolheu o número: {N}");
                Console.WriteLine();
                int R = 0;
                for (int i = 1; i <= 09; i++)
                {
                    R = N * i;
                    Console.WriteLine($"                    {N}         x         {i}         = {R}");
                }
                for (int i = 10; i <= 10; i++)
                {
                    R = N * i;
                    Console.WriteLine($"                    {N}         x         {i}        = {R}");
                }

                Console.Write("\n     Deseja Nova Tabuada (S/N): ");
                sn = Console.ReadLine();
                Console.WriteLine();

            }
            return retornoB;
        }

        public static int GraficoBarras(int C1)
        {
            //Esse programa foi desenvolvido com Variáveis e Função:
            string sn = "S";
            int retornoC = 0;
            while (sn.ToUpper().Equals("S"))
            {
                Console.Write("     Digite o 1º Número do Gráfico: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("     Digite o 2º Número do Gráfico: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.Write("     Digite o 3º Número do Gráfico: ");
                int n3 = int.Parse(Console.ReadLine());
                Console.Write("     Digite o 4º Número do Gráfico: ");
                int n4 = int.Parse(Console.ReadLine());
                Console.Write("     Digite o 5º Número do Gráfico: ");
                int n5 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Grafico(n1, n2, n3, n4, n5);

                Console.WriteLine();

                Console.Write("     Deseja um Novo Gráfico (S/N): ");
                sn = Console.ReadLine();
            }
            return retornoC;
        }

        static void Grafico(int v1, int v2, int v3, int v4, int v5)
        {
            ImprimeGrafico(v1);
            ImprimeGrafico(v2);
            ImprimeGrafico(v3);
            ImprimeGrafico(v4);
            ImprimeGrafico(v5);
        }

        static void ImprimeGrafico(int m)
        {
            //Console.WriteLine();
            for (int i = 1; i <= m; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine(" " + m);
        }

        public static string Nomes(int D1)
        {
            //Esse programa foi desenvolvido com Vetor e Função:
                        
            string retornoD = "";
            string sn = "S";
            while (sn.ToUpper().Equals("S"))
            {
                string[] nomes = { "Ronaldo", "Vania", "Iris", "Roney", "Maria", "João", "Pedro", "Alice", "Bob", "Carol", "David", "Eve" };

                //Console.WriteLine();

                Console.Write("               Informe o Nome que deseja encontrar: ");

                string nomeBuscado = Console.ReadLine();

                Console.WriteLine();

                bool encontrado = false;

                foreach (string nome in nomes)
                {
                    if (nome == nomeBuscado)
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado)
                {
                    Console.Write("               Nome " + nomeBuscado + " encontrado.\n");
                }
                else
                {
                    Console.Write("               Nome " + nomeBuscado + " não encontrado.\n");
                }

                Console.Write("\n     Deseja Nova Busca (S/N): ");
                sn = Console.ReadLine();
                Console.WriteLine();
            }
            return retornoD;
        }

        public static string GasolinaEtanol(int E1)
        {
            //Esse programa foi desenvolvido com Variáveis e Função:
            
            string sn = "S";
            string retornoE = "";
            while (sn.ToUpper().Equals("S"))
            {
                Console.Write("          Digite o valor da gasolina: ");
                float gasolina = float.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("          Digite o valor do etanol: ");
                float etanol = float.Parse(Console.ReadLine());

                Console.WriteLine();

                float maisVantajoso = etanol / gasolina;

                if (maisVantajoso > 0.7)
                {
                    Console.WriteLine("\n               Vale mais a pena abastecer com gasolina!");
                    Console.WriteLine();
                }
                else if (maisVantajoso < 0.7)
                {
                    Console.WriteLine("\n               Vale mais a pena abastecer com etanol!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\n               Não há nenhuma diferença entre abastecer com o etanol ou com a gasolina!");
                }

                Console.Write("\n     Deseja uma Nova Comparação (S/N): ");
                sn = Console.ReadLine();
                Console.WriteLine();
            }
            return retornoE;
        }
    }
}
