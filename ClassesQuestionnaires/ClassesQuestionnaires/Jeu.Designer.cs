namespace ClassesQuestionnaires
{
    partial class Jeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Question = new System.Windows.Forms.TextBox();
            this.PN_Choix = new System.Windows.Forms.Panel();
            this.RB_Rep1 = new System.Windows.Forms.RadioButton();
            this.RB_Rep2 = new System.Windows.Forms.RadioButton();
            this.RB_Rep3 = new System.Windows.Forms.RadioButton();
            this.RB_Rep4 = new System.Windows.Forms.RadioButton();
            this.LBL_Joueur = new System.Windows.Forms.Label();
            this.BTN_Action = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GRB_Score = new System.Windows.Forms.GroupBox();
            this.LBL_Histoire = new System.Windows.Forms.Label();
            this.LBL_ScoreHistoire = new System.Windows.Forms.Label();
            this.LBL_Science = new System.Windows.Forms.Label();
            this.LBL_ScoreScience = new System.Windows.Forms.Label();
            this.LBL_Geographie = new System.Windows.Forms.Label();
            this.LBL_ScoreGeographie = new System.Windows.Forms.Label();
            this.LBL_Cinema = new System.Windows.Forms.Label();
            this.LBL_ScoreCinema = new System.Windows.Forms.Label();
            this.PN_Roulette = new System.Windows.Forms.Panel();
            this.LBL_Categorie = new System.Windows.Forms.Label();
            this.PN_Choix.SuspendLayout();
            this.GRB_Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Question
            // 
            this.TB_Question.Location = new System.Drawing.Point(13, 139);
            this.TB_Question.Multiline = true;
            this.TB_Question.Name = "TB_Question";
            this.TB_Question.ReadOnly = true;
            this.TB_Question.Size = new System.Drawing.Size(393, 54);
            this.TB_Question.TabIndex = 0;
            // 
            // PN_Choix
            // 
            this.PN_Choix.Controls.Add(this.RB_Rep1);
            this.PN_Choix.Controls.Add(this.RB_Rep2);
            this.PN_Choix.Controls.Add(this.RB_Rep3);
            this.PN_Choix.Controls.Add(this.RB_Rep4);
            this.PN_Choix.Location = new System.Drawing.Point(13, 199);
            this.PN_Choix.Name = "PN_Choix";
            this.PN_Choix.Size = new System.Drawing.Size(393, 100);
            this.PN_Choix.TabIndex = 1;
            // 
            // RB_Rep1
            // 
            this.RB_Rep1.Location = new System.Drawing.Point(3, 3);
            this.RB_Rep1.Name = "RB_Rep1";
            this.RB_Rep1.Size = new System.Drawing.Size(173, 41);
            this.RB_Rep1.TabIndex = 0;
            this.RB_Rep1.TabStop = true;
            this.RB_Rep1.Text = "radioButton1";
            this.RB_Rep1.UseVisualStyleBackColor = true;
            // 
            // RB_Rep2
            // 
            this.RB_Rep2.Location = new System.Drawing.Point(194, 3);
            this.RB_Rep2.Name = "RB_Rep2";
            this.RB_Rep2.Size = new System.Drawing.Size(196, 41);
            this.RB_Rep2.TabIndex = 1;
            this.RB_Rep2.TabStop = true;
            this.RB_Rep2.Text = "radioButton2";
            this.RB_Rep2.UseVisualStyleBackColor = true;
            // 
            // RB_Rep3
            // 
            this.RB_Rep3.Location = new System.Drawing.Point(3, 50);
            this.RB_Rep3.Name = "RB_Rep3";
            this.RB_Rep3.Size = new System.Drawing.Size(173, 47);
            this.RB_Rep3.TabIndex = 2;
            this.RB_Rep3.TabStop = true;
            this.RB_Rep3.Text = "radioButton3";
            this.RB_Rep3.UseVisualStyleBackColor = true;
            // 
            // RB_Rep4
            // 
            this.RB_Rep4.Location = new System.Drawing.Point(194, 50);
            this.RB_Rep4.Name = "RB_Rep4";
            this.RB_Rep4.Size = new System.Drawing.Size(196, 47);
            this.RB_Rep4.TabIndex = 3;
            this.RB_Rep4.TabStop = true;
            this.RB_Rep4.Text = "radioButton4";
            this.RB_Rep4.UseVisualStyleBackColor = true;
            // 
            // LBL_Joueur
            // 
            this.LBL_Joueur.AutoSize = true;
            this.LBL_Joueur.Location = new System.Drawing.Point(13, 19);
            this.LBL_Joueur.Name = "LBL_Joueur";
            this.LBL_Joueur.Size = new System.Drawing.Size(39, 13);
            this.LBL_Joueur.TabIndex = 4;
            this.LBL_Joueur.Text = "Joueur";
            // 
            // BTN_Action
            // 
            this.BTN_Action.Location = new System.Drawing.Point(331, 305);
            this.BTN_Action.Name = "BTN_Action";
            this.BTN_Action.Size = new System.Drawing.Size(75, 23);
            this.BTN_Action.TabIndex = 5;
            this.BTN_Action.Text = "Répondre";
            this.BTN_Action.UseVisualStyleBackColor = true;
            this.BTN_Action.Click += new System.EventHandler(this.BTN_Action_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ModifierQuestionButton_Click);
            // 
            // GRB_Score
            // 
            this.GRB_Score.Controls.Add(this.LBL_Histoire);
            this.GRB_Score.Controls.Add(this.LBL_ScoreHistoire);
            this.GRB_Score.Controls.Add(this.LBL_Science);
            this.GRB_Score.Controls.Add(this.LBL_ScoreScience);
            this.GRB_Score.Controls.Add(this.LBL_Geographie);
            this.GRB_Score.Controls.Add(this.LBL_ScoreGeographie);
            this.GRB_Score.Controls.Add(this.LBL_Cinema);
            this.GRB_Score.Controls.Add(this.LBL_ScoreCinema);
            this.GRB_Score.Location = new System.Drawing.Point(13, 35);
            this.GRB_Score.Name = "GRB_Score";
            this.GRB_Score.Size = new System.Drawing.Size(114, 98);
            this.GRB_Score.TabIndex = 7;
            this.GRB_Score.TabStop = false;
            this.GRB_Score.Text = "Score";
            // 
            // LBL_Histoire
            // 
            this.LBL_Histoire.AutoSize = true;
            this.LBL_Histoire.Location = new System.Drawing.Point(7, 20);
            this.LBL_Histoire.Name = "LBL_Histoire";
            this.LBL_Histoire.Size = new System.Drawing.Size(42, 13);
            this.LBL_Histoire.TabIndex = 0;
            this.LBL_Histoire.Text = "Histoire";
            // 
            // LBL_ScoreHistoire
            // 
            this.LBL_ScoreHistoire.AutoSize = true;
            this.LBL_ScoreHistoire.Location = new System.Drawing.Point(82, 20);
            this.LBL_ScoreHistoire.Name = "LBL_ScoreHistoire";
            this.LBL_ScoreHistoire.Size = new System.Drawing.Size(26, 13);
            this.LBL_ScoreHistoire.TabIndex = 1;
            this.LBL_ScoreHistoire.Text = "X/X";
            // 
            // LBL_Science
            // 
            this.LBL_Science.AutoSize = true;
            this.LBL_Science.Location = new System.Drawing.Point(7, 39);
            this.LBL_Science.Name = "LBL_Science";
            this.LBL_Science.Size = new System.Drawing.Size(46, 13);
            this.LBL_Science.TabIndex = 2;
            this.LBL_Science.Text = "Science";
            // 
            // LBL_ScoreScience
            // 
            this.LBL_ScoreScience.AutoSize = true;
            this.LBL_ScoreScience.Location = new System.Drawing.Point(82, 39);
            this.LBL_ScoreScience.Name = "LBL_ScoreScience";
            this.LBL_ScoreScience.Size = new System.Drawing.Size(26, 13);
            this.LBL_ScoreScience.TabIndex = 3;
            this.LBL_ScoreScience.Text = "X/X";
            // 
            // LBL_Geographie
            // 
            this.LBL_Geographie.AutoSize = true;
            this.LBL_Geographie.Location = new System.Drawing.Point(7, 57);
            this.LBL_Geographie.Name = "LBL_Geographie";
            this.LBL_Geographie.Size = new System.Drawing.Size(62, 13);
            this.LBL_Geographie.TabIndex = 4;
            this.LBL_Geographie.Text = "Geographie";
            // 
            // LBL_ScoreGeographie
            // 
            this.LBL_ScoreGeographie.AutoSize = true;
            this.LBL_ScoreGeographie.Location = new System.Drawing.Point(82, 57);
            this.LBL_ScoreGeographie.Name = "LBL_ScoreGeographie";
            this.LBL_ScoreGeographie.Size = new System.Drawing.Size(26, 13);
            this.LBL_ScoreGeographie.TabIndex = 5;
            this.LBL_ScoreGeographie.Text = "X/X";
            // 
            // LBL_Cinema
            // 
            this.LBL_Cinema.AutoSize = true;
            this.LBL_Cinema.Location = new System.Drawing.Point(7, 75);
            this.LBL_Cinema.Name = "LBL_Cinema";
            this.LBL_Cinema.Size = new System.Drawing.Size(42, 13);
            this.LBL_Cinema.TabIndex = 6;
            this.LBL_Cinema.Text = "Cinema";
            // 
            // LBL_ScoreCinema
            // 
            this.LBL_ScoreCinema.AutoSize = true;
            this.LBL_ScoreCinema.Location = new System.Drawing.Point(82, 75);
            this.LBL_ScoreCinema.Name = "LBL_ScoreCinema";
            this.LBL_ScoreCinema.Size = new System.Drawing.Size(26, 13);
            this.LBL_ScoreCinema.TabIndex = 7;
            this.LBL_ScoreCinema.Text = "X/X";
            // 
            // PN_Roulette
            // 
            this.PN_Roulette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Roulette.Location = new System.Drawing.Point(270, 35);
            this.PN_Roulette.Name = "PN_Roulette";
            this.PN_Roulette.Size = new System.Drawing.Size(136, 100);
            this.PN_Roulette.TabIndex = 8;
            this.PN_Roulette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Roulette_MouseClick);
            this.PN_Roulette.MouseEnter += new System.EventHandler(this.PN_Roulette_MouseEnter);
            this.PN_Roulette.MouseLeave += new System.EventHandler(this.PN_Roulette_MouseLeave);
            // 
            // LBL_Categorie
            // 
            this.LBL_Categorie.AutoSize = true;
            this.LBL_Categorie.Location = new System.Drawing.Point(354, 19);
            this.LBL_Categorie.Name = "LBL_Categorie";
            this.LBL_Categorie.Size = new System.Drawing.Size(52, 13);
            this.LBL_Categorie.TabIndex = 9;
            this.LBL_Categorie.Text = "Catégorie";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.LBL_Categorie);
            this.Controls.Add(this.PN_Roulette);
            this.Controls.Add(this.GRB_Score);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Action);
            this.Controls.Add(this.LBL_Joueur);
            this.Controls.Add(this.PN_Choix);
            this.Controls.Add(this.TB_Question);
            this.Name = "Jeu";
            this.Text = "m";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PN_Choix.ResumeLayout(false);
            this.GRB_Score.ResumeLayout(false);
            this.GRB_Score.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Question;
        private System.Windows.Forms.Panel PN_Choix;
        private System.Windows.Forms.RadioButton RB_Rep4;
        private System.Windows.Forms.RadioButton RB_Rep3;
        private System.Windows.Forms.RadioButton RB_Rep2;
        private System.Windows.Forms.RadioButton RB_Rep1;
        private System.Windows.Forms.Label LBL_Joueur;
        private System.Windows.Forms.Button BTN_Action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GRB_Score;
        private System.Windows.Forms.Panel PN_Roulette;
        private System.Windows.Forms.Label LBL_Categorie;
        private System.Windows.Forms.Label LBL_Histoire;
        private System.Windows.Forms.Label LBL_ScoreScience;
        private System.Windows.Forms.Label LBL_Science;
        private System.Windows.Forms.Label LBL_ScoreHistoire;
        private System.Windows.Forms.Label LBL_Geographie;
        private System.Windows.Forms.Label LBL_ScoreCinema;
        private System.Windows.Forms.Label LBL_Cinema;
        private System.Windows.Forms.Label LBL_ScoreGeographie;
    }
}

