namespace Robo_Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX = 0;
            int posicaoY = 0;
            string localizacaoRobo = $"{posicaoX},{posicaoY}";
            char direcaoRobo = 'L';
            string instrucao = "mmmmmmMmmmm".ToUpper();

            for (int i = 0; i < instrucao.Length; i++)
            {
                char comando = instrucao[i];

                if (comando == 'D') direcaoRobo = VirarDireita(direcaoRobo);
                else if (comando == 'E') direcaoRobo = VirarEsquerda(direcaoRobo);
                else if (comando == 'M')
                {
                    int qtdMovimentos = 0;

                    while (i < instrucao.Length && instrucao[i] == 'M')
                    {
                        qtdMovimentos++;
                        i++;
                    }
                    i--;
                    (posicaoX, posicaoY) = MoverRobo(direcaoRobo, posicaoX, posicaoY, qtdMovimentos);
                }
                else
                {
                    Console.WriteLine($"Comando inválido: Utilize [D], para direita, [M], para mover, ou [E] para esquerda!");
                }
            }
            localizacaoRobo = $"{posicaoX},{posicaoY}";
            Console.WriteLine($"\nLocalização do robô:{localizacaoRobo},{direcaoRobo}");
            Console.ReadLine();
        }

        static char VirarDireita(char direcaoAtual)
        {
            if (direcaoAtual == 'N') return 'L';
            else if (direcaoAtual == 'L') return 'S';
            else if (direcaoAtual == 'S') return 'O';
            else if (direcaoAtual == 'O') return 'N';
            return direcaoAtual;
        }
        static char VirarEsquerda(char direcaoAtual)
        {
            if (direcaoAtual == 'N') return 'O';
            else if (direcaoAtual == 'O') return 'S';
            else if (direcaoAtual == 'S') return 'L';
            else if (direcaoAtual == 'L') return 'N';
            return direcaoAtual;
        }

        static (int, int) MoverRobo(char direcaoRobo, int posicaoX, int posicaoY, int qtdMovimentos)
        {
            if (direcaoRobo == 'N' && posicaoY + qtdMovimentos <= 10) posicaoY += qtdMovimentos;
            else if (direcaoRobo == 'S' && posicaoY - qtdMovimentos >= 0) posicaoY -= qtdMovimentos;
            else if (direcaoRobo == 'L' && posicaoX + qtdMovimentos <= 10) posicaoX += qtdMovimentos;
            else if (direcaoRobo == 'O' && posicaoX - qtdMovimentos >= 0) posicaoX -= qtdMovimentos;
            else Console.WriteLine("Você ultrapassou os limites do grid! [mínimo: x=0, y=0; máximo: X=10, y=10]");
            return (posicaoX, posicaoY);
        }
    }
}