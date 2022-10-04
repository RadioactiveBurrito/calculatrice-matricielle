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
    class MatriceAffichée
    {
        public Panel Fenêtre { get; set; }

        TextBox[,] TableauBoîtesTexte { get; set; }
        public double[,] MatriceEnMémoire { get; set; }
        int LargeurFenêtre { get; set; }
        int HauteurFenêtre { get; set; }
        public string Nom { get; private set; }

        public int NbLignes { get; private set; }
        public int NbColonnes { get; private set; }

        const int GROSSEUR_TEXTBOX_DIM = 20;
        const int GROSSEUR_TEXTBOX = 30;
        const int MARGE = 5;

        #region Initialisation
        public MatriceAffichée(int largeur, int hauteur,int nbLignes,int nbColonnes,string nom)
        {
            LargeurFenêtre = largeur;
            HauteurFenêtre = hauteur;
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            Nom = nom;

            InitialiserFenêtre();
            GénérerMatrice();
        }

        public void InitialiserFenêtre()
        {
            //Initialisation de la boîte.
            Fenêtre = new Panel();
            Fenêtre.AutoScroll = true;
            Fenêtre.BackColor = System.Drawing.Color.LightGray;
            Fenêtre.Visible = true;
            Fenêtre.Width = LargeurFenêtre;
            Fenêtre.Height = HauteurFenêtre;

            Fenêtre.Left = MARGE;
            Fenêtre.Top = MARGE;

        }

        void GénérerMatrice()
        {
            TableauBoîtesTexte = new TextBox[NbLignes, NbColonnes];
            MatriceEnMémoire = new double[NbLignes, NbColonnes];

            TextBox txt = new TextBox();
            for (int i = 0; i < NbLignes; i++)
            {
                for (int e = 0; e < NbColonnes; e++)
                {
                    txt = GénérerTextbox(i, e, "0");
                    TableauBoîtesTexte[i, e] = txt;
                    Fenêtre.Controls.Add(txt);
                }
            }
        }

        public TextBox GénérerTextbox(int i, int e, string s)
        {
            TextBox txt = new TextBox();
            txt.Top = 5 + txt.Height * i;
            txt.Left = 5 + GROSSEUR_TEXTBOX * e;
            txt.Width = GROSSEUR_TEXTBOX;
            txt.Name = i + ";" + e;
            txt.Text = s;
            txt.Tag = "1";

            return txt;
        }
        #endregion


        #region Méthodes en lien avec le rafraîchissement.

        //Lorsque l'on clique sur le bouton Générer.
        public void Raffraîchir(int nbLignes, int nbColonnes)
        {
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            RéinitialiserMatrice();
        }
        private void RéinitialiserMatrice()
        {
            InitialiserFenêtre();
            GénérerMatrice();
        }




        //Pour charger les données des textebox en mémoire. S'appelle pour A et B.
        public void Raffraîchir()
        {
            GénérerMatrice(Fenêtre);
            Fenêtre.Controls.Clear();

            foreach (TextBox t in TableauBoîtesTexte)
            {
                Fenêtre.Controls.Add(t);
            }
        }

        void GénérerMatrice(Panel fenêtre)
        {
            TableauBoîtesTexte = new TextBox[NbLignes, NbColonnes];
            MatriceEnMémoire = new double[NbLignes, NbColonnes];

            TextBox txt = new TextBox();
            for (int i = 0; i < NbLignes; i++)
            {
                for (int e = 0; e < NbColonnes; e++)
                {
                    txt = fenêtre.Controls.Find(i + ";" + e,true).FirstOrDefault() as TextBox;
                    TableauBoîtesTexte[i, e] = txt;
                    MatriceEnMémoire[i, e] = double.Parse(txt.Text);
                    Fenêtre.Controls.Add(txt);
                }
            }
        }


        //Appeller pour C seulement.

        public void Raffraîchir(double[,] matrice)
        {
            GénérerMatrice(matrice);
            Fenêtre.Controls.Clear();

            foreach (TextBox t in TableauBoîtesTexte)
            {
                Fenêtre.Controls.Add(t);
            }
        }

        void GénérerMatrice(double[,] matrice)
        {
            string s;
            double élément;
            NbLignes = matrice.GetLength(0);
            NbColonnes = matrice.GetLength(1);
            TableauBoîtesTexte = new TextBox[NbLignes, NbColonnes];
            MatriceEnMémoire = new double[NbLignes, NbColonnes];

            TextBox txt = new TextBox();
            for (int i = 0; i < NbLignes; i++)
            {
                for (int e = 0; e < NbColonnes; e++)
                {
                    élément = matrice[i, e];
                    s = élément.ToString();
                    txt = GénérerTextbox(i, e, s);
                    TableauBoîtesTexte[i, e] = txt;
                    MatriceEnMémoire[i, e] = élément;
                    Fenêtre.Controls.Add(txt);
                }
            }
        }
        #endregion
       

        





       






       


        
    }
}
