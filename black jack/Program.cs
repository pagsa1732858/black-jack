using System;
enum Sorte
{

    coeur = 1,
    pique = 2,
    carraux = 3,
    trefle = 4,
}

namespace black_jack
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("jeux de blackjack pour deux joueur");

            Console.WriteLine("chaqu'un des joueur debute avec le total de 100 jetons\n il devrons mettre une mise de depart pour ressevoir leurs cartes.");

            Console.WriteLine("choisissez une mise de depart");


            int jetons = Convert.ToInt32(Console.ReadLine());


            //variables
            Random aleatoires = new Random();
            string sorteAfficher = "";
            string nombreAfficher = "";
            string sorteAfficher2 = "";
            string nombreAfficher2 = "";



            int reponse = 0;
            Sorte sorte = (Sorte)aleatoires.Next(1, 5);
            int nombre = aleatoires.Next(1, 14);
            nombreAfficher = Convert.ToString(nombre);


            //jetons

            int GenererValeur()
            {
                int nbre = aleatoires.Next(1, 14);
                return nbre;
            }




            //cartes pour le joeur 
            Sorte carteSorte1J = (Sorte)aleatoires.Next(1, 5);
            int carteNombre1J = GenererValeur();

            switch (carteSorte1J)
            {
                case Sorte.coeur: sorteAfficher = "coeur"; break;
                case Sorte.pique: sorteAfficher = "pique"; break;
                case Sorte.carraux: sorteAfficher = "carraux"; break;
                case Sorte.trefle: sorteAfficher = "trefle"; break;

            }
            switch (carteNombre1J)
            {
                case 11: nombreAfficher = "valet"; break;
                case 12: nombreAfficher = "dame"; break;
                case 13: nombreAfficher = "roi"; break;
                case 1: nombreAfficher = "as"; break;

            }

            //carte aleatoire pour le joeur
            Sorte carte2Sorte1J = (Sorte)aleatoires.Next(1, 5);
            int carte2Nombre1J = GenererValeur();

            switch (carte2Sorte1J)
            {
                case Sorte.coeur: sorteAfficher2 = "coeur"; break;
                case Sorte.pique: sorteAfficher2 = "pique"; break;
                case Sorte.carraux: sorteAfficher2 = "carraux"; break;
                case Sorte.trefle: sorteAfficher2 = "trefle"; break;

            }
            switch (carte2Nombre1J)
            {
                case 11: nombreAfficher2 = "valet"; break;
                case 12: nombreAfficher2 = "dame"; break;
                case 13: nombreAfficher2 = "roi"; break;
                case 1: nombreAfficher2 = "as"; break;

            }

            Console.WriteLine("la premiere carte du joueur est:" + carteSorte1J + " " + carteNombre1J);
            Console.WriteLine("et sa deuxieme carte est:" + carte2Sorte1J + " " + carte2Nombre1J);
            //carte aleatoire l'intelligence artifficel 
            Sorte carte1sorte2J = (Sorte)aleatoires.Next(1, 5);
            int carte1Nombre2J = GenererValeur();

            switch (carte1sorte2J)
            {
                case Sorte.coeur: sorteAfficher = "coeur"; break;
                case Sorte.pique: sorteAfficher = "pique"; break;
                case Sorte.carraux: sorteAfficher = "carraux"; break;
                case Sorte.trefle: sorteAfficher = "trefle"; break;

            }
            switch (carte1Nombre2J)
            {
                case 11: nombreAfficher = "valet"; break;
                case 12: nombreAfficher = "dame"; break;
                case 13: nombreAfficher = "roi"; break;
                case 1: nombreAfficher = "as"; break;
            }

            Console.WriteLine("la premiere carte de l'intelligence artifficiel est:" + carte1sorte2J + " " + carte1Nombre2J);


            Console.WriteLine("le joueur a deux choix possible");
            Console.WriteLine("1- prendre une nouvelle carte");
            Console.WriteLine("2- arreter");
            reponse = Convert.ToInt32(Console.ReadLine());

            Sorte carte3sorte1J = (Sorte)aleatoires.Next(1, 5);
            int carte3Nombre1J = GenererValeur();
            if (reponse == 1)//choix de carte aleatoire pour le joueur 
            {
                switch (carte3sorte1J)
                {
                    case Sorte.coeur: sorteAfficher = "coeur"; break;
                    case Sorte.pique: sorteAfficher = "pique"; break;
                    case Sorte.carraux: sorteAfficher = "carraux"; break;
                    case Sorte.trefle: sorteAfficher = "trefle"; break;

                }
                switch (carte3Nombre1J)
                {
                    case 11: nombreAfficher = "valet"; break;
                    case 12: nombreAfficher = "dame"; break;
                    case 13: nombreAfficher = "roi"; break;
                    case 1: nombreAfficher = "as"; break;
                }
                Console.WriteLine("la nouvelle carte du joueur est:" + carte3sorte1J + " " + carte3Nombre1J);
                if (carteNombre1J + carte2Nombre1J + carte3Nombre1J > 21)
                {
                    Console.WriteLine("le joueur a plus de 21 donc il gagne automatiquement bravo au joueur: merci davoir participer!!!");
                }

                else
                {
                    if (reponse == 2)//arreter le jeux 
                    {
                        Console.WriteLine("il a passer sont tour.");
                    }
                    Console.WriteLine("ses donc au tours de l'intelligence artifficiel de jouer");

                    Sorte carte2sorte2J = (Sorte)aleatoires.Next(1, 5);
                    int carte2Nombre2J = GenererValeur();
                    if (carte1Nombre2J < carteNombre1J + carte2Nombre1J + carte3Nombre1J)
                    {
                        Console.WriteLine("la carte de l'intelligence artifficiel est plus petite que les\n trois carte du joueur donc il peut prendre une autre carte.");
                        Console.WriteLine("il demande une autre carte");


                        switch (carte2sorte2J)
                        {
                            case Sorte.coeur: sorteAfficher = "coeur"; break;
                            case Sorte.pique: sorteAfficher = "pique"; break;
                            case Sorte.carraux: sorteAfficher = "carraux"; break;
                            case Sorte.trefle: sorteAfficher = "trefle"; break;

                        }
                        switch (carte2Nombre2J)
                        {
                            case 11: nombreAfficher = "valet"; break;
                            case 12: nombreAfficher = "dame"; break;
                            case 13: nombreAfficher = "roi"; break;
                            case 1: nombreAfficher = "as"; break;
                        }
                        Console.WriteLine("la nouvelle carte de l'intelligence est:" + carte2sorte2J + " " + carte2Nombre2J);

                        if (carte1Nombre2J + carte2Nombre2J > carteNombre1J + carte2Nombre1J + carte3Nombre1J)
                        {
                            Console.WriteLine("l'intelligence artifficiel a plus de point donc ses lui qui gane: meilleur chance la prochaine fois !!!");
                        }
                        else
                        {
                            Console.WriteLine("ses le joueur qui a le plus de point ses donc lui qui gange,youpi!!!");
                        }
                    }

                }

            }

            Console.ReadKey();
        }
    }
}
