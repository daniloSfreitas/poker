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
        public ActionResult Index()
        {
            UtiBaralho utilBaralho = new UtiBaralho();
            Baralho baralho = utilBaralho.getBaralho();

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

       
        
    }    
}