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
            robo1.ExecutarInstrucoes(instrucao1.ToUpper());

            Console.WriteLine("\nMovimentos do Robô 2:");
            robo2.ExecutarInstrucoes(instrucao2.ToUpper());
            Console.ReadLine();
        }
    }
}
