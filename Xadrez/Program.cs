using System;
using tabuleiro;
using xadrez;

namespace Program{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Tabuleiro tab = new Tabuleiro(7, 7);

                tab.colorcarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                
                tab.colorcarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.colorcarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
          

            Console.ReadLine();
        }
    }
}
