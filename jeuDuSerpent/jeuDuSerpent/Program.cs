/*
using static System.Formats.Asn1.AsnWriter;

class Program
{



    static void Main(string[] args)
    {
        int score1 = 0;
        int score2 = 0;

        bool gameEnCours = true;


        Console.WriteLine("Bienvue dans le jeu du serpent\n");

        Console.WriteLine("Entrez le nom du premier joueur\n");

        String prenom1 = Console.ReadLine();

        Console.WriteLine("Entrez le nom du deuxieme joueur\n");

        String prenom2 = Console.ReadLine();

        Console.WriteLine("Le jeu va commencer\n");


        Console.WriteLine(prenom1 + " doit lancer le dé en premier\n");

        while (gameEnCours)
        {
            Console.WriteLine(prenom1 + ", voulez vous lancer le dé ? (y/n)\n");

            if (Console.ReadLine() == "y")
            {
                Random aleatoire = new Random();
                int valeur = aleatoire.Next(1, 7);
                Console.WriteLine("Vous avez fait " + valeur + "\n");

                score1 += valeur;

                Console.WriteLine(prenom1 + " a " + score1 + " points\n");

                if (score1 > 50)
                {
                    Console.WriteLine(prenom1 + ", vous avez dépassé les 50 points, vous retournez à 25 points.\n");
                    score1 = 25;
                }
                else if (score1 == 50)
                {
                    gameEnCours = false;
                    Console.WriteLine("Vous avez 50, vous avez gagné" + prenom1 + "\n");
                }
            }
            else
            {
                Console.WriteLine("Vous avez refusé de lancer le dé\n");
            }

            Console.WriteLine(prenom2 + ", voulez vous lancer le dé ? (y/n)\n");

            if (Console.ReadLine() == "y")
            {
                Random aleatoire = new Random();
                int valeur = aleatoire.Next(1, 7);
                Console.WriteLine("Vous avez fait " + valeur + "\n");

                score2 += valeur;

                Console.WriteLine(prenom2 + " a " + score2 + " points\n");

                if (score2 > 50)
                {
                    Console.WriteLine(prenom2 + ", vous avez dépassé les 50 points, vous retournez à 25 points.\n");
                    score2 = 25;
                }
                else if (score2 == 50)
                {
                    gameEnCours = false;
                    Console.WriteLine("Vous avez 50, vous avez gagné" + prenom2 + "\n");
                }
            }
            else
            {
                Console.WriteLine("Vous avez refusé de lancer le dé...\n");
            }
        }
    }
}
*/