using System;
using System.Drawing;

namespace PFI_Calculatrice_Matricielle
{
    public class Vecteur
    {
        public double[,] Composantes { get; set; }

        public double Norme
        {
            get
            {
                return CalculerNorme();
            }
        }

        double CalculerNorme()
        {
            double norme = 0;
            for (int i = 0; i < Composantes.GetLength(0); ++i)
            {
                norme += (double)Math.Pow(Composantes[i, 0], 2);
            }
            return (double)Math.Sqrt(norme);
        }


        public Vecteur(Point pts1, Point pts2)
        {
            double[,] composantes = new double[2, 1] { { pts2.X - pts1.X }, { pts2.Y - pts1.Y } };

            InitialiserComposantes(composantes);
        }

        public Vecteur(double[,] composantes)
        {
            InitialiserComposantes(composantes);
        }

        void InitialiserComposantes(double[,] composantes)
        {
            Composantes = new double[composantes.GetLength(0), composantes.GetLength(1)];

            for (int i = 0; i < composantes.GetLength(0); ++i)
                Composantes[i, 0] = composantes[i, 0];
        }

        public double[,] Normaliser()
        {
            double[,] VecteurNormaliser = new double[Composantes.GetLength(0), Composantes.GetLength(1)];
            for (int i = 0; i < Composantes.GetLength(0); ++i)
            {
                VecteurNormaliser[i, 0] = Composantes[i, 0] / Norme;
            }
            return VecteurNormaliser;
        }

        static public Vecteur operator *(double k, Vecteur v)
        {
            double[,] VecteurRésultant = new double[v.Composantes.GetLength(0), v.Composantes.GetLength(1)];
            for (int i = 0; i < v.Composantes.GetLength(0); ++i)
            {
                VecteurRésultant[i, 0] = v[i] * k;
            }
            return new Vecteur(VecteurRésultant);
        }

        static public Vecteur operator +(Vecteur v1, Vecteur v2)
        {
            double[,] VecteurRésultant = new double[v1.Composantes.GetLength(0), v1.Composantes.GetLength(1)];
            for (int i = 0; i < v1.Composantes.GetLength(0); ++i)
            {
                VecteurRésultant[i, 0] = v1[i] + v2[i];
            }
            return new Vecteur(VecteurRésultant);
        }

        static public Vecteur operator -(Vecteur v1, Vecteur v2)
        {
            return v1 + (-1 * v2);
        }

        static public Vecteur VecteurDansBaseB(Vecteur vecteur, Vecteur[] Base)
        {
            int nbDeComposantes = vecteur.Composantes.GetLength(1);
            int nbDeVecteurBase = Base.Length;

            if (EstUneBase(Base, nbDeComposantes))
            {
                double[,] matrice = BibliothèqueMatrice.Matrice.Concaténation(Base[0].Composantes, Base[1].Composantes);
                for (int i = 2; i < nbDeVecteurBase; ++i)
                {
                    matrice = BibliothèqueMatrice.Matrice.Concaténation(matrice, Base[i].Composantes);
                }

                return new Vecteur(BibliothèqueMatrice.Matrice.Multiplication(BibliothèqueMatrice.Matrice.Inverse(matrice), BibliothèqueMatrice.Matrice.Transposée(vecteur.Composantes)));
            }
            else
                return null;
        }

        public double this[int index]
        {
            get
            {
                return Composantes[index, 0];
            }
            set
            {
                Composantes[index, 0] = value;
            }
        }

        static public bool EstUneBase(Vecteur[] Base, int n)
        {
            int nbVecteurs = Base.Length;
            double déterminant;
            if (nbVecteurs < n)
            {
                return false;
            }
            for (int i = 0; i < nbVecteurs; ++i)
            {
                if (Base[i].Composantes.GetLength(0) != n)
                {
                    return false;
                }
            }

            double[,] matrice = BibliothèqueMatrice.Matrice.Concaténation(Base[0].Composantes, Base[1].Composantes);
            for (int i = 2; i < nbVecteurs; ++i)
            {
                matrice = BibliothèqueMatrice.Matrice.Concaténation(matrice, Base[i].Composantes);
            }

            déterminant = BibliothèqueMatrice.Matrice.Déterminant(matrice);

            if (déterminant == 0)
            {
                return false;
            }

            return true;
        }


    }
}

