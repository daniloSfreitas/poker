using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker.utils
{
    public class UtiBaralho
    {
        public Baralho getBaralho(){

            List<Carta> cartas = new List<Carta>();


            string[] nipe = { "C", "E", "O", "P" };
            string[] valor = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int n = 0; n < nipe.Length; n++)
            {
                for (int v = 0; v < valor.Length; v++)
                {

                    Carta c = new Carta();                   
                    c.Nipe = nipe[n];
                    c.Valor = valor[v];

                    cartas.Add(c);



                }
            }

            Baralho b = new Baralho();
            b.Cartas = cartas;

            Console.Write("teste");

            return b ;


        }
    }
}