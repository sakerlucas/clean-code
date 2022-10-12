using System;

public class Joueur
{

    public int score;
    public string? prenom;

    public Joueur(int sc, string? pr)
    {
        this.score = sc;
        this.prenom = pr;
    }

    public string getPrenom()
    {
        return prenom;
    }

    public int getScore()
    {
        return this.score;
    }

    public void setScore(int valeur)
    {
        this.score = valeur;
    }
}


