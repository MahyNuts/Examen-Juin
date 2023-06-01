using System;
using System.Collections.Generic;
using System.Text;

namespace CE_UAA11_23
{
    public struct sousProgrammes
    {
        public void demandeMethode(out int methode)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Quelle methode voulez-vous utiliser ?\n1 - Méthode de cryptage de Vigenère\n2 - Methode de chiffre affine ");
                int.TryParse(Console.ReadLine(), out methode);
            } while (methode < 1 || methode > 2);
        }

        public void demandeMessage(out string message)
        {
            do
            {
                Console.Clear();
                Console.Write("Quel est le texte à crypter ? ");
                message = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(message));
        }

        public void demandeCle(out string cle)
        {
            do
            {
                Console.Clear();
                Console.Write("Quel est le mot clé ? ");
                cle = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(cle));
        }

        public void lettreChiffreMat(out char[,] lettreChiffre)
        {
            lettreChiffre = new char[1, 25];
            string lettre = "ABCDEFGHIJKLMNOPQRSTUVWXZ";
            string chiffre = "";
            for(int j = 0; j < 26; j++)
            {
                chiffre = chiffre + (j + 1);
            }
            for(int i = 0; i < 26; i++)
            {
                lettreChiffre[0, i] = lettre[i];
                lettreChiffre[1, i] = chiffre[i];
            }
        }

        public void remplissageMatrice2(string message, ref char[,] matrice)
        {
            for (int i=0; i < message.Length; i++)
            {
                matrice[0, i] = message[i];
            }
        }

        public void demandeAB(out int a, out int b)
        {
            do
            {
                Console.WriteLine("Quelle est la valeur de a ? ");
                int.TryParse(Console.ReadLine(), out a);
            } while (a < 0 || a > 26 || a != 1 || a != 3 || a != 5 || a != 7 || a != 9 || a != 11 || a != 15 || a != 17 || a != 19 || a != 21 || a != 23 || a != 25);
            do
            {
                Console.WriteLine("Quelle est la valeure de b ? ");
                int.TryParse(Console.ReadLine(), out b);
            } while (b < 0 || b > 25);
        }

        public void methode(int methode, string message, string cle, char[,] lettreChiffre, int a, int b, out char[,] matrice)
        {
            if(methode == 1)
            {
                demandeMessage(out message);
                demandeCle(out cle);
                matrice = new char[0, 0];
                Console.WriteLine("Pas terminé");


            }
            else
            {
                matrice = new char[3, 25];
                demandeMessage(out message);
                lettreChiffreMat(out lettreChiffre);
                remplissageMatrice2(message, ref matrice);
                demandeAB(out a, out b);
                for (int i = 0; i < message.Length; i++)
                {
                    for(int j = 0; i < 26; i++)
                    {
                        if (message[j] == lettreChiffre[0, j])
                        {
                            matrice[1, j] = lettreChiffre[1, j];
                            string astring = "";
                            astring = astring + (a * matrice[1, j] + b) % 26;
                            Console.WriteLine(astring);
                            

                        }
                    }
                }
            }
        }
    }
}
