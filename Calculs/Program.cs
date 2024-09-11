using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            START:
                choix = 1;
                while (choix != 0)
                {
                    // affiche le menu et saisi le choix
                    Console.WriteLine("Addition ....................... 1");
                    Console.WriteLine("Multiplication ................. 2");
                    Console.WriteLine("Quitter ........................ 0");
                    Console.Write("Choix :                          ");
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez entrer un nombre valide !");
                        goto START;
                    }
                // traitement des choix
                if (choix != 0)
                {
                    switch (choix)
                    {
                        case 1:
                            // choix de l'addition
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            reponse = 0;
                            while(reponse == 0)
                            {
                                try
                                {
                                    Console.Write(val1 + " + " + val2 + " = ");
                                    reponse = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Veuillez donner un nombre entier valide !");
                                }
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 + val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            }
                            break;

                        case 2:
                            // choix de la multiplication
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            reponse = 0;
                            while(reponse == 0)
                            {
                                try
                                {
                                    Console.Write(val1 + "x" + val2 + "= ");
                                    reponse = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Veuillez donner un entier valide");
                                }
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 * val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            }
                            break;

                        default:
                            Console.WriteLine("Veuillez entrer un nombre valide");
                            goto START;
                    }
                }
            }
        }
    }
}
