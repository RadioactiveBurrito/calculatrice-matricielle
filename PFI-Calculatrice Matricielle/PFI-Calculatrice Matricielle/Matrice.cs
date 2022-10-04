using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothèqueMatrice
{
    #region Exceptions de la classe Matrice
    class OpérationNonDéfinieException : ApplicationException { }
    class InverseNonDéfinieException : ApplicationException { }
    class HorsDeLaMatriceException : ApplicationException { }
    #endregion
    static public class Matrice
    {
        #region Opérateurs binaires
        static public double[,] Multiplication(double[,] matriceA, double[,] matriceB)
        {
            if (EstMultiplicationNonDéfinie(matriceA, matriceB))
                throw new OpérationNonDéfinieException();

            int nbColonnesA = matriceA.GetLength(1);
            int nbRangéesA = matriceA.GetLength(0);

            int nbColonnesB = matriceB.GetLength(1);
            int nbRangéesB = matriceB.GetLength(0);

            double[,] matriceC = new double[nbRangéesA, nbColonnesB];


            for (int i = 0; i < nbRangéesA; ++i)
                for (int j = 0; j < nbColonnesB; ++j)
                    for (int k = 0; k < nbColonnesA; ++k)
                        matriceC[i, j] += matriceB[k, j] * matriceA[i, k];

                    return matriceC;
        }

        static public double[,] FauxProduit(double[,] matriceA, double[,] matriceB)
        {
            int dimensionY = matriceA.GetLength(0);
            int dimensionX = matriceA.GetLength(1);
            if(dimensionY != matriceB.GetLength(0) || dimensionX != matriceB.GetLength(1))
                throw new OpérationNonDéfinieException();

            double[,] produit = new double[dimensionY,dimensionX];

            for (int c = 0; c < dimensionX; c++)
                for (int r = 0; r < dimensionY; r++)
                    produit[r, c] = matriceA[r, c] * matriceB[r, c];

                    return produit;
        }

        static public double[,] Addition(double[,] matriceA, double[,] matriceB)
        {
            if (EstAdditionNonDéfinie(matriceA, matriceB))
                throw new OpérationNonDéfinieException();

            int nbRangéesA = matriceA.GetLength(0);
            int nbColonnesA = matriceA.GetLength(1);

            int nbColonnesB = matriceB.GetLength(0);
            int nbRangéesB = matriceB.GetLength(1);

            double[,] matriceC = new double[nbRangéesA, nbColonnesA];
            for (int i = 0; i < nbColonnesA; ++i)
                for (int j = 0; j < nbRangéesA; ++j)
                    matriceC[j, i] = matriceA[j, i] + matriceB[j, i];

            return matriceC;
        }

        static public double[,] Soustraction(double[,] matriceA, double[,] matriceB)
        {
            return Addition(matriceA, Scalaire(matriceB, -1));
        }

        static public double[,] Scalaire(double[,] matriceA, double k)
        {
            int nbRangéesA = matriceA.GetLength(0);
            int nbColonnesA = matriceA.GetLength(1);

            double[,] matriceC = new double[nbRangéesA, nbColonnesA];

            for (int i = 0; i < nbRangéesA; ++i)
                for (int j = 0; j < nbColonnesA; ++j)
                    matriceC[i, j] = k * matriceA[i, j];

            return matriceC;
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

        static public List<List<double>> RetirerColonnes(int minColonne, int maxColonne, List<List<double>> matrice)
        {
            if (minColonne < 0 || maxColonne > matrice.ElementAt(0).Count)
                throw new HorsDeLaMatriceException();

            int nbÉlémentsRangée = matrice.Count;
            int nbÉlémentsColonnes = matrice.ElementAt(0).Count;
            for (int r = 0; r < nbÉlémentsRangée; r++)
            {
                matrice.ElementAt(r).RemoveRange(minColonne, (maxColonne - minColonne) + 1);
            }

            return matrice;
        }

        static public List<List<double>> RetirerRangées(int minRangée, int maxRangée, List<List<double>> matrice)
        {
            if (minRangée < 0 || maxRangée > matrice.ElementAt(0).Count)
                throw new HorsDeLaMatriceException();

            for (int r = minRangée; r <= maxRangée; r++)
                matrice.RemoveAt(r);

            return matrice;
        }

        #endregion

        #region Opérateurs unaires
        static public double Déterminant(double[,] matrice)//À DÉBUGGER
        {
            if (EstMatriceNonCarrée(matrice))
                throw new OpérationNonDéfinieException();

            List<Object> décomposition = new List<Object>();

            décomposition = LUM(matrice);
            if (décomposition == null)
                return 0;
            double[,] L = décomposition[1] as double[,];
            int nbÉchangesRangées = (int)décomposition[3];

            double déterminant = 1;
            for (int r = 0; r < matrice.GetLength(0); r++)
                déterminant *= L[r, r];
            if (nbÉchangesRangées % 2 != 0)
                déterminant *= -1;
            return déterminant;
        }

        static public double[,] Puissance(double[,] matrice, int puissance)
        {
            if (EstMatriceNonCarrée(matrice))
                throw new OpérationNonDéfinieException();

            int dimensionA = matrice.GetLength(0);

            double[,] matriceC = new double[dimensionA, dimensionA];
            matriceC = matrice;

            for (int i = 0; i < puissance - 1; ++i)
                matriceC = Multiplication(matriceC, matrice);

            return matriceC;
        }

        static public double[,] Transposée(double[,] matrice)
        {
            int nbColonnesA = matrice.GetLength(1);
            int nbRangéesA = matrice.GetLength(0);

            double[,] matriceC = new double[nbColonnesA, nbRangéesA];

            for (int i = 0; i < nbRangéesA; ++i)
                for (int j = 0; j < nbColonnesA; ++j)
                    matriceC[j, i] = matrice[i, j];

            return matriceC;
        }

        static public double[,] Inverse(double[,] matrice)
        {
            double déterminant = Déterminant(matrice);
            if (EstMatriceNonCarrée(matrice) || déterminant == 0)
                throw new InverseNonDéfinieException();

            int dimensionMatrice = matrice.GetLength(0);
            List<double[,]> décompositionLDV = new List<double[,]>();
            décompositionLDV = LDV(matrice);


            //Si la décomposition LDV n'existe pas.
            if(décompositionLDV == null)
            {
                double[,] iMatrice = new double[dimensionMatrice, dimensionMatrice];
                for (int r = 0; r < dimensionMatrice; r++)
                {
                    for (int c = 0; c < dimensionMatrice; c++)
                    {
                        iMatrice[r, c] = GénérerMineur(matrice, r, c)/déterminant;
                    }
                }

                iMatrice = Transposée(iMatrice);

                return iMatrice;
            }
            else//Si la décomposition LDV Existe.
            {
                double[,] iL = new double[dimensionMatrice, dimensionMatrice];
                double[,] iD = new double[dimensionMatrice, dimensionMatrice];
                double[,] iV = new double[dimensionMatrice, dimensionMatrice];
                double[,] L = new double[dimensionMatrice, dimensionMatrice];
                double[,] D = new double[dimensionMatrice, dimensionMatrice];
                double[,] V = new double[dimensionMatrice, dimensionMatrice];

                
                L = décompositionLDV[0];
                D = décompositionLDV[1];
                V = décompositionLDV[2];

                for (int r = 0; r < dimensionMatrice; r++)
                {
                    iD[r, r] = 1 / D[r, r];
                    for (int c = 0; c < dimensionMatrice; c++)
                    {
                        iL[r, c] = GénérerMineur(L, r, c);
                        iV[r, c] = GénérerMineur(V, r, c);
                    }
                }
                iL = Transposée(iL);
                iV = Transposée(iV);

                return Multiplication(Multiplication(iV, iD), iL);
            }

        }//À DÉBUGGER
        #endregion

        #region Gauss,LU,LDV
        static public List<Object> Gauss(double[,] matriceCoefficients, double[,] matriceSolution)
        {
            double[,] matriceÉchelon = Concaténation(matriceCoefficients, matriceSolution);
            int dimensionXMatriceÉchelon = matriceÉchelon.GetLength(1);
            int dimensionYMatriceÉchelon = matriceÉchelon.GetLength(0);
            int dimensionXMatriceCoefficients = matriceCoefficients.GetLength(1);
            int dimensionYMatriceCoefficients = matriceCoefficients.GetLength(0);
            int dimMin = Math.Min(dimensionXMatriceCoefficients,dimensionYMatriceCoefficients);



            double[] coefficients = new double[(dimMin*dimMin-dimMin)/2];
            int nbÉchangesLignes = 0;
            List<Object> sortie = new List<Object>();

            double coefficient;
            double terme;
            //Opérations sur les rangées.
            int s = 0;
            for (int c = 0; c < dimensionXMatriceÉchelon; c++)
                for (int r = c + 1; r < dimensionYMatriceÉchelon; r++)
                {
                    int m = 0;
                    while (matriceÉchelon[c, c] == 0)//À VÉRIFIER SI ÉCHANGE LES BONNES RANGÉES.
                    {
                        if (m == 0)
                            ++nbÉchangesLignes;
                        if(dimensionYMatriceÉchelon-m-1 > c)
                             matriceÉchelon = ÉchangerRangées(c,dimensionYMatriceÉchelon - m -1,matriceÉchelon);
                        else
                            return null;
                        ++m;
                    }
                    coefficient = (-matriceÉchelon[r, c] / matriceÉchelon[c, c]);
                    coefficients[s] = coefficient;
                    for (int k = 0; k < dimensionXMatriceÉchelon; k++)
                    {
                        terme = coefficient * matriceÉchelon[c, k];
                        matriceÉchelon[r, k] += terme;
                    }
                    s++;
                }

            sortie.Add(matriceÉchelon);
            sortie.Add(coefficients);
            sortie.Add(nbÉchangesLignes);
            return sortie;
        }

        static public List<Object> LUM(double[,] matrice)
        {
            if (EstMatriceNonCarrée(matrice))
                throw new OpérationNonDéfinieException();


            int dimensionMatrice = matrice.GetLength(0);
            List<Object> décomposition = new List<Object>();
            List<Object> gauss = new List<object>();
            double[] coefficients = new double[dimensionMatrice];
            int nbÉchangesRangées;

            double[,] matriceIdentitée = GénérerMatriceIdentitée(dimensionMatrice);
            double[,] U = new double[dimensionMatrice, dimensionMatrice];
            double[,] L = new double[dimensionMatrice, dimensionMatrice];
            double[,] M = new double[dimensionMatrice, dimensionMatrice];
            double[,] matriceAugmentéeUM = new double[2 * dimensionMatrice, 2 * dimensionMatrice];
            L = matriceIdentitée;

            gauss = Gauss(matrice, matriceIdentitée);

            if (gauss == null)
                return null;
            int g = (int)gauss[2];
            if (g != 0)
            {
                return null;
            }

            matriceAugmentéeUM = gauss[0] as double[,];
            coefficients = gauss[1] as double[];
            nbÉchangesRangées = (int)gauss[2];

            U = ConvertirEnTableau(RetirerColonnes(dimensionMatrice, 2 * dimensionMatrice - 1, ConvertirEnListe(matriceAugmentéeUM)));

            M = ConvertirEnTableau(RetirerColonnes(0, dimensionMatrice - 1, ConvertirEnListe(matriceAugmentéeUM)));

            int k = 0;
            for (int c = 0; c < dimensionMatrice; c++)
                for (int r = c + 1; r < dimensionMatrice; r++)
                {
                    L[r, c] -= coefficients[k];
                    ++k;
                }

            //Ajout à la liste.
            décomposition.Add(L);
            décomposition.Add(U);
            décomposition.Add(M);
            décomposition.Add(nbÉchangesRangées);

            return décomposition;
        }

        static public List<double[,]> LDV(double[,] matrice)
        {
            int dimensionMatrice = matrice.GetLength(0);
            List<double[,]> décompositionLDV = new List<double[,]>();
            List<Object> décompositionLU = LUM(matrice);
            double[,] L = new double[dimensionMatrice, dimensionMatrice];
            double[,] D = new double[dimensionMatrice, dimensionMatrice];
            double[,] V = new double[dimensionMatrice, dimensionMatrice];
            double[,] U = new double[dimensionMatrice, dimensionMatrice];
            double[,] Test = new double[dimensionMatrice, dimensionMatrice];

            if ((int)décompositionLU[3] != 0)
                return null;
            //Création de L.
            L = décompositionLU[0] as double[,];
            U = décompositionLU[1] as double[,];
            //Création de D.
            for (int r = 0; r < dimensionMatrice; r++)
                D[r, r] = U[r, r];
            //Création de V.
            for (int r = 0; r < dimensionMatrice; r++)
                for (int c = r; c < dimensionMatrice; c++)
                    V[r, c] = U[r, c] / U[r, r];

            décompositionLDV.Add(L);
            décompositionLDV.Add(D);
            décompositionLDV.Add(V);

            //Test = Multiplication(Multiplication(L, D), V);

            return décompositionLDV;
        }
        #endregion

        #region Génération de matrice
        static public double[,] GénérerMatriceIdentitée(int ordre)
        {
            double[,] matriceIdentitée = new double[ordre, ordre];

            for (int i = 0; i < ordre; i++)
                matriceIdentitée[i, i] = 1;

            return matriceIdentitée;
        }
        #endregion

        #region Booléens
        static public bool EstAdditionNonDéfinie(double[,] matriceA, double[,] matriceB)
        {
            return !((matriceA.GetLength(0) == matriceB.GetLength(0)) && (matriceA.GetLength(1) == matriceB.GetLength(1)));
        }
        static public bool EstMultiplicationNonDéfinie(double[,] matriceA, double[,] matriceB)
        {
            return matriceA.GetLength(1) != matriceB.GetLength(0);
        }
        static public bool EstMatriceNonCarrée(double[,] matrice)
        {
            return matrice.GetLength(0) != matrice.GetLength(1);
        }
        static public bool EstConcaténationNonDéfinie(double[,] matriceA, double[,] matriceB)
        {
            return matriceA.GetLength(0) != matriceB.GetLength(0);
        }
        #endregion

        #region Autres Méthodes

        static public List<List<double>> ConvertirEnListe(double[,] matriceEntrée)
        {
            List<List<double>> matriceSortie = new List<List<double>>();


            for (int r = 0; r < matriceEntrée.GetLength(0); r++)
            {
                List<double> colonne = new List<double>();
                for (int c = 0; c < matriceEntrée.GetLength(1); c++)
                {
                    colonne.Add(matriceEntrée[r, c]);
                }
                matriceSortie.Add(colonne);
            }

            return matriceSortie;
        }

        static public double[,] ConvertirEnTableau(List<List<double>> matriceEntrée)
        {
            double[,] matriceSortie = new double[matriceEntrée.Count, matriceEntrée.ElementAt(0).Count];

            for (int c = 0; c < matriceSortie.GetLength(1); c++)
                for (int r = 0; r < matriceSortie.GetLength(0); r++)
                    matriceSortie[r, c] = matriceEntrée.ElementAt(r).ElementAt(c);

            return matriceSortie;
        }

        static public double GénérerMineur(double[,] matrice, int rangée, int colonne)
        {
            if (EstMatriceNonCarrée(matrice))
                throw new OpérationNonDéfinieException();
            int dimensionMatriceMineur = matrice.GetLength(0) - 1;
            int condition = 1;
            if ((rangée + colonne) % 2 == 1)
                condition = -1;

            double[,] matriceMineur = ConvertirEnTableau(RetirerColonnes(colonne, colonne, RetirerRangées(rangée, rangée, ConvertirEnListe(matrice))));
            double déterminant = Déterminant(matriceMineur);
            if (double.IsNaN(déterminant))
                return 0;
            return déterminant * condition;
        }

        static public double[,] ÉchangerRangées(int rangéeA, int rangéeB, double[,] matrice)//À DÉBUGGER
        {
            int dimensionY = matrice.GetLength(0);
            int dimensionX = matrice.GetLength(1);
            double[,] tableauTampon = new double[2,dimensionX];


            for (int i = 0; i < dimensionX;i++)
            {
                tableauTampon[0,i] = matrice[rangéeA,i];
                tableauTampon[1, i] = matrice[rangéeB, i];
            }
            for (int i = 0; i < dimensionX; i++)
            {
                matrice[rangéeA, i] = tableauTampon[1, i];
                matrice[rangéeB, i] = tableauTampon[0, i];
            }


                return matrice;
        }

        static public double[,] ÉchangerColonnes(int colonneA, int colonneB, double[,] matrice)
        {
            return null;
        }
        #endregion
    }
}