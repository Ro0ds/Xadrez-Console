using System;
using xadrez;
using tabuleiro;

namespace Xadrez {
    internal class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Origem: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException a) {
                Console.WriteLine(a.Message);
            }
        }
    }
}