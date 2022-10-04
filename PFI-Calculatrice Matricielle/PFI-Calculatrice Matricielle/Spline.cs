using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierXNA
{
    public static class Spline
    {
        class OpérationNonDéfinieException : ApplicationException { }
        public double[] GénérerSplineFermée(double[] PtsCourbe)
        {
            List<double[,]> matrices = GénérerSEL(PtsCourbe);
            double[,] matriceCoefficients = matrices[0];
            double[,] matriceSolution = matrices[1];
            double[,] matriceÉchelon = Gauss(matriceCoefficients, matriceSolution);

            return CalculerSolutionUnique(matriceÉchelon, matriceÉchelon.GetLength(1) - 1);
        }


        public List<double[,]> GénérerSEL(double[] ptsCourbe)
        {
            List<double[,]> matrices = new List<double[,]>();
            int degréDeSpline = 3; 
            int nbPts = ptsCourbe.Length;
            int nbSplines = (nbPts+1)/degréDeSpline;
            double[,] matriceCoefficients = new double[4*nbPts - 4,nbSplines];//Définir les dimensions plus tard.
            double[,] matriceSolution = new double[4*nbPts - 4,1];



            int[] coefficientsDérivéePremière = { 0, 1 , 2 , 3 };//avec t à partir du 2.
            int[] coefficientsDérivéeSeconde = { 0, 0, 2, 6 };//avec t à partir du 2.



            //Création des trois premières rangées. Vraie pour toute les splines, peu importe le nombre de polynômes.
            for (int j = 0; j < degréDeSpline;++j)
                for (int i = j; i < ptsCourbe.Length; i += degréDeSpline)
                {
                    matriceSolution[i, 0] += ptsCourbe[i];
                    //Gérer le i.Vérifier si bon.
                    matriceCoefficients[j, i] = Math.Pow(j,i-4*(i/4));
                }

            //Conditions sur la première dérivée. (Pn'(t) = Pn+1'(t)). Pour une spline
            //construite avec n points, il y a (n-P) conditions sur la dérivée première, P étant le
            //nombre de polynômes.
            int conditionSurK = nbSplines/2;//vérifier si impair
            int conditionSurRangée = nbSplines*2;
            for (int k = 0; k < conditionSurK;k+=4)
            {
                for (int r = degréDeSpline; r < conditionSurRangée; ++r)//Modifier pour parcourir juste sur le nombre de conditions de dérivée.
                {
                    for (int c = k; c < k + 8; ++c)
                    {
                        if(k < 4)
                            matriceCoefficients[r, c] = coefficientsDérivéePremière[c - 4 * (c / 4)];//Modifier le c pour convenir au besoin de la génération sur 4 facteurs.
                        else
                            matriceCoefficients[r, c] = -1*coefficientsDérivéePremière[c - 4 * (c / 4)];//Modifier le c pour convenir au besoin de la génération sur 4 facteurs.
                    }
                    matriceSolution[r, 0] = 0;
                }
            }
                
             //Conditions sur la deuxième dérivée.(Pn''(t) = Pn+1''(t)). Pour une spline
             //construite avec n points, il y a (n-P) conditions sur la dérivée première, P étant le
             //nombre de polynômes.
            for (int k = 0; k < conditionSurK;k+=4)
            {
                for (int r = degréDeSpline + conditionSurRangée; r < 2*conditionSurRangée+degréDeSpline; ++r)
                {
                    for (int c = k; c < k + 8; ++c)
                    {
                        if (k < 4)
                            matriceCoefficients[r, c] = coefficientsDérivéeSeconde[c - 4 * (c / 4)];//Modifier le c pour convenir au besoin de la génération sur 4 facteurs.
                        else
                            matriceCoefficients[r, c] = -1 * coefficientsDérivéeSeconde[c - 4 * (c / 4)];//Modifier le c pour convenir au besoin de la génération sur 4 facteurs.
                    }
                    matriceSolution[r, 0] = 0;
                }
            }
               

            matrices.Add(matriceCoefficients);
            matrices.Add(matriceSolution);

            return matrices;
        }


        static int CalculerFactorielle(int n)
        {
            int k = 1;
            for(int i = 1; i <= n;++i)
            {
                k *= i;
            }
            return k;
        }

        static public double[,] Gauss(double[,] matriceCoefficients, double[,] matriceSolution)
        {
            double[,] matriceÉchelon = Concaténation(matriceCoefficients, matriceSolution);
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
                            matriceÉchelon = ÉchangerRangées(c, dimensionYMatriceÉchelon - m - 1, matriceÉchelon);
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

        static double[] CalculerSolutionUnique(double[,] matriceÉchelon, int nbVariables)
        {
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

            return solutions;
        }

        static public double[,] Concaténation(double[,] matriceA, double[,] matriceB)
        {
            if (EstConcaténationNonDéfinie(matriceA, matriceB))
                throw new OpérationNonDéfinieException();

            int dimensionYNouvelleMatrice = matriceA.GetLength(0);
            int dimensionXNouvelleMatrice = matriceA.GetLength(1) + matriceB.GetLength(1);

            double[,] matriceC = new double[dimensionYNouvelleMatrice, dimensionXNouvelleMatrice];

            //Ajout des éléments de la matrice A.
            for (int c = 0; c < matriceA.GetLength(1); c++)
                for (int r = 0; r < dimensionYNouvelleMatrice; r++)
                    matriceC[r, c] = matriceA[r, c];

            //Ajout des éléments de la matrice B.
            for (int c = matriceA.GetLength(1); c < dimensionXNouvelleMatrice; c++)
                for (int r = 0; r < dimensionYNouvelleMatrice; r++)
                    matriceC[r, c] = matriceB[r, c - matriceA.GetLength(1)];
            return matriceC;
        }

        static public double[,] ÉchangerRangées(int rangéeA, int rangéeB, double[,] matrice)//À DÉBUGGER
        {
            int dimensionY = matrice.GetLength(0);
            int dimensionX = matrice.GetLength(1);
            double[,] tableauTampon = new double[2, dimensionX];


            for (int i = 0; i < dimensionX; i++)
            {
                tableauTampon[0, i] = matrice[rangéeA, i];
                tableauTampon[1, i] = matrice[rangéeB, i];
            }
            for (int i = 0; i < dimensionX; i++)
            {
                matrice[rangéeA, i] = tableauTampon[1, i];
                matrice[rangéeB, i] = tableauTampon[0, i];
            }


            return matrice;
        }

        static public bool EstConcaténationNonDéfinie(double[,] matriceA, double[,] matriceB)
        {
            return matriceA.GetLength(0) != matriceB.GetLength(0);
        }

    }
}
