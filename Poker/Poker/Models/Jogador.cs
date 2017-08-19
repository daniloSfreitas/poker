using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker.Models
{
    public class Jogador
    {
        private String nome;
        private List<Carta> cartas;

        public List<Carta> Cartas { get => cartas; set => cartas = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Jogador> Add { get; internal set; }
    }
}