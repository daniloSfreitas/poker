using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker.utils
{
    public class UtiBaralho
    {
        public Baralho GetBaralho()
        {

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

            return b;


        }
        public bool IsNipe(List<Carta> mao)
        {

            if (mao[0].Nipe == mao[1].Nipe && mao[1].Nipe == mao[2].Nipe && mao[2].Nipe == mao[3].Nipe && mao[3].Nipe == mao[4].Nipe)
            {

                return true;

            }
            else
            {
                return false;
            }


        }


        public bool IsMax(List<Carta> cartas)
        {
            if (cartas[0].Valor == "A" && cartas[1].Valor == "K" && cartas[2].Valor == "Q" && cartas[3].Valor == "J" && cartas[4].Valor == "10")
            {

                return true;
            }
            else
            {
                return false;
            }



        }


        public bool IsRoyal(Jogador j)
        {

            if (IsNipe(j.Cartas) == true && IsMax(j.Cartas))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsStraight(Jogador j)
        {

            if (IsNipe(j.Cartas) == true && j.Cartas[0].Valor == "9" && j.Cartas[1].Valor == "8" && j.Cartas[2].Valor == "7" && j.Cartas[3].Valor == "6" && j.Cartas[4].Valor == "5"
                || j.Cartas[0].Valor == "8" && j.Cartas[1].Valor == "7" && j.Cartas[2].Valor == "6" && j.Cartas[3].Valor == "5" && j.Cartas[4].Valor == "4"
                || j.Cartas[0].Valor == "7" && j.Cartas[1].Valor == "6" && j.Cartas[2].Valor == "5" && j.Cartas[3].Valor == "4" && j.Cartas[4].Valor == "3"
                || j.Cartas[0].Valor == "6" && j.Cartas[1].Valor == "5" && j.Cartas[2].Valor == "4" && j.Cartas[3].Valor == "3" && j.Cartas[4].Valor == "2"
                || j.Cartas[0].Valor == "5" && j.Cartas[1].Valor == "4" && j.Cartas[2].Valor == "3" && j.Cartas[3].Valor == "2" && j.Cartas[4].Valor == "A")
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public int IsIgual(List<Carta> cartas)
        {
            int i = 0;
            if (cartas[0].Valor == cartas[1].Valor)
            {
                i++;
            }

            if (cartas[1].Valor == cartas[2].Valor)
            {
                i++;
            }

            if (cartas[2].Valor == cartas[3].Valor)
            {
                i++;
            }
            if (cartas[3].Valor == cartas[4].Valor)
            {
                i++;
            }
            if (cartas[4].Valor == cartas[0].Valor)
            {
                i++;
            }
            return i;
        }

        public IEnumerable<IGrouping<string, Carta>> ContarValor(List<Carta> cartas)
        {

            IEnumerable<IGrouping<string, Carta>> car = cartas.GroupBy(i => i.Valor);

            return car;
        }

        public int ContarNipe(List<Carta> cartas)
        {

            IEnumerable<IGrouping<string, Carta>> car = cartas.GroupBy(i => i.Nipe);

            return car.Count();
        }





        public bool IsQuadra(Jogador j)
        {

            IList<String> cartas = new List<string>();
            foreach (var c in j.Cartas)
            {
                cartas.Add(c.Valor);
            }

            for (int i = 0; i < 3; i++)
            {

                if (cartas.Where(x => x.Equals(cartas[i])).Count() == 4)
                {
                    return true;
                }
            }
            return false;


        }

        public bool IsFull(Jogador j)
        {


            if (ContarValor(j.Cartas).Count() == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFlush(Jogador j)
        {

            if (ContarValor(j.Cartas).Count() == 5 && ContarNipe(j.Cartas) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsSequencia(Jogador j)
        {
            if (IsNipe(j.Cartas) == false && j.Cartas[0].Valor == "K" && j.Cartas[1].Valor == "Q" && j.Cartas[2].Valor == "J" && j.Cartas[3].Valor == "10" && j.Cartas[4].Valor == "9"
                     || j.Cartas[0].Valor == "Q" && j.Cartas[1].Valor == "J" && j.Cartas[2].Valor == "10" && j.Cartas[3].Valor == "9" && j.Cartas[4].Valor == "8"
                     || j.Cartas[0].Valor == "J" && j.Cartas[1].Valor == "10" && j.Cartas[2].Valor == "9" && j.Cartas[3].Valor == "8" && j.Cartas[4].Valor == "7"
                     || j.Cartas[0].Valor == "10" && j.Cartas[1].Valor == "9" && j.Cartas[2].Valor == "8" && j.Cartas[3].Valor == "7" && j.Cartas[4].Valor == "6"
                     || j.Cartas[0].Valor == "9" && j.Cartas[1].Valor == "8" && j.Cartas[2].Valor == "7" && j.Cartas[3].Valor == "6" && j.Cartas[4].Valor == "5"
                     || j.Cartas[0].Valor == "8" && j.Cartas[1].Valor == "7" && j.Cartas[2].Valor == "6" && j.Cartas[3].Valor == "5" && j.Cartas[4].Valor == "4"
                     || j.Cartas[0].Valor == "7" && j.Cartas[1].Valor == "6" && j.Cartas[2].Valor == "5" && j.Cartas[3].Valor == "4" && j.Cartas[4].Valor == "3"
                     || j.Cartas[0].Valor == "6" && j.Cartas[1].Valor == "5" && j.Cartas[2].Valor == "4" && j.Cartas[3].Valor == "3" && j.Cartas[4].Valor == "2"
                     || j.Cartas[0].Valor == "5" && j.Cartas[1].Valor == "4" && j.Cartas[2].Valor == "3" && j.Cartas[3].Valor == "2" && j.Cartas[4].Valor == "A")
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        public bool IsTrinca(Jogador j)
        {
            IList<String> cartas = new List<string>();
            foreach (var c in j.Cartas)
            {
                cartas.Add(c.Valor);
            }

            for (int i = 0; i < 3; i++)
            {

                if (cartas.Where(x => x.Equals(cartas[i])).Count() == 3)
                {
                    return true;
                }
            }           
                return false;
            

        }

        public bool IsDoiPares(Jogador j)
        {

            if (IsIgual(j.Cartas) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsPar(Jogador j)
        {


            if (IsIgual(j.Cartas) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       
    }
}