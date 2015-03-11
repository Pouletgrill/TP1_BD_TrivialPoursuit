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
            this.LBL_Result = new System.Windows.Forms.Label();
            this.LBL_Joueur = new System.Windows.Forms.Label();
            this.BTN_Action = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GRB_Score = new System.Windows.Forms.GroupBox();
            this.PN_Roulette = new System.Windows.Forms.Panel();
            this.PN_Choix.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Question
            // 
            this.TB_Question.Location = new System.Drawing.Point(13, 139);
            this.TB_Question.Multiline = true;
            this.TB_Question.Name = "TB_Question";
            this.TB_Question.ReadOnly = true;
            this.TB_Question.Size = new System.Drawing.Size(259, 54);
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
            this.PN_Choix.Size = new System.Drawing.Size(259, 100);
            this.PN_Choix.TabIndex = 1;
            // 
            // RB_Rep1
            // 
            this.RB_Rep1.AutoSize = true;
            this.RB_Rep1.Location = new System.Drawing.Point(3, 20);
            this.RB_Rep1.Name = "RB_Rep1";
            this.RB_Rep1.Size = new System.Drawing.Size(85, 17);
            this.RB_Rep1.TabIndex = 0;
            this.RB_Rep1.TabStop = true;
            this.RB_Rep1.Text = "radioButton1";
            this.RB_Rep1.UseVisualStyleBackColor = true;
            // 
            // RB_Rep2
            // 
            this.RB_Rep2.AutoSize = true;
            this.RB_Rep2.Location = new System.Drawing.Point(171, 20);
            this.RB_Rep2.Name = "RB_Rep2";
            this.RB_Rep2.Size = new System.Drawing.Size(85, 17);
            this.RB_Rep2.TabIndex = 1;
            this.RB_Rep2.TabStop = true;
            this.RB_Rep2.Text = "radioButton2";
            this.RB_Rep2.UseVisualStyleBackColor = true;
            // 
            // RB_Rep3
            // 
            this.RB_Rep3.AutoSize = true;
            this.RB_Rep3.Location = new System.Drawing.Point(3, 67);
            this.RB_Rep3.Name = "RB_Rep3";
            this.RB_Rep3.Size = new System.Drawing.Size(85, 17);
            this.RB_Rep3.TabIndex = 2;
            this.RB_Rep3.TabStop = true;
            this.RB_Rep3.Text = "radioButton3";
            this.RB_Rep3.UseVisualStyleBackColor = true;
            // 
            // RB_Rep4
            // 
            this.RB_Rep4.AutoSize = true;
            this.RB_Rep4.Location = new System.Drawing.Point(171, 67);
            this.RB_Rep4.Name = "RB_Rep4";
            this.RB_Rep4.Size = new System.Drawing.Size(85, 17);
            this.RB_Rep4.TabIndex = 3;
            this.RB_Rep4.TabStop = true;
            this.RB_Rep4.Text = "radioButton4";
            this.RB_Rep4.UseVisualStyleBackColor = true;
            // 
            // LBL_Result
            // 
            this.LBL_Result.AutoSize = true;
            this.LBL_Result.Location = new System.Drawing.Point(54, 9);
            this.LBL_Result.Name = "LBL_Result";
            this.LBL_Result.Size = new System.Drawing.Size(29, 13);
            this.LBL_Result.TabIndex = 3;
            this.LBL_Result.Text = "label";
            // 
            // LBL_Joueur
            // 
            this.LBL_Joueur.AutoSize = true;
            this.LBL_Joueur.Location = new System.Drawing.Point(13, 9);
            this.LBL_Joueur.Name = "LBL_Joueur";
            this.LBL_Joueur.Size = new System.Drawing.Size(39, 13);
            this.LBL_Joueur.TabIndex = 4;
            this.LBL_Joueur.Text = "Joueur";
            // 
            // BTN_Action
            // 
            this.BTN_Action.Location = new System.Drawing.Point(197, 305);
            this.BTN_Action.Name = "BTN_Action";
            this.BTN_Action.Size = new System.Drawing.Size(75, 23);
            this.BTN_Action.TabIndex = 5;
            this.BTN_Action.Text = "Répondre";
            this.BTN_Action.UseVisualStyleBackColor = true;
            this.BTN_Action.Click += new System.EventHandler(this.BTN_Action_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ModifierQuestionButton_Click);
            // 
            // GRB_Score
            // 
            this.GRB_Score.Location = new System.Drawing.Point(13, 35);
            this.GRB_Score.Name = "GRB_Score";
            this.GRB_Score.Size = new System.Drawing.Size(114, 98);
            this.GRB_Score.TabIndex = 7;
            this.GRB_Score.TabStop = false;
            this.GRB_Score.Text = "Score";
            // 
            // PN_Roulette
            // 
            this.PN_Roulette.Location = new System.Drawing.Point(133, 35);
            this.PN_Roulette.Name = "PN_Roulette";
            this.PN_Roulette.Size = new System.Drawing.Size(136, 100);
            this.PN_Roulette.TabIndex = 8;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.PN_Roulette);
            this.Controls.Add(this.GRB_Score);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Action);
            this.Controls.Add(this.LBL_Joueur);
            this.Controls.Add(this.LBL_Result);
            this.Controls.Add(this.PN_Choix);
            this.Controls.Add(this.TB_Question);
            this.Name = "Jeu";
            this.Text = "m";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PN_Choix.ResumeLayout(false);
            this.PN_Choix.PerformLayout();
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
        private System.Windows.Forms.Label LBL_Result;
        private System.Windows.Forms.Label LBL_Joueur;
        private System.Windows.Forms.Button BTN_Action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GRB_Score;
        private System.Windows.Forms.Panel PN_Roulette;
    }
}

