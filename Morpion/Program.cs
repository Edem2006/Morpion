using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués
                                                     // Fonction permettant l'affichage du Morpion

        public static void AfficherMorpion1(int j, int k)
        {
            // A compléter 
            for (j = 0; j < grille.GetLength(0); j++)
            {
                Console.Write("\n|====|====|====|\n");
                Console.Write("|");
                for (k = 0; k < grille.GetLength(1); k++)
                {   
                    Console.Write(" -- ");
                    Console.Write("|");
                }



            }
            Console.Write("\n|====|====|====|\n");
            
        }
        public static void AfficherMorpion2(int j, int k, int joueur, int l, int c)
        {
            for (j = 0; j < grille.GetLength(0); j++)
            {
                Console.Write("\n|====|====|====|\n");
                Console.Write("|");
                for (k = 0; k < grille.GetLength(1); k++)
                {
                    if (joueur == 1)
                    {
                    
                    }
                    if (joueur == 2)
                    {
                        Console.Write(" O   ");
                    }
                }

            }

        }
       

        // Fonction permettant de changer
        // dans le tableau qu'elle est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée

        public static bool AJouer(int j, int k, int joueur)
        {
            // A compléter 
            if (j <= grille.GetLength(0) && k <= grille.GetLength(1))
            {
                if (j % 2 == 0)
                {
                    joueur = 1;
                }
                if (j % 2 != 0)
                {
                    joueur = 2;
                }
                Console.WriteLine("Le joueur qui doit jouer est le joueur : " + joueur);

            }
            return true;
           
        }

        public static void choix(int l, int c,int joueur )
        {
            if( joueur == 1)
            {



            }
            

            
        }
        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {
            // A compléter 
            return false;
        }

        // Programme principal
        static void Main(string[] args)
        {

            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre

            int essais = 0;    // compteur d'essais
            int joueur = 1;   // 1 pour la premier joueur, 2 pour le second
            int l, c = 0;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool gagner = false; // Permet de vérifier si un joueur à gagné 
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible

            //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
            for (j = 0; j < grille.GetLength(0); j++)
                for (k = 0; k < grille.GetLength(1); k++)
                    grille[j, k] = 10;
            for (j = 0; !gagner && essais != 9; j++)
            {
                for (k = 0; !gagner && essais != 9; k++,essais++)
                {

                    
                    AJouer(j, k, joueur);
                    AfficherMorpion1(j, k);
                    // A compléter 
                    try
                    {
                        
                        Console.WriteLine("Ligne   =    ");
                        Console.WriteLine("Colonne =    ");
                        // Peut changer en fonction de comment vous avez fait votre tableau.
                        Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
                        l = int.Parse(Console.ReadLine()) - 1;
                        // Peut changer en fonction de comment vous avez fait votre tableau.
                        Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
                        c = int.Parse(Console.ReadLine()) - 1;
                        

                        // A compléter 
                        Console.Clear();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    // Changement de joueur
                    // A compléter 

                };// Fin TQ

                // Fin de la partie
                // A compléter 
                if (essais == 9 || gagner == true)
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
