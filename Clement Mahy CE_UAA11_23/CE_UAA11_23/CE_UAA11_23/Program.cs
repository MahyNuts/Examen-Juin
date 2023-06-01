using System;

namespace CE_UAA11_23
{
    class Program
    {
        static void Main(string[] args)
        {
            sousProgrammes sousP = new sousProgrammes();
            int methode;
            string message;
            string cle;
            char[,] lettreChiffre;
            int a;
            int b;
            char[,] matrice;

            sousP.demandeMethode(out methode);
            if (methode == 1)
            {
                sousP.demandeMessage(out message);
                sousP.demandeCle(out cle);
                matrice = new char[0, 0];
                Console.WriteLine("Pas terminé");


            }
            else
            {
                matrice = new char[3, 25];
                sousP.demandeMessage(out message);
                sousP.lettreChiffreMat(out lettreChiffre);
                sousP.remplissageMatrice2(message, ref matrice);
                sousP.demandeAB(out a, out b);
                for (int i = 0; i < message.Length; i++)
                {
                    for (int j = 0; i < 26; i++)
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
