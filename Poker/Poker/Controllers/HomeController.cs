using Poker.Models;
using Poker.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poker.Controllers
{
    public class HomeController : Controller
    {
        UtiBaralho utilBaralho = new UtiBaralho();
        public ActionResult Index()
        {            
            Baralho baralho = utilBaralho.GetBaralho();

            List<Carta> mao = new List<Carta>();
            List<Carta> mao2 = new List<Carta>();

            Random rnd = new Random();

            for (int i= 0; i < 5; i++){
                int a = rnd.Next(0, baralho.Cartas.Count);
                mao.Add(baralho.Cartas[a]);
                baralho.Cartas.RemoveAt(a);
                int b = rnd.Next(0, baralho.Cartas.Count);
                mao2.Add(baralho.Cartas[b]);
                baralho.Cartas.RemoveAt(b);
            }         
            

            List<Jogador> jogadores = new List<Jogador>();

            Jogador jogador1 = new Jogador();
            jogador1.Nome = "Adversário";
            jogador1.Cartas = mao;
            

            jogadores.Add(jogador1);          

           
            Jogador jogador2 = new Jogador();
            jogador2.Nome = "Voce"; 
            jogador2.Cartas = mao2;

            jogadores.Add(jogador2);

            
            return View(jogadores);
        }

        public void verificarRank(Jogador jogador)
        {

            if (utilBaralho.IsRoyal(jogador))
            {

                jogador.Rank = 10;
                jogador.Combinacao = "Royal Flush";
            }
            else if (utilBaralho.IsStraight(jogador))
            {
                jogador.Rank = 9;
                jogador.Combinacao = "Straight Flush";
            }
            else if (utilBaralho.IsQuadra(jogador))
            {
                jogador.Rank = 8;
                jogador.Combinacao = "Quadra";
            }
            else if (utilBaralho.IsFull(jogador))
            {
                jogador.Rank = 7;
                jogador.Combinacao = "Full House";
            }

            else if (utilBaralho.IsFlush(jogador))
            {

                jogador.Rank = 6;
                jogador.Combinacao = "Flush";
            }
            else if (utilBaralho.IsSequencia(jogador))
            {
                jogador.Rank = 5;
                jogador.Combinacao = "Straight";
            }

            else if (utilBaralho.IsTrinca(jogador))
            {

                jogador.Rank = 4;
                jogador.Combinacao = "Trinca";
            }
            else if (utilBaralho.IsDoiPares(jogador))
            {
                jogador.Rank = 3;
                jogador.Combinacao = "Dois Pares";
            }

            else if (utilBaralho.IsPar(jogador))
            {

                jogador.Rank = 2;
                jogador.Combinacao = "Par";
            }
            else if (utilBaralho.IsMaiorCarta(jogador))
            {
                jogador.Rank = 1;
                jogador.Combinacao = "Maior Carta";
            }

        }


    } 
    
}