using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker.Models
{
    public class Carta
    {
        private String nipe;
        private String valor;

        public string Nipe { get => nipe; set => nipe = value; }
        public string Valor { get => valor; set => valor = value; }

        public static implicit operator List<object>(Carta v)
        {
            throw new NotImplementedException();
        }
    }


}