using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poker.utils
{
    public class UtiBaralho
    {
        public Baralho GetBaralho() {

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
        public bool IsNipe(List<Carta> mao) {

            if (mao[0].Nipe == mao[1].Nipe && mao[1].Nipe == mao[2].Nipe&& mao[2].Nipe== mao[3].Nipe && mao[3].Nipe == mao[4].Nipe) {

                return true;

            }
            else
            {
                return false;
            }

            
        }


        public bool IsMax(List<Carta> cartas)
        {
            if (cartas[0].Valor == "A" && cartas[1].Valor == "K" && cartas[2].Valor == "Q" && cartas[3].Valor == "J" && cartas[4].Valor == "10") {

                return true;
            }
            else
            {
                return false;
            }
               
                

        }


        public bool IsRoyal(Jogador j){            
            
           if (IsNipe(j.Cartas) == true && IsMax(j.Cartas))
            {
                return true;
            }
            else
            {
                return false;
            }
            
         
        }

        public bool IsStraight(Jogador j){

            if (IsNipe(j.Cartas) == true && IsMax(j.Cartas)==false) {

                return true;
            }
            else{
                return false;
            }

         }

        public int IsIgual(List<Carta> cartas)
        {
           int i = 0;
            if (cartas[0].Valor == cartas[1].Valor) {
                i++;
            }

             else if (cartas[1].Valor == cartas[2].Valor) {
                i++;
             }

              else if (cartas[2].Valor == cartas[3].Valor) {
                i++;
              }
            else if (cartas[3].Valor == cartas[4].Valor)
            {
                i++;
            }
            else if (cartas[4].Valor == cartas[0].Valor)
            {
                i++;
            }
            return i;
        }

        public int ContarValor(List<Carta> cartas)
        {
          
            IEnumerable<IGrouping<string, Carta>> car = cartas.GroupBy(i => i.Valor);

         return car.Count();
        }

        public int ContarNipe(List<Carta> cartas)
        {

            IEnumerable<IGrouping<string, Carta>> car = cartas.GroupBy(i => i.Nipe);

            return car.Count();
        }





        public bool IsQuadra(Jogador j){

            if (IsIgual(j.Cartas) == 3)
                {
                    return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool IsFull(Jogador j){


            if (ContarValor(j.Cartas) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFlush(Jogador j){

            if (ContarValor(j.Cartas) == 5 && ContarNipe(j.Cartas) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public bool IsSequencia(Jogador j){



            return true;
        }

        public bool IsTrinca(Jogador j){


            if (ContarValor(j.Cartas) == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsDoiPares(Jogador j){

            if(ContarValor(j.Cartas) == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool IsPar(Jogador j){


            if (IsIgual(j.Cartas) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsMaiorCarta(Jogador j){



            return true;
        }

    }
}