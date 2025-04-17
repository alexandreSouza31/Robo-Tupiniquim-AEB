namespace Robo_Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robo robo1 = new Robo();
            Robo robo2 = new Robo();

            string instrucao1 = "MMMMMMeMME";
            string instrucao2 = "MMEMMMDDM";

            Console.WriteLine("Movimentos do Robô 1:");
            ExecutarInstrucoes(robo1, instrucao1.ToUpper());

            Console.WriteLine("\nMovimentos do Robô 2:");
            ExecutarInstrucoes(robo2, instrucao2.ToUpper());

            Console.ReadLine();
        }

        static void ExecutarInstrucoes(Robo robo, string instrucao)
        {
            for (int i = 0; i < instrucao.Length; i++)
            {
                char comando = instrucao[i];

                if (comando == 'D') robo.VirarDireita();
                else if (comando == 'E') robo.VirarEsquerda();
                else if (comando == 'M')
                {
                    int qtdMovimentos = 0;
                    int j = i;
                    while (j < instrucao.Length && instrucao[j] == 'M')
                    {
                        qtdMovimentos++;
                        j++;
                    }
                    i = j - 1;

                    bool valido = robo.Mover(qtdMovimentos);
                    if (!valido)
                    {
                        robo.ExibirLocalizacao(false);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Comando inválido.");
                }
            }

            robo.ExibirLocalizacao(true);
        }
    }
}
