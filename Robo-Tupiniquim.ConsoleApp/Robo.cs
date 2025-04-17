namespace Robo_Tupiniquim.ConsoleApp
{
    public class Robo
    {
        public int posicaoX = 0;
        public int posicaoY = 0;
        public char direcaoAtualRobo = 'L';
        public char VirarDireita()
        {
            if (direcaoAtualRobo == 'N') direcaoAtualRobo = 'L';
            else if (direcaoAtualRobo == 'L') direcaoAtualRobo = 'S';
            else if (direcaoAtualRobo == 'S') direcaoAtualRobo = 'O';
            else if (direcaoAtualRobo == 'O') direcaoAtualRobo = 'N';
            return direcaoAtualRobo;
        }
        public char VirarEsquerda()
        {
            if (direcaoAtualRobo == 'N') direcaoAtualRobo = 'O';
            else if (direcaoAtualRobo == 'O') direcaoAtualRobo = 'S';
            else if (direcaoAtualRobo == 'S') direcaoAtualRobo = 'L';
            else if (direcaoAtualRobo == 'L') direcaoAtualRobo = 'N';
            return direcaoAtualRobo;
        }
        public bool Mover(int qtdMovimentos)
        {
            if (direcaoAtualRobo == 'N' && posicaoY + qtdMovimentos <= 10) posicaoY += qtdMovimentos;
            else if (direcaoAtualRobo == 'S' && posicaoY - qtdMovimentos >= 0) posicaoY -= qtdMovimentos;
            else if (direcaoAtualRobo == 'L' && posicaoX + qtdMovimentos <= 10) posicaoX += qtdMovimentos;
            else if (direcaoAtualRobo == 'O' && posicaoX - qtdMovimentos >= 0) posicaoX -= qtdMovimentos;
            else return false;
            return true;
        }

        public void ExibirLocalizacao(bool movimentoValido)
        {
            if (movimentoValido)
            {
                string localizacaoRobo = $"{posicaoX},{posicaoY}";
                Console.WriteLine($"\nLocalização do robô:{localizacaoRobo},{direcaoAtualRobo}");
                return;
            }
            else
            {
                ExibirMensagemErro();
                return;
            }
        }

        public void ExibirMensagemErro()
        { Console.WriteLine("\nMovimento inválido - O robô ultrapassou os limites do grid."); }
    }
}
