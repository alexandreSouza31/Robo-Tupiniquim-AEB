namespace Robo_Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX = 0;
            int posicaoY = 0;
            string localizacaoRobo = $"{posicaoX},{posicaoY}";
            string direcaoRobo = "N"; //Direção começa
            string instrucao = "DDD".ToUpper();

            for (int i = 0; i < instrucao.Length; i++)
            {
                char comando = instrucao[i];

                if (comando == 'D')
                {
                    if (direcaoRobo == "N")
                    {
                        direcaoRobo = "L";
                    }
                    else if (direcaoRobo == "L")
                    {
                        direcaoRobo = "S";
                    }
                    else if (direcaoRobo == "S")
                    {
                        direcaoRobo = "O";
                    }
                }
                else
                {
                    Console.WriteLine($"Comando inválido: Utilize [D], para direita, ou [E] para esquerda!");
                    //Console.ReadLine();
                    break;
                }

            }
            Console.WriteLine($"\nLocalização do robô:{localizacaoRobo},{direcaoRobo}");
            Console.ReadLine();
        }
    }
}