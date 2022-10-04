using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFI_Calculatrice_Matricielle
{
    public partial class Form1 : Form
    {
        const int A_LEFT = 52;
        const int A_TOP = 19;
        const int B_LEFT = 361;
        const int B_TOP = 19;
        const int C_LEFT = 672;
        const int C_TOP = 19;

        const int U_LEFT = 2;
        const int U_TOP = 15;
        const int V_LEFT = 2;
        const int V_TOP = 61;
        const int W_LEFT = 2;
        const int W_TOP = 107;
        const int BASE_LEFT = 10;
        const int BASE_TOP = 19;

        const int COEF_LEFT = 6;
        const int COEF_TOP = 18;
        const int CON_LEFT = 219;
        const int CON_TOP = 18;
        const int AUG_LEFT = 274;
        const int AUG_TOP = 18;

        //Les opérateurs.
        string OpérateurSélectionnéMatrice { get; set; }
        string OpérateurSélectionnéSEL { get; set; }
        string OpérateurSélectionnéVecteur { get; set; }


        List<MatriceAffichée> Matrices { get; set; }
        Random GénérateurAléatoire { get; set; }

        MatriceAffichée MatriceA { get; set; }
        MatriceAffichée MatriceB { get; set; }
        MatriceAffichée MatriceC { get; set; }
        MatriceAffichée MatriceCoefficientsSEL { get; set; }
        MatriceAffichée MatriceConstantesSEL { get; set; }
        MatriceAffichée MatriceAugmentéÉchelon { get; set; }

        MatriceAffichée U { get; set; }
        MatriceAffichée V { get; set; }
        MatriceAffichée W { get; set; }
        MatriceAffichée Base {get;set;}

        public Form1()
        {
            InitializeComponent();

            GénérateurAléatoire = new Random();
            MatriceA = new MatriceAffichée(200, 200, 1, 1,"A");
            MatriceB = new MatriceAffichée(200, 200, 1, 1,"B");
            MatriceC = new MatriceAffichée(200, 200, 0, 0, "C");

            MatriceCoefficientsSEL = new MatriceAffichée(200,200,3,3,"Coefficients");
            MatriceConstantesSEL = new MatriceAffichée(40,200,3,1,"Constantes");
            MatriceAugmentéÉchelon = new MatriceAffichée(200,200,3,3,"Échelon");

            U = new MatriceAffichée(100,40,1,2,"U");
            V = new MatriceAffichée(100,40,1,2,"V");
            W = new MatriceAffichée(100,40,1,2,"W");
            Base = new MatriceAffichée(182,162,2,2,"Base");

            PlacerMatricesMatrice();
            PlacerMatricesSELs();
            PlacerMatricesVecteurs();
        }

        private void CalculatriceMatricielle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nbLignesA_TextChanged(object sender, EventArgs e)
        {

        }


        #region Gestion boutons Calculer
        private void BoutonCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                MatriceA.Raffraîchir();
                MatriceB.Raffraîchir();


                if (OpérateurSélectionnéMatrice == BoutonAddition.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Addition(MatriceA.MatriceEnMémoire, MatriceB.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéMatrice == BoutonSoustraction.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Soustraction(MatriceA.MatriceEnMémoire, MatriceB.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéMatrice == BoutonMultiplication.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Multiplication(MatriceA.MatriceEnMémoire, MatriceB.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéMatrice == BoutonFauxProduit.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.FauxProduit(MatriceA.MatriceEnMémoire, MatriceB.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéMatrice == BoutonScalaire.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Scalaire(MatriceA.MatriceEnMémoire, double.Parse(kMatrice.Text)));
                }
                else if (OpérateurSélectionnéMatrice == BoutonInverse.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Inverse(MatriceA.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéMatrice == BoutonDéterminant.Text)
                {
                    labelDet.Text = "Déterminant = " + BibliothèqueMatrice.Matrice.Déterminant(MatriceA.MatriceEnMémoire).ToString();
                }
                else if (OpérateurSélectionnéMatrice == BoutonPuissance.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Puissance(MatriceA.MatriceEnMémoire, int.Parse(nMatrice.Text)));
                }
                else if (OpérateurSélectionnéMatrice == BoutonTransposée.Text)
                {
                    MatriceC.Raffraîchir(BibliothèqueMatrice.Matrice.Transposée(MatriceA.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéMatrice == BoutonLU.Text)
                {
                    List<Object> décomposition = BibliothèqueMatrice.Matrice.LUM(MatriceA.MatriceEnMémoire);
                    if (décomposition != null)
                    {
                        MatriceC.Raffraîchir(décomposition[1] as double[,]);
                        MatriceB.Raffraîchir(décomposition[0] as double[,]);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Une erreur a été détecté. L'opération que vous tenté\n d'effectuer est soit impossible ou la calculatrice possède un bug.");
            }

            MatriceC.Fenêtre.Left = 672;//943
            MatriceC.Fenêtre.Top = 19;//333
            groupeMatrices.Controls.Add(MatriceC.Fenêtre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            U.Raffraîchir();
            V.Raffraîchir();
            Base.Raffraîchir();
            //try
            //{
                if (OpérateurSélectionnéVecteur == vecteurAddition.Text)
                {
                    W.Raffraîchir(BibliothèqueMatrice.Matrice.Addition(U.MatriceEnMémoire, V.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéVecteur == vecteurSoustraction.Text)
                {
                    W.Raffraîchir(BibliothèqueMatrice.Matrice.Soustraction(U.MatriceEnMémoire, V.MatriceEnMémoire));
                }
                else if (OpérateurSélectionnéVecteur == vecteurScalaire.Text)
                {
                    W.Raffraîchir(BibliothèqueMatrice.Matrice.Scalaire(U.MatriceEnMémoire, double.Parse(kVecteur.Text)));
                }
                else if (OpérateurSélectionnéVecteur == vecteurNorme.Text)
                {
                    normeU.Text = "norme U = " + CalculerNorme();
                }
                else if (OpérateurSélectionnéVecteur == vecteurNormalisationU.Text)
                {
                    Normalisation();
                }
                else if (OpérateurSélectionnéVecteur == vecteurEstUneBase.Text)
                {
                    informationBase.Text = CalculerEstUneBase();
                }
                else if (OpérateurSélectionnéVecteur == vecteurDansBaseB.Text)
                {
                    W.Raffraîchir(BibliothèqueMatrice.Matrice.Transposée(BibliothèqueMatrice.Matrice.Multiplication(BibliothèqueMatrice.Matrice.Inverse(Base.MatriceEnMémoire),BibliothèqueMatrice.Matrice.Transposée(U.MatriceEnMémoire))));
                }
                else if(OpérateurSélectionnéVecteur == formerVecteurPoints.Text)
                {
                    W.Raffraîchir(BibliothèqueMatrice.Matrice.Soustraction(V.MatriceEnMémoire,U.MatriceEnMémoire));
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Une erreur a été détecté. L'opération que vous tenté\n d'effectuer est soit impossible ou la calculatrice possède un bug.");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MatriceCoefficientsSEL.Raffraîchir();
            MatriceConstantesSEL.Raffraîchir();
            try
            {
                if (OpérateurSélectionnéSEL == Gauss.Text)
                {
                    MatriceAugmentéÉchelon.Raffraîchir(SEL.Gauss(MatriceCoefficientsSEL.MatriceEnMémoire, MatriceConstantesSEL.MatriceEnMémoire));
                    string[] s = SEL.SELGauss(MatriceCoefficientsSEL.MatriceEnMémoire, MatriceConstantesSEL.MatriceEnMémoire);
                    boîteSolution.Text = "";
                    if (s == null)
                    {
                        boîteSolution.Text = "Aucune solutions.";
                    }
                    else
                    {
                        string m = s[0];
                        for (int i = 1; i < s.Length; i++)
                            m += " , " + s[i];
                        boîteSolution.Text = m;
                    }
                }
                else if (OpérateurSélectionnéSEL == matriceInverse.Text)
                {
                    MatriceAugmentéÉchelon.Raffraîchir(SEL.MéthodeMatriceInverse(MatriceCoefficientsSEL.MatriceEnMémoire, MatriceConstantesSEL.MatriceEnMémoire));
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Une erreur a été détecté. L'opération que vous tenté\n d'effectuer est soit impossible ou la calculatrice possède un bug.");
            }
            
            PlacerMatricesSELs();
        }


        private string CalculerEstUneBase()
        {
            Vecteur[] vB = new Vecteur[Base.MatriceEnMémoire.GetLength(1)];
            List<double[,]> vecteurs = new List<double[,]>();
            CreerBase(vecteurs, vB);

            if (Vecteur.EstUneBase(vB, Base.MatriceEnMémoire.GetLength(1)))
            {
                return "Est Une Base de dimension : " + Base.MatriceEnMémoire.GetLength(1);
            }
            else
            {
                return "N'est pas une Base de dimension : " + Base.MatriceEnMémoire.GetLength(1);
            }
        }

        private void CreerBase(List<double[,]> vecteurs, Vecteur[] vB)
        {

            for (int c = 0; c < Base.MatriceEnMémoire.GetLength(1); ++c)
            {
                double[,] v = new double[Base.MatriceEnMémoire.GetLength(0), 1];
                for (int l = 0; l < Base.MatriceEnMémoire.GetLength(0); ++l)
                {
                    v[l, 0] = Base.MatriceEnMémoire[l, c];
                }
                vecteurs.Add(v);
            }

            for (int l = 0; l < Base.MatriceEnMémoire.GetLength(0); ++l)
            {
                vB[l] = new Vecteur(vecteurs[l]);
            }
        }

        private void Normalisation()
        {
            double norme = CalculerNorme();
            double[,] m = new double[U.MatriceEnMémoire.GetLength(0), U.MatriceEnMémoire.GetLength(1)];
            for (int r = 0; r < U.MatriceEnMémoire.GetLength(0); r++)
                for (int c = 0; c < U.MatriceEnMémoire.GetLength(1); c++)
                    m[r,c] = U.MatriceEnMémoire[r,c]/norme;
            W.Raffraîchir(m);
        }

        private double CalculerNorme()
        {
            double norme = 0;
            for (int r = 0; r < U.MatriceEnMémoire.GetLength(0); r++)
                for (int c = 0; c < U.MatriceEnMémoire.GetLength(1);c++)
                    norme += Math.Pow(U.MatriceEnMémoire[r, c], 2);

            return Math.Sqrt(norme);
        }


















        #endregion

        #region Boutons et évènements
        //Bouton ordinaire
        private void GénérerPanelA_Click(object sender, EventArgs e)
        {
            MatriceA.Raffraîchir(int.Parse(nbLignesA.Text), int.Parse(nbColonnesA.Text));
            MatriceB.Raffraîchir(int.Parse(nbLignesB.Text), int.Parse(nbColonnesB.Text));
            MatriceC.Raffraîchir(0, 0);
            labelDet.Text = "Déterminant =";
            PlacerMatricesMatrice();
        }


        
        //Radio
        private void BoutonAddition_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonAddition.Text;
        }

        private void BoutonSoustraction_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonSoustraction.Text;
        }

        private void BoutonMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonMultiplication.Text;
        }

        private void BoutonScalaire_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonScalaire.Text;

            kMatrice.Text = "0";
        }

        private void BoutonDéterminant_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonDéterminant.Text;

            labelDet.Text = "Déterminant =";
        }

        private void BoutonInverse_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonInverse.Text;

        }

        private void BoutonLU_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonLU.Text;

        }

        private void BoutonFauxProduit_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonFauxProduit.Text;
        }

        private void BoutonPuissance_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonPuissance.Text;

            nMatrice.Text = "1";
        }

        private void BoutonTransposée_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéMatrice = BoutonTransposée.Text;

        }
        #endregion
        
        #region Placer les matrices

        //Autres
        void PlacerMatricesMatrice()
        {
            groupeMatrices.Controls.Clear();
            MatriceA.Fenêtre.Left = A_LEFT;
            MatriceA.Fenêtre.Top = A_TOP;
            MatriceB.Fenêtre.Left = B_LEFT;
            MatriceB.Fenêtre.Top = B_TOP;
            MatriceC.Fenêtre.Left = C_LEFT;
            MatriceC.Fenêtre.Top = C_TOP;

            groupeMatrices.Controls.Add(MatriceA.Fenêtre);
            groupeMatrices.Controls.Add(MatriceB.Fenêtre);
            groupeMatrices.Controls.Add(MatriceC.Fenêtre);
        }

        void PlacerMatricesVecteurs()
        {
            groupeVecteurs.Controls.Clear();
            groupeBase.Controls.Clear();
            U.Fenêtre.Left = U_LEFT;
            U.Fenêtre.Top = U_TOP;
            V.Fenêtre.Left = V_LEFT;
            V.Fenêtre.Top = V_TOP;
            W.Fenêtre.Left = W_LEFT;
            W.Fenêtre.Top = W_TOP;
            Base.Fenêtre.Left = BASE_LEFT;
            Base.Fenêtre.Top = BASE_TOP;


            groupeVecteurs.Controls.Add(U.Fenêtre);
            groupeVecteurs.Controls.Add(V.Fenêtre);
            groupeVecteurs.Controls.Add(W.Fenêtre);
            groupeBase.Controls.Add(Base.Fenêtre);
        }

        void PlacerMatricesSELs()
        {
            groupeSELs.Controls.Clear();
            MatriceCoefficientsSEL.Fenêtre.Left = COEF_LEFT;
            MatriceCoefficientsSEL.Fenêtre.Top = COEF_TOP;
            MatriceConstantesSEL.Fenêtre.Left = CON_LEFT;
            MatriceConstantesSEL.Fenêtre.Top = CON_TOP;
            MatriceAugmentéÉchelon.Fenêtre.Left = AUG_LEFT;
            MatriceAugmentéÉchelon.Fenêtre.Top = AUG_TOP;

            groupeSELs.Controls.Add(MatriceCoefficientsSEL.Fenêtre);
            groupeSELs.Controls.Add(MatriceConstantesSEL.Fenêtre);
            groupeSELs.Controls.Add(MatriceAugmentéÉchelon.Fenêtre);
        }
#endregion

        #region Options de génération Aléatoire

        private void BoutonAAléatoire_Click(object sender, EventArgs e)
        {
            double[,] matriceAléatoire;
            if (DimensionsDéfinies.Checked && !générerIntSeulement.Checked)
            {
                matriceAléatoire = GénérerMatriceAléatoire(int.Parse(nbLignesAléatoires.Text), int.Parse(nbColonnesAléatoires.Text));
            }
            else if (générerIntSeulement.Checked && DimensionsDéfinies.Checked)
            {
                matriceAléatoire = GénérerMatriceAléatoireEntière(int.Parse(nbLignesAléatoires.Text), int.Parse(nbColonnesAléatoires.Text));
            }
            else if (générerIntSeulement.Checked && !DimensionsDéfinies.Checked)
            {
                matriceAléatoire = GénérerMatriceAléatoireEntière();
            }
            else
            {
                matriceAléatoire = GénérerMatriceAléatoire();
            }
            MatriceA.Raffraîchir(matriceAléatoire);
        }

        private void BoutonBAléatoire_Click(object sender, EventArgs e)
        {
            double[,] matriceAléatoire;
            if (DimensionsDéfinies.Checked && !générerIntSeulement.Checked)
            {
                matriceAléatoire = GénérerMatriceAléatoire(int.Parse(nbLignesAléatoires.Text), int.Parse(nbColonnesAléatoires.Text));
            }
            else if (générerIntSeulement.Checked && DimensionsDéfinies.Checked)
            {
                matriceAléatoire = GénérerMatriceAléatoireEntière(int.Parse(nbLignesAléatoires.Text), int.Parse(nbColonnesAléatoires.Text));
            }
            else if (générerIntSeulement.Checked && !DimensionsDéfinies.Checked)
            {
                matriceAléatoire = GénérerMatriceAléatoireEntière();
            }
            else
            {
                matriceAléatoire = GénérerMatriceAléatoire();
            }
            MatriceB.Raffraîchir(matriceAléatoire);
        }
        double[,] GénérerMatriceAléatoire(int nbLignes, int nbColonnes)//Retourne une nouvelle matrice aléatoire de dimension définie
        {
            double[,] matriceAléatoire = new double[nbLignes, nbColonnes];
            int[] échelles = {1,10,100,1000,10000,-1,-10,-100,-1000,-10000};

            for (int i = 0; i < nbColonnes; ++i)
            {
                for (int j = 0; j < nbLignes; ++j)
                {
                    matriceAléatoire[j, i] = GénérateurAléatoire.NextDouble()*échelles[GénérateurAléatoire.Next(0,échelles.Length-1)];
                }
            }

            return matriceAléatoire;
        }

        double[,] GénérerMatriceAléatoire()//Retourne une nouvelle matrice aléatoire de dimension aléatoire.
        {
            int nbLignes = GénérateurAléatoire.Next(1,7);
            int nbColonnes = GénérateurAléatoire.Next(1,7);
            double[,] matriceAléatoire = new double[nbLignes, nbColonnes];

            int[] échelles = { 1, 10, 100, 1000, 10000, -1, -10, -100, -1000, -10000 };

            for (int i = 0; i < nbColonnes; ++i)
            {
                for (int j = 0; j < nbLignes; ++j)
                {
                    matriceAléatoire[j, i] = GénérateurAléatoire.NextDouble() * échelles[GénérateurAléatoire.Next(0,échelles.Length-1)];
                }
            }

            return matriceAléatoire;
        }


        double[,] GénérerMatriceAléatoireEntière(int nbLignes, int nbColonnes)
        {
            double[,] matriceAléatoire = new double[nbLignes, nbColonnes];

            for (int i = 0; i < nbColonnes; ++i)
            {
                for (int j = 0; j < nbLignes; ++j)
                {
                    matriceAléatoire[j, i] = GénérateurAléatoire.Next(-100,100);
                }
            }

            return matriceAléatoire;
        }

        double[,] GénérerMatriceAléatoireEntière()
        {
            int nbLignes = GénérateurAléatoire.Next(1,7);
            int nbColonnes = GénérateurAléatoire.Next(1,7);
            double[,] matriceAléatoire = new double[nbLignes, nbColonnes];

            for (int i = 0; i < nbColonnes; ++i)
            {
                for (int j = 0; j < nbLignes; ++j)
                {
                    matriceAléatoire[j, i] = GénérateurAléatoire.Next(-100, 100);
                }
            }

            return matriceAléatoire;
        }






        #endregion

        #region Trucs pas rapport ou redneck
        private void labelk_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nbLignesAléatoires.Text = "1";
            nbColonnesAléatoires.Text = "1";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }




        private void n_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void générerIntSeulement_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void Gauss_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéSEL = Gauss.Text;
        }



        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéSEL = matriceInverse.Text;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MatriceCoefficientsSEL.Raffraîchir(int.Parse(nbEqs.Text), int.Parse(nbVariables.Text));
            MatriceConstantesSEL.Raffraîchir(int.Parse(nbEqs.Text), 1);
            MatriceAugmentéÉchelon.Raffraîchir(int.Parse(nbEqs.Text), int.Parse(nbVariables.Text) + 1);
            PlacerMatricesSELs();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void vecteurAddition_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurAddition.Text;
        }

        private void vecteurSoustraction_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurSoustraction.Text;
        }

        private void vecteurScalaire_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurScalaire.Text;
        }

        private void vecteurNorme_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurNorme.Text;
        }

        private void vecteurNormalisationU_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurNormalisationU.Text;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurDansBaseB.Text;
        }

        private void vecteurEstUneBase_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = vecteurEstUneBase.Text;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            U.Raffraîchir(1, int.Parse(vecteurNbDimensions.Text));
            V.Raffraîchir(1, int.Parse(vecteurNbDimensions.Text));
            W.Raffraîchir(1, int.Parse(vecteurNbDimensions.Text));

            PlacerMatricesVecteurs();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void boutonGénérerBase_Click(object sender, EventArgs e)
        {
            Base.Raffraîchir(int.Parse(nbDimensionsBase.Text), int.Parse(nbVecteursBase.Text));
            PlacerMatricesVecteurs();
        }

        private void formerVecteurPoints_CheckedChanged(object sender, EventArgs e)
        {
            OpérateurSélectionnéVecteur = formerVecteurPoints.Text;
        }
        
    }
}
