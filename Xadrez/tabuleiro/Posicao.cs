﻿namespace tabuleiro {
    internal class Posicao {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        override public string ToString() {
            return linha + ", " + coluna;
        }
    }
}