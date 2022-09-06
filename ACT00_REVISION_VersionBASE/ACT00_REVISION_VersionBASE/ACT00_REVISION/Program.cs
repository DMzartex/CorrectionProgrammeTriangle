using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            string methode = "";
            string infos = "";
            MethodesDuProjet MesOutils = new MethodesDuProjet();
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);

                MesOutils.OrdonneCotes(ref c1, ref c2, ref c3);
                // ordonner les côtés => APPEL ORDONNECOTES
                // ...
                // série de test (voir consignes)
                if (MesOutils.Triangle( c1, c2, c3, ref methode))
                {
                    ok = MesOutils.Triangle(c1, c2, c3, ref methode);
                    MesOutils.Affiche(out infos, ok, methode);

                    Console.WriteLine(infos);

                    // vérification équilatéral
                    if (MesOutils.Equi(c1,c2,c3, ref methode))
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        // ...
                        // ...
                        ok = MesOutils.Equi(c1, c2, c3, ref methode);
                        MesOutils.Affiche(out infos, ok, methode);

                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (MesOutils.TriangleRectangle(c1,c2,c3,ref methode))
                        {
                            ok = MesOutils.TriangleRectangle(c1, c2, c3, ref methode);
                            MesOutils.Affiche(out infos, ok, methode);
                        }
                        else
                        {
                            ok = false;
                            MesOutils.Affiche(out infos, ok, methode);
                           
                        }

                        if (MesOutils.Isocele(c1, c2, c3, ref methode))
                        {
                            ok = MesOutils.Isocele(c1, c2, c3, ref methode);
                            MesOutils.Affiche(out infos, ok, methode);
                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    MesOutils.Affiche(out infos, ok, methode);
                }

                Console.WriteLine(infos);
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
