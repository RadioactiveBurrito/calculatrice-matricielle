using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFI_Calculatrice_Matricielle
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Random générateurAléatoire = new Random();

            //double[,] matriceA = new double[3, 3];
            //double[,] matriceB = new double[2, 1];
            //double[,] matriceC = new double[3, 3];
            //double[,] matriceD = new double[3, 3];
            //double[,] matriceE = new double[5, 6];


            //int nbColonnesA = matriceA.GetLength(0);
            //int nbRangéesA = matriceA.GetLength(1);
            //int nbColonnesB = matriceB.GetLength(0);
            //int nbRangéesB = matriceB.GetLength(1);

            //for (int i = 0; i < nbColonnesA; ++i)
            //{
            //    for (int j = 0; j < nbRangéesA; ++j)
            //    {
            //        matriceA[i, j] = générateurAléatoire.Next(-100, 100);
            //    }
            //}

            //for (int i = 0; i < nbColonnesB; ++i)
            //{
            //    for (int j = 0; j < nbRangéesB; ++j)
            //    {
            //        matriceB[i, j] = générateurAléatoire.Next(-100, 100);
            //    }
            //}


            //matriceA[0, 0] = 1;
            //matriceA[0, 1] = 2;
            //matriceA[0, 2] = 3;
            //matriceA[1, 0] = 2;
            //matriceA[1, 1] = 4;
            //matriceA[1, 2] = 5;
            //matriceA[2, 0] = 1;
            //matriceA[2, 1] = 3;
            //matriceA[2, 2] = 4;

            //List<double[,]> LDV = new List<double[,]>();
            //string[] magie = SEL.SELGauss(matriceA,new double[3,1]);
            //double[,] tamer = BibliothèqueMatrice.Matrice.Multiplication(matriceA, matriceB);
            //string[] tamer = SEL.SELGauss(matriceA, matriceB);
            //LUM = BibliothèqueMatrice.Matrice.LUM(matriceA);
            //LDV = BibliothèqueMatrice.Matrice.LDV(matriceA);

















































































            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
