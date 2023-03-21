/*
 * Padrões Diamante Superior
        A quantidade de espaços na primeira linha é a diferença entre a letra A e a letra Informada
        A quantidade de espaços em branco é subtraído 1 a cada linha
        A quantidade de espaços é adicionado 2 a cada linha
        A ordem das letras seguem uma sequencia
 */

/*
 * Padrões Diamante Superior
        A quantidade de espaços na primeira linha é 1
        A quantidade de espaços da margem é adicionado 1 a cada linha
        A quantidade de espaços entre as lestras é subtraido 2 a cada linha
        A ordem das letras seguem uma sequencia decrescente
 */
namespace DesenhoDiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letraInformada = 'G';

            char letra = 'A';

            int espacosDaMargem = letraInformada - letra;

            int quantidadeLinhas = letraInformada - letra;

            int espacosEntreAsLetras = -1;            

            //desenhou a parte do superior do diamante

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)                
                    Console.Write(" ");                

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)                
                    Console.Write(" ");                

                if (letra != 'A')
                    Console.Write(letra); //letra final

                letra++;
                espacosDaMargem--;
                espacosEntreAsLetras += 2;

                Console.WriteLine();
            }

            //desenho da parte do meio
            Console.Write(letraInformada);

            for (int i = 0; i < espacosEntreAsLetras; i++)            
                Console.Write(" ");            

            Console.Write(letraInformada);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;
            Console.WriteLine();

            //desenho da parte inferior do diamante

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)                
                    Console.Write(" ");                

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)                
                    Console.Write(" ");                

                if (letra != 'A')
                    Console.Write(letra); //letra final

                letra--;
                espacosDaMargem++;
                espacosEntreAsLetras -= 2;

                Console.WriteLine();
            }

            Console.ReadLine(); 
        }
    }
}