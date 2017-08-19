using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker.Models
{
    public class Jogador
    {
        private String nome;
        private List<Carta> Cartas;

        public string Nome { get => nome; set => nome = value; }
        public List<Carta> Cartas1 { get => Cartas; set => Cartas = value; }
    }
}