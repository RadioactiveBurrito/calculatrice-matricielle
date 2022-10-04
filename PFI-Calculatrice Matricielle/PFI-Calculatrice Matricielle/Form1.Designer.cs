namespace PFI_Calculatrice_Matricielle
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nbColonnesA = new System.Windows.Forms.TextBox();
            this.nbLignesA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoutonSoustraction = new System.Windows.Forms.RadioButton();
            this.BoutonMultiplication = new System.Windows.Forms.RadioButton();
            this.BoutonScalaire = new System.Windows.Forms.RadioButton();
            this.BoutonDéterminant = new System.Windows.Forms.RadioButton();
            this.BoutonInverse = new System.Windows.Forms.RadioButton();
            this.BoutonLU = new System.Windows.Forms.RadioButton();
            this.BoutonGénérerPanels = new System.Windows.Forms.Button();
            this.nbColonnesB = new System.Windows.Forms.TextBox();
            this.nbLignesB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoutonCalculer = new System.Windows.Forms.Button();
            this.BoutonAddition = new System.Windows.Forms.RadioButton();
            this.BoutonFauxProduit = new System.Windows.Forms.RadioButton();
            this.BoutonPuissance = new System.Windows.Forms.RadioButton();
            this.kMatrice = new System.Windows.Forms.TextBox();
            this.labelKMatrice = new System.Windows.Forms.Label();
            this.labelDet = new System.Windows.Forms.Label();
            this.BoutonAAléatoire = new System.Windows.Forms.Button();
            this.BoutonBAléatoire = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.générerIntSeulement = new System.Windows.Forms.CheckBox();
            this.nbColonnesAléatoires = new System.Windows.Forms.TextBox();
            this.nbLignesAléatoires = new System.Windows.Forms.TextBox();
            this.DimensionsDéfinies = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BoutonTransposée = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.nMatrice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vecteurNbDimensions = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.normeU = new System.Windows.Forms.Label();
            this.groupeVecteurs = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SortieVecteur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.informationBase = new System.Windows.Forms.TextBox();
            this.vecteurDansBaseB = new System.Windows.Forms.RadioButton();
            this.vecteurEstUneBase = new System.Windows.Forms.RadioButton();
            this.vecteurAddition = new System.Windows.Forms.RadioButton();
            this.vecteurNormalisationU = new System.Windows.Forms.RadioButton();
            this.vecteurNorme = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.kVecteur = new System.Windows.Forms.TextBox();
            this.vecteurSoustraction = new System.Windows.Forms.RadioButton();
            this.vecteurScalaire = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nbVariables = new System.Windows.Forms.TextBox();
            this.nbEqs = new System.Windows.Forms.TextBox();
            this.générerSEL = new System.Windows.Forms.Button();
            this.calculerSEL = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.boîteSolution = new System.Windows.Forms.TextBox();
            this.matriceInverse = new System.Windows.Forms.RadioButton();
            this.Gauss = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupeSELs = new System.Windows.Forms.GroupBox();
            this.groupeMatrices = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupeBase = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nbVecteursBase = new System.Windows.Forms.TextBox();
            this.nbDimensionsBase = new System.Windows.Forms.TextBox();
            this.boutonGénérerBase = new System.Windows.Forms.Button();
            this.formerVecteurPoints = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nbColonnesA
            // 
            this.nbColonnesA.Location = new System.Drawing.Point(479, 309);
            this.nbColonnesA.Name = "nbColonnesA";
            this.nbColonnesA.Size = new System.Drawing.Size(47, 20);
            this.nbColonnesA.TabIndex = 2;
            this.nbColonnesA.Text = "1";
            // 
            // nbLignesA
            // 
            this.nbLignesA.Location = new System.Drawing.Point(426, 309);
            this.nbLignesA.Name = "nbLignesA";
            this.nbLignesA.Size = new System.Drawing.Size(47, 20);
            this.nbLignesA.TabIndex = 0;
            this.nbLignesA.Text = "1";
            this.nbLignesA.TextChanged += new System.EventHandler(this.nbLignesA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrice A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1040, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Matrice C";
            // 
            // BoutonSoustraction
            // 
            this.BoutonSoustraction.AutoSize = true;
            this.BoutonSoustraction.Location = new System.Drawing.Point(9, 42);
            this.BoutonSoustraction.Name = "BoutonSoustraction";
            this.BoutonSoustraction.Size = new System.Drawing.Size(48, 17);
            this.BoutonSoustraction.TabIndex = 12;
            this.BoutonSoustraction.TabStop = true;
            this.BoutonSoustraction.Text = "A - B";
            this.BoutonSoustraction.UseVisualStyleBackColor = true;
            this.BoutonSoustraction.CheckedChanged += new System.EventHandler(this.BoutonSoustraction_CheckedChanged);
            // 
            // BoutonMultiplication
            // 
            this.BoutonMultiplication.AutoSize = true;
            this.BoutonMultiplication.Location = new System.Drawing.Point(8, 65);
            this.BoutonMultiplication.Name = "BoutonMultiplication";
            this.BoutonMultiplication.Size = new System.Drawing.Size(49, 17);
            this.BoutonMultiplication.TabIndex = 13;
            this.BoutonMultiplication.TabStop = true;
            this.BoutonMultiplication.Text = "A * B";
            this.BoutonMultiplication.UseVisualStyleBackColor = true;
            this.BoutonMultiplication.CheckedChanged += new System.EventHandler(this.BoutonMultiplication_CheckedChanged);
            // 
            // BoutonScalaire
            // 
            this.BoutonScalaire.AutoSize = true;
            this.BoutonScalaire.Location = new System.Drawing.Point(9, 89);
            this.BoutonScalaire.Name = "BoutonScalaire";
            this.BoutonScalaire.Size = new System.Drawing.Size(48, 17);
            this.BoutonScalaire.TabIndex = 14;
            this.BoutonScalaire.TabStop = true;
            this.BoutonScalaire.Text = "k * A";
            this.BoutonScalaire.UseVisualStyleBackColor = true;
            this.BoutonScalaire.CheckedChanged += new System.EventHandler(this.BoutonScalaire_CheckedChanged);
            // 
            // BoutonDéterminant
            // 
            this.BoutonDéterminant.AutoSize = true;
            this.BoutonDéterminant.Location = new System.Drawing.Point(9, 113);
            this.BoutonDéterminant.Name = "BoutonDéterminant";
            this.BoutonDéterminant.Size = new System.Drawing.Size(53, 17);
            this.BoutonDéterminant.TabIndex = 15;
            this.BoutonDéterminant.TabStop = true;
            this.BoutonDéterminant.Text = "det(A)";
            this.BoutonDéterminant.UseVisualStyleBackColor = true;
            this.BoutonDéterminant.CheckedChanged += new System.EventHandler(this.BoutonDéterminant_CheckedChanged);
            // 
            // BoutonInverse
            // 
            this.BoutonInverse.AutoSize = true;
            this.BoutonInverse.Location = new System.Drawing.Point(9, 137);
            this.BoutonInverse.Name = "BoutonInverse";
            this.BoutonInverse.Size = new System.Drawing.Size(47, 17);
            this.BoutonInverse.TabIndex = 16;
            this.BoutonInverse.TabStop = true;
            this.BoutonInverse.Text = "A^-1";
            this.BoutonInverse.UseVisualStyleBackColor = true;
            this.BoutonInverse.CheckedChanged += new System.EventHandler(this.BoutonInverse_CheckedChanged);
            // 
            // BoutonLU
            // 
            this.BoutonLU.AutoSize = true;
            this.BoutonLU.Location = new System.Drawing.Point(9, 183);
            this.BoutonLU.Name = "BoutonLU";
            this.BoutonLU.Size = new System.Drawing.Size(52, 17);
            this.BoutonLU.TabIndex = 17;
            this.BoutonLU.TabStop = true;
            this.BoutonLU.Text = "LU(A)";
            this.BoutonLU.UseVisualStyleBackColor = true;
            this.BoutonLU.CheckedChanged += new System.EventHandler(this.BoutonLU_CheckedChanged);
            // 
            // BoutonGénérerPanels
            // 
            this.BoutonGénérerPanels.Location = new System.Drawing.Point(598, 307);
            this.BoutonGénérerPanels.Name = "BoutonGénérerPanels";
            this.BoutonGénérerPanels.Size = new System.Drawing.Size(75, 23);
            this.BoutonGénérerPanels.TabIndex = 20;
            this.BoutonGénérerPanels.Text = "Générer";
            this.BoutonGénérerPanels.UseVisualStyleBackColor = true;
            this.BoutonGénérerPanels.Click += new System.EventHandler(this.GénérerPanelA_Click);
            // 
            // nbColonnesB
            // 
            this.nbColonnesB.Location = new System.Drawing.Point(787, 309);
            this.nbColonnesB.Name = "nbColonnesB";
            this.nbColonnesB.Size = new System.Drawing.Size(47, 20);
            this.nbColonnesB.TabIndex = 23;
            this.nbColonnesB.Text = "1";
            // 
            // nbLignesB
            // 
            this.nbLignesB.Location = new System.Drawing.Point(734, 309);
            this.nbLignesB.Name = "nbLignesB";
            this.nbLignesB.Size = new System.Drawing.Size(47, 20);
            this.nbLignesB.TabIndex = 21;
            this.nbLignesB.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Matrice B";
            // 
            // BoutonCalculer
            // 
            this.BoutonCalculer.Location = new System.Drawing.Point(598, 278);
            this.BoutonCalculer.Name = "BoutonCalculer";
            this.BoutonCalculer.Size = new System.Drawing.Size(75, 23);
            this.BoutonCalculer.TabIndex = 27;
            this.BoutonCalculer.Text = "Calculer";
            this.BoutonCalculer.UseVisualStyleBackColor = true;
            this.BoutonCalculer.Click += new System.EventHandler(this.BoutonCalculer_Click);
            // 
            // BoutonAddition
            // 
            this.BoutonAddition.AutoSize = true;
            this.BoutonAddition.Location = new System.Drawing.Point(7, 19);
            this.BoutonAddition.Name = "BoutonAddition";
            this.BoutonAddition.Size = new System.Drawing.Size(51, 17);
            this.BoutonAddition.TabIndex = 28;
            this.BoutonAddition.TabStop = true;
            this.BoutonAddition.Text = "A + B";
            this.BoutonAddition.UseVisualStyleBackColor = true;
            this.BoutonAddition.CheckedChanged += new System.EventHandler(this.BoutonAddition_CheckedChanged);
            // 
            // BoutonFauxProduit
            // 
            this.BoutonFauxProduit.Location = new System.Drawing.Point(9, 160);
            this.BoutonFauxProduit.Name = "BoutonFauxProduit";
            this.BoutonFauxProduit.Size = new System.Drawing.Size(100, 17);
            this.BoutonFauxProduit.TabIndex = 29;
            this.BoutonFauxProduit.TabStop = true;
            this.BoutonFauxProduit.Text = "Faux Produit";
            this.BoutonFauxProduit.UseVisualStyleBackColor = true;
            this.BoutonFauxProduit.CheckedChanged += new System.EventHandler(this.BoutonFauxProduit_CheckedChanged);
            // 
            // BoutonPuissance
            // 
            this.BoutonPuissance.AutoSize = true;
            this.BoutonPuissance.Location = new System.Drawing.Point(8, 206);
            this.BoutonPuissance.Name = "BoutonPuissance";
            this.BoutonPuissance.Size = new System.Drawing.Size(44, 17);
            this.BoutonPuissance.TabIndex = 30;
            this.BoutonPuissance.TabStop = true;
            this.BoutonPuissance.Text = "A^n";
            this.BoutonPuissance.UseVisualStyleBackColor = true;
            this.BoutonPuissance.CheckedChanged += new System.EventHandler(this.BoutonPuissance_CheckedChanged);
            // 
            // kMatrice
            // 
            this.kMatrice.Location = new System.Drawing.Point(58, 287);
            this.kMatrice.Name = "kMatrice";
            this.kMatrice.Size = new System.Drawing.Size(44, 20);
            this.kMatrice.TabIndex = 31;
            this.kMatrice.Text = "0";
            this.kMatrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelKMatrice
            // 
            this.labelKMatrice.AutoSize = true;
            this.labelKMatrice.Location = new System.Drawing.Point(58, 271);
            this.labelKMatrice.Name = "labelKMatrice";
            this.labelKMatrice.Size = new System.Drawing.Size(13, 13);
            this.labelKMatrice.TabIndex = 32;
            this.labelKMatrice.Text = "k";
            this.labelKMatrice.Click += new System.EventHandler(this.labelk_Click);
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Location = new System.Drawing.Point(15, 436);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(86, 13);
            this.labelDet.TabIndex = 33;
            this.labelDet.Text = "Déterminant A = ";
            // 
            // BoutonAAléatoire
            // 
            this.BoutonAAléatoire.Location = new System.Drawing.Point(127, 18);
            this.BoutonAAléatoire.Name = "BoutonAAléatoire";
            this.BoutonAAléatoire.Size = new System.Drawing.Size(75, 23);
            this.BoutonAAléatoire.TabIndex = 34;
            this.BoutonAAléatoire.Text = "A Aléatoire";
            this.BoutonAAléatoire.UseVisualStyleBackColor = true;
            this.BoutonAAléatoire.Click += new System.EventHandler(this.BoutonAAléatoire_Click);
            // 
            // BoutonBAléatoire
            // 
            this.BoutonBAléatoire.Location = new System.Drawing.Point(127, 47);
            this.BoutonBAléatoire.Name = "BoutonBAléatoire";
            this.BoutonBAléatoire.Size = new System.Drawing.Size(75, 23);
            this.BoutonBAléatoire.TabIndex = 35;
            this.BoutonBAléatoire.Text = "B Aléatoire";
            this.BoutonBAléatoire.UseVisualStyleBackColor = true;
            this.BoutonBAléatoire.Click += new System.EventHandler(this.BoutonBAléatoire_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.générerIntSeulement);
            this.groupBox1.Controls.Add(this.nbColonnesAléatoires);
            this.groupBox1.Controls.Add(this.nbLignesAléatoires);
            this.groupBox1.Controls.Add(this.DimensionsDéfinies);
            this.groupBox1.Controls.Add(this.BoutonAAléatoire);
            this.groupBox1.Controls.Add(this.BoutonBAléatoire);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 110);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options de génération aléatoire";
            // 
            // générerIntSeulement
            // 
            this.générerIntSeulement.AutoSize = true;
            this.générerIntSeulement.Location = new System.Drawing.Point(6, 82);
            this.générerIntSeulement.Name = "générerIntSeulement";
            this.générerIntSeulement.Size = new System.Drawing.Size(109, 17);
            this.générerIntSeulement.TabIndex = 41;
            this.générerIntSeulement.Text = "Entiers seulement";
            this.générerIntSeulement.UseVisualStyleBackColor = true;
            this.générerIntSeulement.CheckedChanged += new System.EventHandler(this.générerIntSeulement_CheckedChanged);
            // 
            // nbColonnesAléatoires
            // 
            this.nbColonnesAléatoires.Location = new System.Drawing.Point(45, 33);
            this.nbColonnesAléatoires.Name = "nbColonnesAléatoires";
            this.nbColonnesAléatoires.Size = new System.Drawing.Size(32, 20);
            this.nbColonnesAléatoires.TabIndex = 40;
            this.nbColonnesAléatoires.Text = "1";
            // 
            // nbLignesAléatoires
            // 
            this.nbLignesAléatoires.Location = new System.Drawing.Point(7, 33);
            this.nbLignesAléatoires.Name = "nbLignesAléatoires";
            this.nbLignesAléatoires.Size = new System.Drawing.Size(32, 20);
            this.nbLignesAléatoires.TabIndex = 38;
            this.nbLignesAléatoires.Text = "1";
            // 
            // DimensionsDéfinies
            // 
            this.DimensionsDéfinies.AutoSize = true;
            this.DimensionsDéfinies.Location = new System.Drawing.Point(6, 59);
            this.DimensionsDéfinies.Name = "DimensionsDéfinies";
            this.DimensionsDéfinies.Size = new System.Drawing.Size(121, 17);
            this.DimensionsDéfinies.TabIndex = 36;
            this.DimensionsDéfinies.Text = "Dimensions Définies";
            this.DimensionsDéfinies.UseVisualStyleBackColor = true;
            this.DimensionsDéfinies.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BoutonTransposée);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nMatrice);
            this.groupBox2.Controls.Add(this.BoutonAddition);
            this.groupBox2.Controls.Add(this.BoutonLU);
            this.groupBox2.Controls.Add(this.BoutonInverse);
            this.groupBox2.Controls.Add(this.BoutonDéterminant);
            this.groupBox2.Controls.Add(this.BoutonScalaire);
            this.groupBox2.Controls.Add(this.labelKMatrice);
            this.groupBox2.Controls.Add(this.BoutonMultiplication);
            this.groupBox2.Controls.Add(this.kMatrice);
            this.groupBox2.Controls.Add(this.BoutonSoustraction);
            this.groupBox2.Controls.Add(this.BoutonPuissance);
            this.groupBox2.Controls.Add(this.BoutonFauxProduit);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 313);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fonctions Matrice";
            // 
            // BoutonTransposée
            // 
            this.BoutonTransposée.AutoSize = true;
            this.BoutonTransposée.Location = new System.Drawing.Point(8, 229);
            this.BoutonTransposée.Name = "BoutonTransposée";
            this.BoutonTransposée.Size = new System.Drawing.Size(45, 17);
            this.BoutonTransposée.TabIndex = 36;
            this.BoutonTransposée.TabStop = true;
            this.BoutonTransposée.Text = "A^T";
            this.BoutonTransposée.UseVisualStyleBackColor = true;
            this.BoutonTransposée.CheckedChanged += new System.EventHandler(this.BoutonTransposée_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "n";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nMatrice
            // 
            this.nMatrice.Location = new System.Drawing.Point(8, 287);
            this.nMatrice.Name = "nMatrice";
            this.nMatrice.Size = new System.Drawing.Size(44, 20);
            this.nMatrice.TabIndex = 34;
            this.nMatrice.Text = "1";
            this.nMatrice.TextChanged += new System.EventHandler(this.n_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.formerVecteurPoints);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.vecteurNbDimensions);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.normeU);
            this.groupBox3.Controls.Add(this.groupeVecteurs);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.SortieVecteur);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.informationBase);
            this.groupBox3.Controls.Add(this.vecteurDansBaseB);
            this.groupBox3.Controls.Add(this.vecteurEstUneBase);
            this.groupBox3.Controls.Add(this.vecteurAddition);
            this.groupBox3.Controls.Add(this.vecteurNormalisationU);
            this.groupBox3.Controls.Add(this.vecteurNorme);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.kVecteur);
            this.groupBox3.Controls.Add(this.vecteurSoustraction);
            this.groupBox3.Controls.Add(this.vecteurScalaire);
            this.groupBox3.Location = new System.Drawing.Point(153, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 313);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fonctions Vecteurs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "dimension";
            // 
            // vecteurNbDimensions
            // 
            this.vecteurNbDimensions.Location = new System.Drawing.Point(20, 201);
            this.vecteurNbDimensions.Name = "vecteurNbDimensions";
            this.vecteurNbDimensions.Size = new System.Drawing.Size(27, 20);
            this.vecteurNbDimensions.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Générer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // normeU
            // 
            this.normeU.AutoSize = true;
            this.normeU.Location = new System.Drawing.Point(77, 232);
            this.normeU.Name = "normeU";
            this.normeU.Size = new System.Drawing.Size(56, 13);
            this.normeU.TabIndex = 47;
            this.normeU.Text = "norme U =";
            // 
            // groupeVecteurs
            // 
            this.groupeVecteurs.Location = new System.Drawing.Point(156, 24);
            this.groupeVecteurs.Name = "groupeVecteurs";
            this.groupeVecteurs.Size = new System.Drawing.Size(108, 176);
            this.groupeVecteurs.TabIndex = 46;
            this.groupeVecteurs.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(178, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(769, 328);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // SortieVecteur
            // 
            this.SortieVecteur.AutoSize = true;
            this.SortieVecteur.Location = new System.Drawing.Point(153, 111);
            this.SortieVecteur.Name = "SortieVecteur";
            this.SortieVecteur.Size = new System.Drawing.Size(0, 13);
            this.SortieVecteur.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "W = ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "V = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "U = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "B";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // informationBase
            // 
            this.informationBase.Location = new System.Drawing.Point(59, 287);
            this.informationBase.Name = "informationBase";
            this.informationBase.Size = new System.Drawing.Size(48, 20);
            this.informationBase.TabIndex = 35;
            this.informationBase.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // vecteurDansBaseB
            // 
            this.vecteurDansBaseB.AutoSize = true;
            this.vecteurDansBaseB.Location = new System.Drawing.Point(6, 156);
            this.vecteurDansBaseB.Name = "vecteurDansBaseB";
            this.vecteurDansBaseB.Size = new System.Drawing.Size(52, 17);
            this.vecteurDansBaseB.TabIndex = 34;
            this.vecteurDansBaseB.TabStop = true;
            this.vecteurDansBaseB.Text = "U<B>";
            this.vecteurDansBaseB.UseVisualStyleBackColor = true;
            this.vecteurDansBaseB.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // vecteurEstUneBase
            // 
            this.vecteurEstUneBase.AutoSize = true;
            this.vecteurEstUneBase.Location = new System.Drawing.Point(6, 133);
            this.vecteurEstUneBase.Name = "vecteurEstUneBase";
            this.vecteurEstUneBase.Size = new System.Drawing.Size(84, 17);
            this.vecteurEstUneBase.TabIndex = 33;
            this.vecteurEstUneBase.TabStop = true;
            this.vecteurEstUneBase.Text = "EstUneBase";
            this.vecteurEstUneBase.UseVisualStyleBackColor = true;
            this.vecteurEstUneBase.CheckedChanged += new System.EventHandler(this.vecteurEstUneBase_CheckedChanged);
            // 
            // vecteurAddition
            // 
            this.vecteurAddition.AutoSize = true;
            this.vecteurAddition.Location = new System.Drawing.Point(6, 19);
            this.vecteurAddition.Name = "vecteurAddition";
            this.vecteurAddition.Size = new System.Drawing.Size(46, 17);
            this.vecteurAddition.TabIndex = 28;
            this.vecteurAddition.TabStop = true;
            this.vecteurAddition.Text = "U+V";
            this.vecteurAddition.UseVisualStyleBackColor = true;
            this.vecteurAddition.CheckedChanged += new System.EventHandler(this.vecteurAddition_CheckedChanged);
            // 
            // vecteurNormalisationU
            // 
            this.vecteurNormalisationU.AutoSize = true;
            this.vecteurNormalisationU.Location = new System.Drawing.Point(6, 110);
            this.vecteurNormalisationU.Name = "vecteurNormalisationU";
            this.vecteurNormalisationU.Size = new System.Drawing.Size(54, 17);
            this.vecteurNormalisationU.TabIndex = 16;
            this.vecteurNormalisationU.TabStop = true;
            this.vecteurNormalisationU.Text = "U/||U||";
            this.vecteurNormalisationU.UseVisualStyleBackColor = true;
            this.vecteurNormalisationU.CheckedChanged += new System.EventHandler(this.vecteurNormalisationU_CheckedChanged);
            // 
            // vecteurNorme
            // 
            this.vecteurNorme.AutoSize = true;
            this.vecteurNorme.Location = new System.Drawing.Point(7, 87);
            this.vecteurNorme.Name = "vecteurNorme";
            this.vecteurNorme.Size = new System.Drawing.Size(41, 17);
            this.vecteurNorme.TabIndex = 15;
            this.vecteurNorme.TabStop = true;
            this.vecteurNorme.Text = "||U||";
            this.vecteurNorme.UseVisualStyleBackColor = true;
            this.vecteurNorme.CheckedChanged += new System.EventHandler(this.vecteurNorme_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "k";
            // 
            // kVecteur
            // 
            this.kVecteur.Location = new System.Drawing.Point(9, 287);
            this.kVecteur.Name = "kVecteur";
            this.kVecteur.Size = new System.Drawing.Size(44, 20);
            this.kVecteur.TabIndex = 31;
            this.kVecteur.Text = "0";
            // 
            // vecteurSoustraction
            // 
            this.vecteurSoustraction.AutoSize = true;
            this.vecteurSoustraction.Location = new System.Drawing.Point(6, 42);
            this.vecteurSoustraction.Name = "vecteurSoustraction";
            this.vecteurSoustraction.Size = new System.Drawing.Size(43, 17);
            this.vecteurSoustraction.TabIndex = 12;
            this.vecteurSoustraction.TabStop = true;
            this.vecteurSoustraction.Text = "U-V";
            this.vecteurSoustraction.UseVisualStyleBackColor = true;
            this.vecteurSoustraction.CheckedChanged += new System.EventHandler(this.vecteurSoustraction_CheckedChanged);
            // 
            // vecteurScalaire
            // 
            this.vecteurScalaire.AutoSize = true;
            this.vecteurScalaire.Location = new System.Drawing.Point(7, 64);
            this.vecteurScalaire.Name = "vecteurScalaire";
            this.vecteurScalaire.Size = new System.Drawing.Size(43, 17);
            this.vecteurScalaire.TabIndex = 30;
            this.vecteurScalaire.TabStop = true;
            this.vecteurScalaire.Text = "k*U";
            this.vecteurScalaire.UseVisualStyleBackColor = true;
            this.vecteurScalaire.CheckedChanged += new System.EventHandler(this.vecteurScalaire_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.nbVariables);
            this.groupBox4.Controls.Add(this.nbEqs);
            this.groupBox4.Controls.Add(this.générerSEL);
            this.groupBox4.Controls.Add(this.calculerSEL);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.boîteSolution);
            this.groupBox4.Controls.Add(this.matriceInverse);
            this.groupBox4.Controls.Add(this.Gauss);
            this.groupBox4.Location = new System.Drawing.Point(423, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 262);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fonctions SEL";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "dimensions";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // nbVariables
            // 
            this.nbVariables.Location = new System.Drawing.Point(49, 139);
            this.nbVariables.Name = "nbVariables";
            this.nbVariables.Size = new System.Drawing.Size(27, 20);
            this.nbVariables.TabIndex = 50;
            // 
            // nbEqs
            // 
            this.nbEqs.Location = new System.Drawing.Point(16, 139);
            this.nbEqs.Name = "nbEqs";
            this.nbEqs.Size = new System.Drawing.Size(27, 20);
            this.nbEqs.TabIndex = 49;
            // 
            // générerSEL
            // 
            this.générerSEL.Location = new System.Drawing.Point(16, 165);
            this.générerSEL.Name = "générerSEL";
            this.générerSEL.Size = new System.Drawing.Size(64, 23);
            this.générerSEL.TabIndex = 48;
            this.générerSEL.Text = "Générer";
            this.générerSEL.UseVisualStyleBackColor = true;
            this.générerSEL.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // calculerSEL
            // 
            this.calculerSEL.Location = new System.Drawing.Point(16, 194);
            this.calculerSEL.Name = "calculerSEL";
            this.calculerSEL.Size = new System.Drawing.Size(64, 23);
            this.calculerSEL.TabIndex = 47;
            this.calculerSEL.Text = "Calculer";
            this.calculerSEL.UseVisualStyleBackColor = true;
            this.calculerSEL.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Solution:";
            // 
            // boîteSolution
            // 
            this.boîteSolution.Location = new System.Drawing.Point(0, 236);
            this.boîteSolution.Name = "boîteSolution";
            this.boîteSolution.Size = new System.Drawing.Size(103, 20);
            this.boîteSolution.TabIndex = 45;
            // 
            // matriceInverse
            // 
            this.matriceInverse.AutoSize = true;
            this.matriceInverse.Location = new System.Drawing.Point(3, 41);
            this.matriceInverse.Name = "matriceInverse";
            this.matriceInverse.Size = new System.Drawing.Size(97, 17);
            this.matriceInverse.TabIndex = 30;
            this.matriceInverse.TabStop = true;
            this.matriceInverse.Text = "Matrice inverse";
            this.matriceInverse.UseVisualStyleBackColor = true;
            this.matriceInverse.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // Gauss
            // 
            this.Gauss.AutoSize = true;
            this.Gauss.Location = new System.Drawing.Point(3, 18);
            this.Gauss.Name = "Gauss";
            this.Gauss.Size = new System.Drawing.Size(55, 17);
            this.Gauss.TabIndex = 29;
            this.Gauss.TabStop = true;
            this.Gauss.Text = "Gauss";
            this.Gauss.UseVisualStyleBackColor = true;
            this.Gauss.CheckedChanged += new System.EventHandler(this.Gauss_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(527, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Matrice des coefficients";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(739, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Matrice des constantes";
            // 
            // groupeSELs
            // 
            this.groupeSELs.Location = new System.Drawing.Point(529, 28);
            this.groupeSELs.Name = "groupeSELs";
            this.groupeSELs.Size = new System.Drawing.Size(638, 233);
            this.groupeSELs.TabIndex = 45;
            this.groupeSELs.TabStop = false;
            // 
            // groupeMatrices
            // 
            this.groupeMatrices.Location = new System.Drawing.Point(322, 335);
            this.groupeMatrices.Name = "groupeMatrices";
            this.groupeMatrices.Size = new System.Drawing.Size(941, 279);
            this.groupeMatrices.TabIndex = 46;
            this.groupeMatrices.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(939, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 24);
            this.label15.TabIndex = 47;
            this.label15.Text = "Matrice augmentée échelon";
            // 
            // groupeBase
            // 
            this.groupeBase.Location = new System.Drawing.Point(19, 452);
            this.groupeBase.Name = "groupeBase";
            this.groupeBase.Size = new System.Drawing.Size(200, 200);
            this.groupeBase.TabIndex = 49;
            this.groupeBase.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(221, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "dimensions base";
            // 
            // nbVecteursBase
            // 
            this.nbVecteursBase.Location = new System.Drawing.Point(261, 478);
            this.nbVecteursBase.Name = "nbVecteursBase";
            this.nbVecteursBase.Size = new System.Drawing.Size(27, 20);
            this.nbVecteursBase.TabIndex = 54;
            // 
            // nbDimensionsBase
            // 
            this.nbDimensionsBase.Location = new System.Drawing.Point(228, 478);
            this.nbDimensionsBase.Name = "nbDimensionsBase";
            this.nbDimensionsBase.Size = new System.Drawing.Size(27, 20);
            this.nbDimensionsBase.TabIndex = 53;
            // 
            // boutonGénérerBase
            // 
            this.boutonGénérerBase.Location = new System.Drawing.Point(228, 504);
            this.boutonGénérerBase.Name = "boutonGénérerBase";
            this.boutonGénérerBase.Size = new System.Drawing.Size(64, 23);
            this.boutonGénérerBase.TabIndex = 52;
            this.boutonGénérerBase.Text = "Générer";
            this.boutonGénérerBase.UseVisualStyleBackColor = true;
            this.boutonGénérerBase.Click += new System.EventHandler(this.boutonGénérerBase_Click);
            // 
            // formerVecteurPoints
            // 
            this.formerVecteurPoints.AutoSize = true;
            this.formerVecteurPoints.Location = new System.Drawing.Point(58, 19);
            this.formerVecteurPoints.Name = "formerVecteurPoints";
            this.formerVecteurPoints.Size = new System.Drawing.Size(72, 17);
            this.formerVecteurPoints.TabIndex = 56;
            this.formerVecteurPoints.TabStop = true;
            this.formerVecteurPoints.Text = "W ->(U,V)";
            this.formerVecteurPoints.UseVisualStyleBackColor = true;
            this.formerVecteurPoints.CheckedChanged += new System.EventHandler(this.formerVecteurPoints_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 654);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.nbVecteursBase);
            this.Controls.Add(this.nbDimensionsBase);
            this.Controls.Add(this.boutonGénérerBase);
            this.Controls.Add(this.groupeBase);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupeMatrices);
            this.Controls.Add(this.groupeSELs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoutonCalculer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDet);
            this.Controls.Add(this.nbLignesB);
            this.Controls.Add(this.nbColonnesB);
            this.Controls.Add(this.BoutonGénérerPanels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbLignesA);
            this.Controls.Add(this.nbColonnesA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice Matricielle";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CalculatriceMatricielle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nbColonnesA;
        private System.Windows.Forms.TextBox nbLignesA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton BoutonSoustraction;
        private System.Windows.Forms.RadioButton BoutonMultiplication;
        private System.Windows.Forms.RadioButton BoutonScalaire;
        private System.Windows.Forms.RadioButton BoutonDéterminant;
        private System.Windows.Forms.RadioButton BoutonInverse;
        private System.Windows.Forms.RadioButton BoutonLU;
        private System.Windows.Forms.Button BoutonGénérerPanels;
        private System.Windows.Forms.TextBox nbColonnesB;
        private System.Windows.Forms.TextBox nbLignesB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BoutonCalculer;
        private System.Windows.Forms.RadioButton BoutonAddition;
        private System.Windows.Forms.RadioButton BoutonFauxProduit;
        private System.Windows.Forms.RadioButton BoutonPuissance;
        private System.Windows.Forms.TextBox kMatrice;
        private System.Windows.Forms.Label labelKMatrice;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.Button BoutonAAléatoire;
        private System.Windows.Forms.Button BoutonBAléatoire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nbColonnesAléatoires;
        private System.Windows.Forms.TextBox nbLignesAléatoires;
        private System.Windows.Forms.CheckBox DimensionsDéfinies;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton vecteurAddition;
        private System.Windows.Forms.RadioButton vecteurNormalisationU;
        private System.Windows.Forms.RadioButton vecteurNorme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kVecteur;
        private System.Windows.Forms.RadioButton vecteurSoustraction;
        private System.Windows.Forms.RadioButton vecteurScalaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox informationBase;
        private System.Windows.Forms.RadioButton vecteurDansBaseB;
        private System.Windows.Forms.RadioButton vecteurEstUneBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nMatrice;
        private System.Windows.Forms.Label SortieVecteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton BoutonTransposée;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton matriceInverse;
        private System.Windows.Forms.RadioButton Gauss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boîteSolution;
        private System.Windows.Forms.CheckBox générerIntSeulement;
        private System.Windows.Forms.Button calculerSEL;
        private System.Windows.Forms.GroupBox groupeSELs;
        private System.Windows.Forms.GroupBox groupeVecteurs;
        private System.Windows.Forms.GroupBox groupeMatrices;
        private System.Windows.Forms.Button générerSEL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nbVariables;
        private System.Windows.Forms.TextBox nbEqs;
        private System.Windows.Forms.Label normeU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox vecteurNbDimensions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupeBase;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nbVecteursBase;
        private System.Windows.Forms.TextBox nbDimensionsBase;
        private System.Windows.Forms.Button boutonGénérerBase;
        private System.Windows.Forms.RadioButton formerVecteurPoints;
    }
}

