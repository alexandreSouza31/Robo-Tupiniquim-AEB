namespace Robo_Tupiniquim.ConsoleApp
{
    internal class Program
    {
        public static string instrucao = "mmmmmMmmmemmmmmmmmm".ToUpper();

        static void Main(string[] args)
        {
            bool movimentoValido = true;

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

                    var resultadoMovimento = Movimentar.MoverRobo(qtdMovimentos);
                    if (resultadoMovimento == null)
                    {
                        movimentoValido = false;
                        break;
                    }
                }
                else Console.WriteLine($"Comando inválido: Utilize [D], para direita, [M], para mover, ou [E] para esquerda!");
            }
            Movimentar.ExibirLocalizacao(movimentoValido);
            Console.ReadLine();
        }
    }
}