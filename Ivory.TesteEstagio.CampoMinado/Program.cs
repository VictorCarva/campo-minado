using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            // Parametros para marcação do tabuleiro.
            int recebeColuna, recebeLinha;

            do
            {
                Console.WriteLine("\nDigite o Valor da posição ");

                Console.Write("Linha: ");
                recebeLinha = int.Parse(Console.ReadLine());

                Console.Write("\nColuna: ");
                recebeColuna = int.Parse(Console.ReadLine());

                Console.Clear();

                campoMinado.Abrir(recebeLinha, recebeColuna);

                //Condicional para informar o andamento do jogo
                if (campoMinado.JogoStatus == 0)
                {
                    Console.WriteLine("Jogo em Andamento\n=========");
                }
                else
                {
                    Console.WriteLine("Jogo Finalizado\n=========");
                }

                Console.WriteLine(campoMinado.Tabuleiro);

            } 
            while (campoMinado.JogoStatus == 0);

            if (campoMinado.JogoStatus == 2)
            {
                Console.WriteLine("\nGameOver");
            }
            else
            {
                Console.WriteLine("\nVitoria");
            }
        }
    }
}
