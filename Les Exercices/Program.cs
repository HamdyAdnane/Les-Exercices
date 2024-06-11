using System;
using AdnaneTools;
class Program
{
    public static void Main(string[] args)
    {
        int age, nombre1, nombre2, nombre3, nombre4, nombre5;
        string Nom1, Nom2, Nom3, sexe;
        int heures, minutes, seconds;
        /**/
        Console.WriteLine("Entrer la premier Valeur");
        nombre1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrer le deuxième Valeur");
        nombre2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrer le troisième Valeur");
        nombre3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrer le quatrième Valeur");
        nombre4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrer le cinquième Valeur");
        nombre5 = Convert.ToInt32(Console.ReadLine());
        var Sadnane = new Adnane();
        // Partie 1 Exercice 6 Et Partie 11 Exercie 8
        Adnane.DoubleChanger(nombre1, nombre2);
        // Partie 1 Exercice 7
        Console.WriteLine(Adnane.TripleValeur(nombre1, nombre2, nombre3));
        // Partie 2 Exercice 2
        Adnane.Carré(nombre1);
        // Partie 2 Exercice 3
        Adnane.Hello();
        // Partie 2 Exercice 4
        Adnane.TTC();
        // Partie 3 Exercice 1 et Exercice 4
        Adnane.Signe(nombre1);
        // Partie 3 Exercice 2 et Exercice 5
        Adnane.Signe_Produit(nombre1, nombre2);
        // Partie 3 Exercice 3
        Console.WriteLine("Entrez successivement trois noms : ");
        Nom1 = Console.ReadLine();
        Nom2 = Console.ReadLine();
        Nom3 = Console.ReadLine();
        if (Adnane.inf(Nom1, Nom2) && Adnane.inf(Nom2, Nom3))
            Console.WriteLine("Ces noms sont classés alphabétiquement");
        else
            Console.WriteLine("Ces noms ne sont pas classés");

        // Partie 3 Exercice 6
        Console.WriteLine("Entrez l’âge de votre l’enfant : ");
        age = Convert.ToInt32(Console.ReadLine());
        Adnane.catégorie(age);

        // Partie 4 Exercice 2 et Exercice 3
        Console.WriteLine("Entrez les heures, puis les minutes, puis les secondes : ");
        heures = Convert.ToInt32(Console.ReadLine());
        minutes = Convert.ToInt32(Console.ReadLine());
        seconds = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Adnane.temps(heures, minutes, seconds));
        // Partie 4 Exercice 4
        Console.WriteLine(Adnane.facture());
        // Partie 4 Exercice 5
        Console.WriteLine("Entrez Votre sexe (M/F) : ");
        sexe = Console.ReadLine();
        Console.WriteLine("Entrez Votre Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Adnane.Zorglub(age, sexe);
        // Partie 4 Exercice 6
        Adnane.Ballotage();
        // Partie 4 Exercice 7
        Console.WriteLine(Adnane.Situation(age));
        // Partie 4 Exercice 8
        Adnane.Date();
        // Partie 5 Exercice 1
        Adnane.NombreBetween();
        // Partie 5 Exercice 2
        Adnane.ValeurBetween();
        // Partie 5 Exercice 3
        Adnane.DixNombresSuivantes();
        // Partie 5 Exercice 4
        Adnane.DixNombreSuivante();
        // Partie 5 Exercice 5
        Adnane.TableMultiplication();
        // Partie 5 Exercice 6
        Adnane.SommeSuivi();
        // Partie 5 Exercice 7
        Adnane.Factorielle();
        // Partie 5 Exercice 8 et 9
        Adnane.PlusGrandValeur();
        // Partie 5 Exercice 10
        Adnane.PrixAchats();
        // Partie 5 Exercice 11
        Adnane.Tierce();
        // Partie 6 Exercice 1
        Adnane.RemplissageTableau0();
        // Partie 6 Exercice 2
        Adnane.RemplissageTableauVoyelles();
        // Partie 6 Exercice 3
        Adnane.RemplissageNotes();
        // Partie 6 Exercice 4
        Adnane.RemplissageTableaux();
        // Partie 6 Exercice 5
        Adnane.RemplirTableauImpair();
        // Partie 6 Exercice 6
        Adnane.TableauSuites();
        // Partie 6 Exercice 7
        Adnane.Moyenne();
        // Partie 6 Exercice 8
        Adnane.Signes_Nombres();
        // Partie 6 Exercice 9
        Adnane.SommeTableau();
        // Partie 6 Exercice 10
        Adnane.Somme_Entre_Deux_Tab();
        // Partie 6 Exercice 11
        Adnane.Produit_Entre_Deux_Tab();
        // Partie 6 Exercice 12
        Adnane.Augemente();
        // Partie 6 Exercice 13
        Adnane.Recherche();
        // Partie 6 Exercice 14
        Adnane.Notes_Classe();
        // Partie 7 Exercice 1
        Adnane.Consécutifs();
        // Partie 7 Exercice 2
        Adnane.TriParInsertion();
        // Partie 7 Exercice 3
        Adnane.Inverse_Ordre();
        // Partie 7 Exercice 4
        Adnane.Supprimer_Valeur();
        // Partie 8 Exercice 1
        Adnane.Remplissant_Par_0();
        // Partie 8 Exercice 6
        Adnane.PlusGrandValeurMulti();
        // Partie 9 Exercice 2
        string Mot;
        Console.WriteLine("Entrer un mot , Stp!");
        Mot = Console.ReadLine();
        Adnane.Nombre_Caractere(Mot);
        // Partie 9 Exercice 3 Et Exercice 4 Et Exercice 5
        Console.WriteLine("Entrez une phrase : ");
        string Phrase = Console.ReadLine();
        Console.WriteLine(Adnane.Nombre_Mots(Phrase));
        Console.WriteLine(Adnane.Nombres_Voyelles(Phrase));
        Console.WriteLine(Adnane.Supprimer_Caractere(Phrase));
        // Partie 9 Exercice 10
        int number;
        Console.WriteLine("Entrez votre nombre : ");
        number = Convert.ToInt32(Console.ReadLine());
        Adnane.Pair(number);
        // Partie 9 Exercice 11
        Adnane.AleatoireNumbres();
        // Partie 11 Exercice 1
        Console.WriteLine(Adnane.Somme(nombre1,nombre2,nombre3,nombre4,nombre5));
        // Partie 11 Exercice 3
        Console.WriteLine(Adnane.Trouve("je m'appel adnane hamdy", "y"));
        // Partie 11 Exercice 6 Et Exercice 7 Et Exercice 9
        int[] Tableau;
        int Nombre_elements;
        Console.WriteLine("Entrer Le Nombre Des élements Que Tu as Entrée :");
        Nombre_elements = Convert.ToInt32(Console.ReadLine());
        Tableau = new int[Nombre_elements];
        for (int i = 0; i <= Nombre_elements - 1; i++)
        {
            Console.WriteLine("Entrez l'élement n° " + (i + 1));
            Tableau[i] = Convert.ToInt32(Console.ReadLine());
        }
        Adnane.TriTableau(Tableau, Nombre_elements);
        bool situation = Adnane.TableauCroissant(Tableau, Nombre_elements);
        Console.WriteLine("La Croissant De Ces élemnts est " + situation);
        bool Choix = true;
        Console.WriteLine("Le tri est effectué automatiquement Croissante si vous souhaitez modifier de tri en Decroissante Entrée zero '0', Sinon Entrée un '1'.");
        int Number_Choix = Convert.ToInt32(Console.ReadLine());
        if (Number_Choix == 0)
            Choix = false;
        Adnane.TriTableaux(Tableau, Nombre_elements, Choix);
        // Partie 11 Exercice 10 Sodoku
        int[,] Sudok = new int[,]
                    {
                {5, 3, 0, 0, 7, 0, 0, 0, 0},
                {6, 0, 0, 1, 9, 5, 0, 0, 0},
                {0, 9, 8, 0, 0, 0, 0, 6, 0},
                {8, 0, 0, 0, 6, 0, 0, 0, 3},
                {4, 0, 0, 8, 0, 3, 0, 0, 1},
                {7, 0, 0, 0, 2, 0, 0, 0, 6},
                {0, 6, 0, 0, 0, 0, 2, 8, 0},
                {0, 0, 0, 4, 1, 9, 0, 0, 5},
                {0, 0, 0, 0, 8, 0, 0, 7, 9}
                    }; ;
        RemplitGrille(Sudok);
        while (!VerifLignes(Sudok) || !VerifColonnes(Sudok) || !VerifSousGrilles(Sudok))
        {
            PrintSudoku(Sudok);
        }
    }
    public static bool TousDifferentes(int[] Tableau_vérification)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = i + 1; j < 9; j++)
            {
                if (Tableau_vérification[i] == Tableau_vérification[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static void RemplitGrille(int[,] Tableau_Tous_Cases)
    {
        Random rnd = new Random();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Tableau_Tous_Cases[i, j] = rnd.Next(1, 10);
            }
        }
    }
    public static bool VerifLignes(int[,] Grille)
    {
        int[] Ligne = new int[9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Ligne[j] = Grille[i, j];
            }
            if (!TousDifferentes(Ligne))
            {
                return false;
            }
        }
        return true;
    }
    public static bool VerifColonnes(int[,] Grille)
    {
        int[] Colonne = new int[9];
        for (int j = 0; j < 9; j++)
        {
            for (int i = 0; i < 9; i++)
            {
                Colonne[i] = Grille[i, j];
            }
            if (!TousDifferentes(Colonne))
            {
                return false;
            }
        }
        return true;
    }
    public static bool VerifSousGrilles(int[,] Grille)
    {
        int[] SousGrille = new int[9];
        for (int i = 0; i < 7; i = i + 3)
        {
            for (int j = 0; j < 7; j = j + 3)
            {
                for (int ii = 0; ii < 3; ii++)
                {
                    for (int jj = 0; jj < 3; jj++)
                    {
                        SousGrille[ii * 3 + jj] = Grille[i + ii, j + jj];
                    }
                }
                if (!TousDifferentes(SousGrille))
                {
                    return false;
                }
            }
        }
        return true;
    }
    static void PrintSudoku(int[,] board)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}