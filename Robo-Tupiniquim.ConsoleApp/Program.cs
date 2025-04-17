namespace Robo_Tupiniquim.ConsoleApp
{
    internal class Program
    {
        public static string instrucao = "mmmmmMmmmeemmmmmmmmmm".ToUpper();

        static void Main(string[] args)
        {
            for (int i = 0; i < instrucao.Length; i++)
            {
                char comando = instrucao[i];

                if (comando == 'D') Movimentar.VirarDireita();
                else if (comando == 'E') Movimentar.VirarEsquerda();
                else if (comando == 'M')
                {
                    int qtdMovimentos = 0;

                    while (i < instrucao.Length && instrucao[i] == 'M')
                    {
                        qtdMovimentos++;
                        i++;
                    }
                    i--;
                    (Movimentar.posicaoX, Movimentar.posicaoY) = Movimentar.MoverRobo(qtdMovimentos);
                }
                else Console.WriteLine($"Comando inválido: Utilize [D], para direita, [M], para mover, ou [E] para esquerda!");
            }
            string localizacaoRobo = $"{Movimentar.posicaoX},{Movimentar.posicaoY}";
            Console.WriteLine($"\nLocalização do robô:{localizacaoRobo},{Movimentar.direcaoAtualRobo}");
            Console.ReadLine();
        }
    }
}