using static Joueur;

public class ProgramV2
{

    static void Main(string[] args)
    {

        bool jeuFini = false;

        Console.WriteLine("Bienvue dans le jeu du serpent\n\n");

        Console.WriteLine("Entrez le nom du premier joueur\n");
        string? prenom1 = Console.ReadLine();
        Joueur joueur1 = new Joueur(0, prenom1);

        Console.WriteLine("Entrez le nom du deuxieme joueur\n");
        string? prenom2 = Console.ReadLine();
        Joueur joueur2 = new Joueur(0, prenom2);

        List<Joueur> listeDeJoueurs = new List<Joueur>();
        listeDeJoueurs.Add(joueur1);
        listeDeJoueurs.Add(joueur2);

        Console.WriteLine("Le jeu va commencer\n\n");

        Console.WriteLine(joueur1.getPrenom() + " doit lancer le dé en premier\n");

        while (!jeuFini)
        {
            for (int i = 0; i < listeDeJoueurs.Count; i++)
            {
                lancerLesDes(listeDeJoueurs[i]);
                if (listeDeJoueurs[i].getScore() > 50)
                    siGagne(listeDeJoueurs[i]);
                else if (listeDeJoueurs[i].getScore() == 50)
                {
                    Console.WriteLine(listeDeJoueurs[i].getPrenom() + " a un score de 50, il a donc gagné !\n");
                    jeuFini = true;
                    break;
                }
                else
                    Console.WriteLine("\n");
            }

            if (jeuFini)
                break;
        }
    }

    public static void lancerLesDes(Joueur joueur)
    {
        Console.WriteLine("Au tour de " + joueur.getPrenom() + " de jetter les dés !");

        Random aleatoire = new Random();
        int valeur = aleatoire.Next(1, 7);

        Console.WriteLine(joueur.getPrenom() + " a fait un score de " + valeur);

        int scoreJoueur = joueur.getScore();
        joueur.setScore(scoreJoueur + valeur);

        Console.WriteLine(joueur.getPrenom() + " a un score de " + joueur.getScore());
    }

    public static void siGagne(Joueur joueur)
    {
        joueur.setScore(25);
        Console.WriteLine(joueur.getPrenom() + " a fait plus de 50, il retombe a 25\n");
    }
}