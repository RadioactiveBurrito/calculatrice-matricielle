using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI_Calculatrice_Matricielle
{
    static public class SEL
    {
        static public double[,] MéthodeMatriceInverse(double[,] matriceCoefficients, double[,] matriceSolution)
        {
            double[,] iMatrice = BibliothèqueMatrice.Matrice.Inverse(matriceCoefficients);

            return BibliothèqueMatrice.Matrice.Multiplication(iMatrice, matriceSolution);
        }

        static public string[] SELGauss(double[,] matriceCoefficients, double[,] matriceSolution)
        {

            double[,] matriceÉchelon = Gauss(matriceCoefficients, matriceSolution);

            return InterpréterMatriceÉchelon(matriceÉchelon);
        }

        static private string[] InterpréterMatriceÉchelon(double[,] matriceÉchelon)
        {
            int nbVariables = matriceÉchelon.GetLength(1) - 1;
            int rangMatriceÉchelon = CalculerRangMatrice(matriceÉchelon);
            int rangMatriceSolution = CalculerRangMatrice(BibliothèqueMatrice.Matrice.ConvertirEnTableau(BibliothèqueMatrice.Matrice.RetirerColonnes(0, nbVariables - 1, BibliothèqueMatrice.Matrice.ConvertirEnListe(matriceÉchelon))));
            int rangMatriceCoefficients = CalculerRangMatrice(BibliothèqueMatrice.Matrice.ConvertirEnTableau(BibliothèqueMatrice.Matrice.RetirerColonnes(nbVariables, nbVariables, BibliothèqueMatrice.Matrice.ConvertirEnListe(matriceÉchelon))));
            int nbÉquations = matriceÉchelon.GetLength(0);


            //Vérifier pour aucune solution.
            if (rangMatriceÉchelon > rangMatriceCoefficients)
            {
                return null;
            }
            //Vérifier pour une infinité de solutions.
            if (((rangMatriceCoefficients == rangMatriceÉchelon) && (rangMatriceCoefficients < nbVariables)))
            {
                return CalculerInfinitéSolutions(matriceÉchelon, nbVariables, rangMatriceCoefficients);
            }
            //pour une solution unique
            else
            {
                return CalculerSolutionUnique(matriceÉchelon, nbVariables);
            }

        }

        static string[] CalculerSolutionUnique(double[,] matriceÉchelon, int nbVariables)
        {
            string[] solutionFinale = new string[nbVariables];
            double[] solutions = new double[nbVariables];

            int dimensionX = matriceÉchelon.GetLength(1);
            int dimensionY = matriceÉchelon.GetLength(0);
            solutions[nbVariables - 1] = matriceÉchelon[dimensionY - 1, nbVariables] / matriceÉchelon[dimensionY - 1, nbVariables - 1];

            for (int r = dimensionY - 2; r >= 0; r--)
            {
                for (int c = nbVariables - 1; c > r; c--)
                {
                    matriceÉchelon[r, nbVariables] -= matriceÉchelon[r, c] * solutions[c];
                }
                solutions[r] = matriceÉchelon[r, nbVariables];
                solutions[r] /= matriceÉchelon[r, r];
            }

            for (int i = 0; i < solutionFinale.Length; i++)
                solutionFinale[i] = "X" + i + " = " + solutions[i];


            return solutionFinale;
        }

        static string[] CalculerInfinitéSolutions(double[,] matriceÉchelon, int nbVariables, int rang)
        {
            string[] solutions = new string[nbVariables];

            int nbColonne = matriceÉchelon.GetLength(1);
            int nbRanger = matriceÉchelon.GetLength(0);
            int nbParamêtres = nbVariables - rang;
            string[] paramêtres = new string[nbParamêtres];

            for (int p = 0; p < paramêtres.Length; ++p)
            {
                paramêtres[p] = "t" + (p + 1);
            }

            int variable = nbVariables - 1;
            //for (int p = 0; p < paramêtres.Length; ++p)
            //{
            //   solutions[variable] = paramêtres[p];
            //   variable--;
            //}

            for (int l = (nbRanger - 1) - nbParamêtres; l >= 0; --l)
            {
                for (int c = matriceÉchelon.GetLength(1) - 2; c >= 0; --c)
                {
                    if ((c + 1) == matriceÉchelon.GetLength(1) - 1)
                    {
                        if (matriceÉchelon[l, c + 1] != 0)
                            solutions[l] += matriceÉchelon[l, c + 1];
                    }
                    if (EstDansLaDiagonale(l, c))
                    {
                        if (matriceÉchelon[l, c] != 1 && matriceÉchelon[l, c] != 0)
                            solutions[l] = "(" + solutions[l] + ")" + "/" + matriceÉchelon[l, c];
                        c = -1;
                    }
                    else if (matriceÉchelon[l, c] != 0)
                    {
                        solutions[l] += "-" + matriceÉchelon[l, c] + "*" + solutions[c];
                    }
                }
            }
            for (int i = 0; i < solutions.Length; i++)
            {
                if (i == (solutions.Length - 1))
                    solutions[i] = "X" + (i + 1) + " = " + solutions[i];
                else
                    solutions[i] = "X" + (i + 1) + " = " + solutions[i];
            }

            solutions = new string[1];
            solutions[0] = "Infinité de solutions";
            return solutions;
        }

        static bool EstDansLaDiagonale(int l, int c)
        {
            return l == c;
        }

        static int CalculerRangMatrice(double[,] matrice)
        {
            int nbDeLigne = matrice.GetLength(0);
            int nbDeColonne = matrice.GetLength(1);
            int rang = 0;
            bool rangAAugmenter = true;

            for (int j = 0; j < nbDeLigne; ++j)
            {
                for (int i = 0; i < nbDeColonne; ++i)
                {
                    if (matrice[j, i] != 0)
                    {
                        int k = j + 1;
                        while (k < nbDeLigne)
                        {
                            rangAAugmenter = rangAAugmenter && matrice[k, i] == 0;
                            ++k;
                        }
                        if (rangAAugmenter)
                        {
                            rang++;
                        }
                        else if (j == nbDeLigne - 1)
                        {
                            rang++;
                        }
                        rangAAugmenter = true;
                        i = nbDeColonne;
                    }
                }
            }
            return rang;
        }

        static public double[,] Gauss(double[,] matriceCoefficients, double[,] matriceSolution)
        {
            double[,] matriceÉchelon = BibliothèqueMatrice.Matrice.Concaténation(matriceCoefficients, matriceSolution);
            int dimensionXMatriceÉchelon = matriceÉchelon.GetLength(1);
            int dimensionYMatriceÉchelon = matriceÉchelon.GetLength(0);
            int dimensionXMatriceCoefficients = matriceCoefficients.GetLength(1);
            int dimensionYMatriceCoefficients = matriceCoefficients.GetLength(0);

            double coefficient;
            double terme;

            int s = 0;
            for (int c = 0; c < dimensionXMatriceÉchelon; c++)
                for (int r = c + 1; r < dimensionYMatriceÉchelon; r++)
                {
                    int m = 0;
                    double[,] tempon = new double[dimensionYMatriceÉchelon, dimensionXMatriceÉchelon];
                    for (int l = 0; l < dimensionYMatriceÉchelon; ++l)
                    {
                        for (int C = 0; C < dimensionXMatriceÉchelon; ++C)
                        {
                            tempon[l, C] = matriceÉchelon[l, C];
                        }
                    }

                    while (matriceÉchelon[c, c] == 0)
                    {
                        if (dimensionYMatriceÉchelon - m - 1 > c)
                            matriceÉchelon = BibliothèqueMatrice.Matrice.ÉchangerRangées(c, dimensionYMatriceÉchelon - m - 1, matriceÉchelon);
                        else
                        {
                            return tempon;
                        }
                        ++m;
                    }
                    coefficient = (-matriceÉchelon[r, c] / matriceÉchelon[c, c]);
                    for (int k = 0; k < dimensionXMatriceÉchelon; k++)
                    {
                        terme = coefficient * matriceÉchelon[c, k];
                        matriceÉchelon[r, k] += terme;
                    }
                    s++;
                }

            return matriceÉchelon;
        }
        static public double[,] EstLigneNull(double[,] matriceEchellon)
        {
            List<int> indexLignesNull = new List<int>();
            for (int l = 0; l < matriceEchellon.GetLength(0); ++l)
            {
                double p = 1;
                for (int c = 0; c < matriceEchellon.GetLength(1); ++c)
                {
                    p *= matriceEchellon[l, c];
                }
                if (p == 0)
                {

                }
            }
            return null;
        }

    }
}
