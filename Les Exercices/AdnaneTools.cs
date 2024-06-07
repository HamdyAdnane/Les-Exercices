using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
namespace AdnaneTools
{
    public class Adnane
    {
        public static void DoubleChanger(int Valeur1, int Valeur2)
        {
            int Valeur_Changer = Valeur1;
            Valeur1 = Valeur2;
            Valeur2 = Valeur_Changer;
        }
        public static string TripleValeur(int Valeur1, int Valeur2, int Valeur3)
        {
            int Valeur_Changer = Valeur3;
            Valeur3 = Valeur2;
            Valeur2 = Valeur1;
            Valeur1 = Valeur_Changer;
            return "La premier Valeur Sera " + Valeur1 + " , La deuxieme Valeur sera " + Valeur2 + " et La troisième Valeur sera " + Valeur3;
        }
        public static void Carré(int Nombre)
        {
            int Carré;
            Carré = Nombre * Nombre;
            Console.WriteLine("Le carré de nombre " + Nombre + " est : " + Carré);
        }
        public static void Hello()
        {
            Console.WriteLine("Quel est votre prenom ?");
            string Prenom = Console.ReadLine();
            Console.WriteLine("Bonjour " + Prenom + " !");
        }
        public static void TTC()
        {
            int Prix_Hors_Taxe, Nombre_Articles, Taux_TVA, Prix_Total_TTC;
            Console.WriteLine("Entrez le prix hors taxes :");
            Prix_Hors_Taxe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d’articles :");
            Nombre_Articles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le taux de TVA :");
            Taux_TVA = Convert.ToInt32(Console.ReadLine());
            Prix_Total_TTC = Nombre_Articles * Prix_Hors_Taxe * (1 + Taux_TVA / 10);
            Console.WriteLine("Le prix toutes taxes est : " + Prix_Total_TTC);
        }
        public static void Signe(int Nombre)
        {
            if (Nombre > 0)
            {
                Console.WriteLine("Le Signe de Nombre " + Nombre + " est positif");
            }
            else if (Nombre == 0)
            {
                Console.WriteLine("Ce nombre est nul");
            }
            else
            {
                Console.WriteLine("Le Signe de Nombre " + Nombre + " est Negatif");
            }
        }
        public static void Signe_Produit(int Valeur1, int Valeur2)
        {
            if ((Valeur1 > 0 && Valeur2 > 0) || (Valeur1 < 0 && Valeur2 < 0))
            {
                Console.WriteLine("Le produit de " + Valeur1 + " et " + Valeur2 + " est positif");
            }
            else if ((Valeur1 == 0) || (Valeur2 == 0))
            {
                Console.WriteLine("Le produit de " + Valeur1 + " et " + Valeur2 + " est nul");
            }
            else
            {
                Console.WriteLine("Le produit de " + Valeur1 + " et " + Valeur2 + " est négatif");
            }
        }
        public static bool inf(string a, string b)
        {
            int ic = 0;
            while (ic < a.Length && ic < b.Length)
            {
                if (a[ic] < b[ic])
                    return true;
                if (a[ic] > b[ic])
                    return false;
                ic++;
            }
            bool aPlusPetitQueB = a.Length <= b.Length;
            return aPlusPetitQueB;
        }
        public static void catégorie(int age)
        {
            if (age >= 12)
            {
                Console.WriteLine("Catégorie Cadet");
            }
            else if (age >= 10)
            {
                Console.WriteLine("Catégorie Minime");
            }
            else if (age >= 8)
            {
                Console.WriteLine("Catégorie Pupille");
            }
            else if (age >= 6)
            {
                Console.WriteLine("Catégorie Poussin");
            }
        }
        public static string temps(int h, int m, int s)
        {
            s = s + 1;
            if (s == 60)
            {
                s = 0;
                m = m + 1;
            }
            if (m == 60)
            {
                m = 0;
                h = h + 1;
            }
            if (h == 24)
            {
                h = 0;
            }
            return "Dans une seconde il sera " + h + "h " + m + "m et " + s + "s";
        }
        public static string facture()
        {
            int Nombre_Photocopies;
            double Prix_total;
            Console.WriteLine("Nombre de photocopies : ");
            Nombre_Photocopies = Convert.ToInt16(Console.ReadLine());
            if (Nombre_Photocopies <= 10)
            {
                Prix_total = Nombre_Photocopies * 0.1;
            }
            else if (Nombre_Photocopies <= 30)
            {
                Prix_total = 10 * 0.1 + (Nombre_Photocopies - 10) * 0.09;
            }
            else
            {
                Prix_total = (10 * 0.1) + (20 * 0.09) + ((Nombre_Photocopies - 30) * 0.08);
            }
            return "Le prix total est: " + Prix_total;
        }
        public static void Zorglub(int age, string sex)
        {
            bool C1, C2;
            C1 = sex == "M" && age > 20;
            C2 = sex == "F" && (age > 18 && age < 35);
            if (C1 || C2)
            {
                Console.WriteLine("Imposable");
            }
            else
            {
                Console.WriteLine("Non Imposable");
            }
        }
        public static void Ballotage()
        {
            int score1, score2, score3, score4;
            bool C1, C2, C3, C4;
            Console.WriteLine("Entrez les scores des quatre prétendants :");
            score1 = Convert.ToInt32(Console.ReadLine());
            score2 = Convert.ToInt32(Console.ReadLine());
            score3 = Convert.ToInt32(Console.ReadLine());
            score4 = Convert.ToInt32(Console.ReadLine());

            C1 = score1 > 50;
            C2 = score2 > 50 || score3 > 50 || score4 > 50;
            C3 = score1 >= score2 && score1 >= score3 && score1 >= score4;
            C4 = score1 >= 12.5;
            if (C1)
            {
                Console.WriteLine("Elu au premier tour");
            }
            else if (C2 || !C4)
            {
                Console.WriteLine("Battu, éliminé, sorti !!!");
            }
            else if (C3)
            {
                Console.WriteLine("Ballotage favorable");
            }
            else
            {
                Console.WriteLine("Ballotage défavorable");
            }
        }
        public static string Situation(int age)
        {
            int perm, acc, assur;
            bool C1, C2, C3;
            string situ;
            Console.WriteLine("Entrez le nombre d'années de permis: ");
            perm = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'accidents: ");
            acc = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entrez le nombre d'années d'assurance: ");
            assur = Convert.ToInt16(Console.ReadLine());
            C1 = age >= 25;
            C2 = perm >= 2;
            C3 = assur > 5;
            if (!C1 && !C2)
            {
                if (acc == 0)
                {
                    situ = "Rouge";
                }
                else
                {
                    situ = "Refusé";
                }
            }
            else if ((!C1 && C2) || (C1 && !C2))
            {
                if (acc == 0)
                {
                    situ = "Orange";
                }
                else if (acc == 1)
                {
                    situ = "Rouge";
                }
                else
                {
                    situ = "Refusé";
                }
            }
            else
            {
                if (acc == 0)
                {
                    situ = "Vert";
                }
                else if (acc == 1)
                {
                    situ = "Orange";
                }
                else if (acc == 2)
                {
                    situ = "Rouge";
                }
                else
                {
                    situ = "Refusé";
                }
            }
            if (C3)
            {
                if (situ == "Rouge")
                {
                    situ = "Orange";
                }
                else if (situ == "Orange")
                {
                    situ = "Vert";
                }
                else if (situ == "Vert")
                {
                    situ = "Bleu";
                }
            }
            return "Votre situation :" + situ;
        }
        public static void Date()
        {
            int Jour, Mois, Année;
            bool C1, C2, C3, C4, C;
            int Test1, Test2, Test3;

            Console.WriteLine("Entrez le numéro du jour");
            Jour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le numéro du mois");
            Mois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez l'année");
            Année = Convert.ToInt32(Console.ReadLine());
            Test1 = Année % 100;
            Test2 = Année % 400;
            Test3 = Année % 4;

            if (Test2 == 0 || (Test3 == 0 && Test1 != 0))
                C = true;
            else
                C = false;
            C1 = (Mois == 1 || Mois == 3 || Mois == 5 || Mois == 7 || Mois == 8 || Mois == 10 || Mois == 12) && (Jour >= 1 && Jour <= 31);
            C2 = (Mois == 4 || Mois == 6 || Mois == 9 || Mois == 11) && (Année >= 1 && Année <= 31);
            C3 = Mois == 2 && C && Jour >= 1 && Jour <= 29;
            C4 = Mois == 2 && Jour >= 1 && Jour <= 28;

            if (C1 || C2 || C3 || C4)
            {
                Console.WriteLine("Date valide");
            }
            else
            {
                Console.WriteLine("Date non valide");
            }
        }
        public static void NombreBetween()
        {
            int Nombre = 0;
            Console.WriteLine("Entrez un nombre entre 1 et 3");
            while (Nombre < 1 || Nombre > 3)
            {
                Nombre = Convert.ToInt32(Console.ReadLine());
                if (Nombre < 1 || Nombre > 3)
                {
                    Console.WriteLine("Saisie erronée. Recommencez");
                }
            }
        }
        public static void ValeurBetween()
        {
            int Valeur = 0;
            Console.WriteLine("Entrez un nombre entre 10 et 20");
            while (Valeur < 10 || Valeur > 20)
            {
                Valeur = Convert.ToInt32(Console.ReadLine());
                if (Valeur < 10)
                {
                    Console.WriteLine("Plus grand !");
                }
                else if (Valeur > 20)
                {
                    Console.WriteLine("Plus petit !");
                }
            }
        }
        public static void DixNombresSuivantes()
        {
            int Nombre, i;
            Console.WriteLine("Entrez un nombre : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            i = 0;
            Console.WriteLine("Les 10 nombres suivants sont : ");
            while (i < 10)
            {
                i = i + 1;
                Console.WriteLine(Nombre + i);
            }
        }
        public static void DixNombreSuivante()
        {
            int Nombre;
            Console.WriteLine("Entrez un nombre : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Les 10 nombres suivants sont : ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Nombre + i);
            }
        }
        public static void TableMultiplication()
        {
            int Nombre;
            Console.WriteLine("Entrez un nombre : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La table de multiplication de ce nombre est : ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Nombre + " x " + i + " = " + Nombre * i);
            }
        }
        public static void SommeSuivi()
        {
            int Nombre, Somme;
            Console.WriteLine("Entrez un nombre : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Somme = 0;
            for (int i = 1; i <= Nombre; i++)
            {
                Somme = Somme + i;
            }
            Console.WriteLine("La somme est : " + Somme);
        }
        public static void Factorielle()
        {
            int Nombre, Factorielle;
            Console.WriteLine("Entrez un nombre : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Factorielle = 1;
            for (int i = 2; i <= Nombre; i++)
            {
                Factorielle = Factorielle * i;
            }
            Console.WriteLine("La factorielle est : " + Factorielle);
        }
        public static void PlusGrandValeur()
        {
            int Nombre, PlusGrand, IPlusGrand;
            PlusGrand = 0;
            IPlusGrand = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Entrez un valeur " + (i));
                Nombre = Convert.ToInt32(Console.ReadLine());
                if (i == 1 || Nombre > PlusGrand)
                {
                    PlusGrand = Nombre;
                    IPlusGrand = i;
                }
            }
            Console.WriteLine("Le nombre le plus grand était : " + PlusGrand);
            Console.WriteLine("Il a été saisi en position numéro " + IPlusGrand);
        }
        public static void PrixAchats()
        {
            int E, somdue, M, Reste, Nb10E, Nb5E;
            E = 1;
            somdue = 0;
            while (E != 0)
            {
                Console.WriteLine("Entrez le montant : ");
                E = Convert.ToInt32(Console.ReadLine());
                somdue = somdue + E;
            }
            Console.Write("Vous devez :" + somdue + " euros ,");
            Console.WriteLine("Montant versé :");
            M = Convert.ToInt32(Console.ReadLine());
            Reste = M - somdue;
            Nb10E = 0;
            while (Reste >= 10)
            {
                Nb10E = Nb10E + 1;
                Reste = Reste - 10;
            }
            Nb5E = 0;
            if (Reste >= 5)
            {
                Nb5E = 1;
                Reste = Reste - 5;
            }
            Console.WriteLine("Rendu de la monnaie :");
            Console.WriteLine("Billets de 10 E : " + Nb10E);
            Console.WriteLine("Billets de  5 E : " + Nb5E);
            Console.WriteLine("Pièces de 1 E : " + Reste);
        }
        public static void Tierce()
        {
            int partants, joués, X, Y;
            Console.WriteLine("Entrez le nombre de chevaux partants : ");
            partants = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le nombre de chevaux joués : ");
            joués = Convert.ToInt32(Console.ReadLine());
            X = 1;
            Y = 1;
            for (int i = 1; i <= joués; i++)
            {
                X = X * (i + partants - joués);
                Y = Y * i;
            }
            Console.WriteLine("Dans l’ordre, une chance sur " + X);
            Console.WriteLine("Dans le désordre, une chance sur " + X / Y);
        }
        public static void RemplissageTableau0()
        {
            int[] Truc = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Truc[i] = 0;
            }
        }
        public static void RemplissageTableauVoyelles()
        {
            string[] Voyelles = new string[6];
            Voyelles[0] = "a";
            Voyelles[1] = "e";
            Voyelles[2] = "i";
            Voyelles[3] = "o";
            Voyelles[4] = "u";
            Voyelles[5] = "y";
        }
        public static void RemplissageNotes()
        {
            int[] Notes = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Entrez la note numéro " + (i + 1));
                Notes[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void RemplissageTableaux()
        {
            int[] Nombre = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Nombre[i] = i * i;
                Console.WriteLine(Nombre[i]);
            }
        }
        public static void RemplirTableauImpair()
        {
            int[] Impair = new int[7];
            Impair[0] = 1;
            Console.WriteLine(Impair[0]);
            for (int i = 1; i < 7; i++)
            {
                Impair[i] = Impair[i - 1] + 2;
                Console.WriteLine(Impair[i]);
            }
        }
        public static void TableauSuites()
        {
            int[] Suite = new int[8];
            Suite[0] = 1;
            Suite[1] = 1;
            for (int i = 2; i < 8; i++)
            {
                Suite[i] = Suite[i - 1] + Suite[i - 2];
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(Suite[i]);
            }
        }
        public static void Moyenne()
        {
            int[] Notes = new int[8];
            int somme = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Entrez la note numéro " + (i + 1));
                Notes[i] = Convert.ToInt32(Console.ReadLine());
                somme = somme + Notes[i];
            }
            Console.WriteLine("Moyenne :" + (somme / 8));
        }
        public static void Signes_Nombres()
        {
            int Nombre, NombrePositive, NombreNegatif;
            int[] Tableau;
            Console.WriteLine("Entrez le nombre de valeurs :");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Tableau = new int[Nombre];
            NombrePositive = 0;
            NombreNegatif = 0;
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tableau[i] = Convert.ToInt16(Console.ReadLine());
                if (Tableau[i] > 0)
                {
                    NombrePositive = NombrePositive + 1;
                }
                else
                {
                    NombreNegatif = NombreNegatif + 1;
                }
            }
            Console.WriteLine("Nombre de valeurs positives : " + NombrePositive);
            Console.WriteLine("Nombre de valeurs négatives : " + NombreNegatif);
        }
        public static void SommeTableau()
        {
            int Somme, Nombre;
            int[] Tableau;
            Console.WriteLine("Entrez le nombre de valeurs :");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Tableau = new int[Nombre];
            Somme = 0;
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tableau[i] = Convert.ToInt32(Console.ReadLine());
                Somme = Somme + Tableau[i];
            }
            Console.WriteLine("Somme des éléments du tableau : " + Somme);
        }
        public static void Somme_Entre_Deux_Tab()
        {
            int Nombre;
            int[] Tab1;
            int[] Tab2;
            int[] Tab3;
            Console.WriteLine("Entrez le nombre de valeurs :");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Tab1 = new int[Nombre];
            Tab2 = new int[Nombre];
            Tab3 = new int[Nombre];
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tab1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tab2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Tab3[i] = Tab1[i] + Tab2[i];
            }
        }
        public static void Produit_Entre_Deux_Tab()
        {
            int Nombre1, Nombre2, Schtroumpf;
            int[] Tab1;
            int[] Tab2;
            Console.WriteLine("Entrez le nombre de valeurs de tableau 1 :");
            Nombre1 = Convert.ToInt32(Console.ReadLine());
            Tab1 = new int[Nombre1];
            Console.WriteLine("Entrez le nombre de valeurs de tableau 2 :");
            Nombre2 = Convert.ToInt32(Console.ReadLine());
            Tab2 = new int[Nombre2];
            for (int i = 0; i <= Nombre1 - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tab1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= Nombre2 - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tab2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Schtroumpf = 0;
            for (int i = 0; i <= Nombre1 - 1; i++)
            {
                for (int j = 0; j <= Nombre2 - 1; j++)
                {
                    Schtroumpf = Schtroumpf + Tab1[i] * Tab2[j];
                }
            }
            Console.WriteLine("Le schtroumpf est : " + Schtroumpf);
        }
        public static void Augemente()
        {
            int Nombre;
            int[] Tableau;
            Console.WriteLine("Entrez le nombre de valeurs : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Tableau = new int[Nombre];

            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tableau[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Nouveau tableau : ");
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Tableau[i] = Tableau[i] + 1;
                Console.WriteLine(Tableau[i]);
            }
        }
        public static void Recherche()
        {
            int Nombre, PositionMaxi;
            int[] T;
            Console.WriteLine("Entrez le nombre de valeurs : ");
            Nombre = Convert.ToInt32(Console.ReadLine());
            T = new int[Nombre];
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                T[i] = Convert.ToInt32(Console.ReadLine());
            }
            PositionMaxi = 0;
            for (int i = 0; i <= Nombre - 1; i++)
            {
                if (T[i] > T[PositionMaxi])
                {
                    PositionMaxi = i;
                }
            }
            Console.WriteLine("Element le plus grand : " + T[PositionMaxi]);
            Console.WriteLine("Position de cet élément : " + (PositionMaxi + 1));
        }
        public static void Notes_Classe()
        {
            int Nombre, Somme, Moyenne, NombreSuperieur;
            int[] Tableau;
            Console.WriteLine("Entrez le nombre de notes à saisir : ");
            Nombre = Convert.ToInt16(Console.ReadLine());
            Tableau = new int[Nombre];
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tableau[i] = Convert.ToInt16(Console.ReadLine());
            }
            Somme = 0;
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Somme = Somme + Tableau[i];
            }
            Moyenne = Somme / Nombre;
            NombreSuperieur = 0;
            for (int i = 0; i <= Nombre - 1; i++)
            {
                if (Tableau[i] > Moyenne)
                {
                    NombreSuperieur = NombreSuperieur + 1;
                }
            }
            Console.WriteLine(NombreSuperieur + " élèves dépassent la moyenne de la classe");
        }
        public static void Consécutifs()
        {
            int Nombre;
            bool Flag;
            int[] Tableau;
            Console.WriteLine("Entrez le nombre de valeurs :");
            Nombre = Convert.ToInt16(Console.ReadLine());
            Tableau = new int[Nombre];
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tableau[i] = Convert.ToInt16(Console.ReadLine());
            }
            Flag = true;
            for (int i = 1; i <= Nombre - 1; i++)
            {
                if (Tableau[i] != Tableau[i - 1] + 1)
                {
                    Flag = false;
                }
            }
            if (Flag)
            {
                Console.WriteLine("Les nombres sont consécutifs");
            }
            else
            {
                Console.WriteLine("Les nombres ne sont pas consécutifs");
            }
        }
        public static void TriParInsertion()
        {
            int Nombre, PositionMaxi, Changer;
            int[] Tableau;
            Console.WriteLine("Entrez le nombre de valeurs :");
            Nombre = Convert.ToInt32(Console.ReadLine());
            Tableau = new int[Nombre];
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                Tableau[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= Nombre - 2; i++)
            {
                PositionMaxi = i;
                for (int j = i + 1; j <= Nombre - 1;)
                {
                    if (Tableau[j] > Tableau[PositionMaxi])
                    {
                        PositionMaxi = j;
                    }
                }
                DoubleChanger(Tableau[PositionMaxi], Tableau[i]);
            }
        }
        public static void Inverse_Ordre()
        {
            int Nombre, temp;
            int[] t;
            Console.WriteLine("Entrez le nombre de valeurs :");
            Nombre = Convert.ToInt32(Console.ReadLine());
            t = new int[Nombre];
            for (int i = 0; i <= Nombre - 1; i++)
            {
                Console.WriteLine("Entrez le nombre n° " + (i + 1));
                t[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= (Nombre - 1) / 2; i++)
            {
                temp = t[i];
                t[i] = t[Nombre - 1 - i];
                t[Nombre - 1 - i] = temp;
            }
        }
        public static int GetPositifInt32(string message = null)
        {
            int result;
            while (true)
            {
                try
                {
                    Console.Write(message ?? "Veuillez Saisir un nombre positif : ");
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result >= 0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Veuillez entrer un nombre entier");
                }
            }
            return result;
        }
        public static void Supprimer_Valeur()
        {
            int totalValeurs, indexASupprimer;
            int[] tableauInitial;

            totalValeurs = GetPositifInt32("Entrez le nombre de valeurs :");
            tableauInitial = new int[totalValeurs];
            for (int i = 0; i <= totalValeurs - 1; i++)
            {
                tableauInitial[i] = GetPositifInt32("Entrez le nombre n° " + (i + 1));
            }

            indexASupprimer = GetPositifInt32("Rang de la valeur à supprimer ?");
            if (indexASupprimer > totalValeurs - 1)
            {
                Console.WriteLine("Rang invalide. L'application va se terminer.");
                return;
            }

            int[] tableauRedimentionne = new int[totalValeurs - 1];

            int ic = 0;
            for (int i = 0; i <= totalValeurs - 1; i++)
            {
                if (i != indexASupprimer)
                    tableauRedimentionne[ic++] = tableauInitial[i];
            }


            for (int i = 0; i <= tableauRedimentionne.Length; i++)
            {
                Console.WriteLine(tableauRedimentionne[i]);
            }

        }
        public static void Remplissant_Par_0()
        {
            int[,] Tableau = new int[6, 13];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Tableau[i, j] = 0;
                    Console.WriteLine(Tableau[i, j]);
                }
            }
        }
        public static void PlusGrandValeurMulti()
        {
            int[,] Tableau = new int[12, 8];
            int iMax, jMax;
            iMax = 0;
            jMax = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine("Entrer la valeur n°: " + (i + 1) + "." + (j + 1));
                    Tableau[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // recherche la plus grande valeur
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Tableau[i, j] > Tableau[iMax, jMax])
                    {
                        iMax = i;
                        jMax = j;
                    }
                }
            }
            Console.WriteLine("Le plus grand élément est " + Tableau[iMax, jMax]);
            Console.WriteLine("Il se trouve dans la valeur " + (iMax + 1) + "." + (jMax + 1));
        }
        public static void Nombre_Caractere(string Mot)
        {
            int ic = 0;
            while (ic < Mot.Length)
                ic++;
            Console.WriteLine("Ce mot compte " + ic + " lettres");
        }
        public static string Nombre_Mots(string Phrase)
        {
            int Nombres_Mots;
            Nombres_Mots = 0;
            for (int i = 0; i < Phrase.Length; i++)
            {
                if (Phrase.Substring(i, 1) == " ")
                {
                    Nombres_Mots++;
                }
            }
            return "Cette phrase compte " + (Nombres_Mots + 1) + " mots";
        }
        public static string Nombres_Voyelles(string Phrase)
        {
            int Nombres_Voyelles = 0;
            for (int i = 0; i < Phrase.Length; i++)
            {
                if ((Phrase.Substring(i, 1) == "a") || (Phrase.Substring(i, 1) == "e") || (Phrase.Substring(i, 1) == "i")
                 || (Phrase.Substring(i, 1) == "o") || (Phrase.Substring(i, 1) == "u") || (Phrase.Substring(i, 1) == "y"))
                {
                    Nombres_Voyelles++;
                }
            }
            return "Cette phrase compte " + Nombres_Voyelles + " voyelles";
        }
        public static string Supprimer_Caractere(string Phrase)
        {
            string Nouvelle_Phrase;
            int Indice_Caractere_Supprimer;
            Console.WriteLine("Entrez le rang du caractère à supprimer : ");
            Indice_Caractere_Supprimer = Convert.ToInt32(Console.ReadLine());
            Nouvelle_Phrase = Phrase.Remove((Indice_Caractere_Supprimer - 1), 1);
            return "La nouvelle phrase est :" + Nouvelle_Phrase;
        }
        public static void Pair(int Nb)
        {
            if (Nb % 2 == 0)
            {
                Console.WriteLine("Le Nombre est pair");
            }
            else
            {
                Console.WriteLine("Le Nombre est impair");
            }
        }
        public static void AleatoireNumbres()
        {
            Random Nombre = new Random();
            int Glup1 = Nombre.Next(2);
            Console.WriteLine(Glup1);
            int Glup2 = Nombre.Next(-1, 1);
            Console.WriteLine(Glup2);
            double Glup3 = Nombre.Next(135, 165) * 0.01;
            Console.WriteLine(Glup3);
            int Glup4 = Nombre.Next(1, 7);
            Console.WriteLine(Glup4);
            double Glup5 = Nombre.Next(-105, 65) * 0.1;
            Console.WriteLine(Glup5);
            int Glup6 = Nombre.Next(1, 7) + Nombre.Next(1, 7);
            Console.WriteLine(Glup6);
        }
    }
}