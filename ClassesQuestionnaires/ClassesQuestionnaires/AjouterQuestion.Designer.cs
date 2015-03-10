namespace ClassesQuestionnaires
{
    partial class AjouterQuestion
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
         this.LBL_Question = new System.Windows.Forms.Label();
         this.LBL_Categorie = new System.Windows.Forms.Label();
         this.CMB_Categories = new System.Windows.Forms.ComboBox();
         this.GRB_Reponses = new System.Windows.Forms.GroupBox();
         this.TB_Reponse1 = new System.Windows.Forms.TextBox();
         this.RB_Reponse1 = new System.Windows.Forms.RadioButton();
         this.TB_Reponse2 = new System.Windows.Forms.TextBox();
         this.RB_Reponse2 = new System.Windows.Forms.RadioButton();
         this.TB_Reponse3 = new System.Windows.Forms.TextBox();
         this.RB_Reponse3 = new System.Windows.Forms.RadioButton();
         this.TB_Reponse4 = new System.Windows.Forms.TextBox();
         this.RB_Reponse4 = new System.Windows.Forms.RadioButton();
         this.BTN_Ajouter = new System.Windows.Forms.Button();
         this.BTN_Annuler = new System.Windows.Forms.Button();
         this.GRB_Reponses.SuspendLayout();
         this.SuspendLayout();
         // 
         // TB_Question
         // 
         this.TB_Question.Location = new System.Drawing.Point(15, 29);
         this.TB_Question.Multiline = true;
         this.TB_Question.Name = "TB_Question";
         this.TB_Question.Size = new System.Drawing.Size(260, 58);
         this.TB_Question.TabIndex = 0;
         this.TB_Question.TextChanged += new System.EventHandler(this.TB_Question_TextChanged);
         // 
         // LBL_Question
         // 
         this.LBL_Question.AutoSize = true;
         this.LBL_Question.Location = new System.Drawing.Point(12, 13);
         this.LBL_Question.Name = "LBL_Question";
         this.LBL_Question.Size = new System.Drawing.Size(49, 13);
         this.LBL_Question.TabIndex = 1;
         this.LBL_Question.Text = "Question";
         // 
         // LBL_Categorie
         // 
         this.LBL_Categorie.AutoSize = true;
         this.LBL_Categorie.Location = new System.Drawing.Point(12, 96);
         this.LBL_Categorie.Name = "LBL_Categorie";
         this.LBL_Categorie.Size = new System.Drawing.Size(52, 13);
         this.LBL_Categorie.TabIndex = 2;
         this.LBL_Categorie.Text = "Catégorie";
         // 
         // CMB_Categories
         // 
         this.CMB_Categories.FormattingEnabled = true;
         this.CMB_Categories.Location = new System.Drawing.Point(70, 93);
         this.CMB_Categories.Name = "CMB_Categories";
         this.CMB_Categories.Size = new System.Drawing.Size(202, 21);
         this.CMB_Categories.TabIndex = 3;
         this.CMB_Categories.SelectedIndexChanged += new System.EventHandler(this.CMB_Categories_SelectedIndexChanged);
         // 
         // GRB_Reponses
         // 
         this.GRB_Reponses.Controls.Add(this.TB_Reponse1);
         this.GRB_Reponses.Controls.Add(this.RB_Reponse1);
         this.GRB_Reponses.Controls.Add(this.TB_Reponse2);
         this.GRB_Reponses.Controls.Add(this.RB_Reponse2);
         this.GRB_Reponses.Controls.Add(this.TB_Reponse3);
         this.GRB_Reponses.Controls.Add(this.RB_Reponse3);
         this.GRB_Reponses.Controls.Add(this.TB_Reponse4);
         this.GRB_Reponses.Controls.Add(this.RB_Reponse4);
         this.GRB_Reponses.Location = new System.Drawing.Point(15, 120);
         this.GRB_Reponses.Name = "GRB_Reponses";
         this.GRB_Reponses.Size = new System.Drawing.Size(257, 102);
         this.GRB_Reponses.TabIndex = 4;
         this.GRB_Reponses.TabStop = false;
         this.GRB_Reponses.Text = "Réponses";
         // 
         // TB_Reponse1
         // 
         this.TB_Reponse1.Location = new System.Drawing.Point(26, 27);
         this.TB_Reponse1.Name = "TB_Reponse1";
         this.TB_Reponse1.Size = new System.Drawing.Size(92, 20);
         this.TB_Reponse1.TabIndex = 1;
         this.TB_Reponse1.TextChanged += new System.EventHandler(this.TB_Reponse1_TextChanged);
         // 
         // RB_Reponse1
         // 
         this.RB_Reponse1.AutoSize = true;
         this.RB_Reponse1.Checked = true;
         this.RB_Reponse1.Location = new System.Drawing.Point(6, 30);
         this.RB_Reponse1.Name = "RB_Reponse1";
         this.RB_Reponse1.Size = new System.Drawing.Size(14, 13);
         this.RB_Reponse1.TabIndex = 0;
         this.RB_Reponse1.TabStop = true;
         this.RB_Reponse1.UseVisualStyleBackColor = true;
         // 
         // TB_Reponse2
         // 
         this.TB_Reponse2.Location = new System.Drawing.Point(159, 27);
         this.TB_Reponse2.Name = "TB_Reponse2";
         this.TB_Reponse2.Size = new System.Drawing.Size(92, 20);
         this.TB_Reponse2.TabIndex = 3;
         this.TB_Reponse2.TextChanged += new System.EventHandler(this.TB_Reponse2_TextChanged);
         // 
         // RB_Reponse2
         // 
         this.RB_Reponse2.AutoSize = true;
         this.RB_Reponse2.Location = new System.Drawing.Point(139, 30);
         this.RB_Reponse2.Name = "RB_Reponse2";
         this.RB_Reponse2.Size = new System.Drawing.Size(14, 13);
         this.RB_Reponse2.TabIndex = 2;
         this.RB_Reponse2.UseVisualStyleBackColor = true;
         // 
         // TB_Reponse3
         // 
         this.TB_Reponse3.Location = new System.Drawing.Point(26, 70);
         this.TB_Reponse3.Name = "TB_Reponse3";
         this.TB_Reponse3.Size = new System.Drawing.Size(92, 20);
         this.TB_Reponse3.TabIndex = 5;
         this.TB_Reponse3.TextChanged += new System.EventHandler(this.TB_Reponse3_TextChanged);
         // 
         // RB_Reponse3
         // 
         this.RB_Reponse3.AutoSize = true;
         this.RB_Reponse3.Location = new System.Drawing.Point(6, 73);
         this.RB_Reponse3.Name = "RB_Reponse3";
         this.RB_Reponse3.Size = new System.Drawing.Size(14, 13);
         this.RB_Reponse3.TabIndex = 4;
         this.RB_Reponse3.UseVisualStyleBackColor = true;
         // 
         // TB_Reponse4
         // 
         this.TB_Reponse4.Location = new System.Drawing.Point(159, 70);
         this.TB_Reponse4.Name = "TB_Reponse4";
         this.TB_Reponse4.Size = new System.Drawing.Size(92, 20);
         this.TB_Reponse4.TabIndex = 7;
         this.TB_Reponse4.TextChanged += new System.EventHandler(this.TB_Reponse4_TextChanged);
         // 
         // RB_Reponse4
         // 
         this.RB_Reponse4.AutoSize = true;
         this.RB_Reponse4.Location = new System.Drawing.Point(139, 73);
         this.RB_Reponse4.Name = "RB_Reponse4";
         this.RB_Reponse4.Size = new System.Drawing.Size(14, 13);
         this.RB_Reponse4.TabIndex = 6;
         this.RB_Reponse4.UseVisualStyleBackColor = true;
         // 
         // BTN_Ajouter
         // 
         this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.BTN_Ajouter.Location = new System.Drawing.Point(200, 228);
         this.BTN_Ajouter.Name = "BTN_Ajouter";
         this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
         this.BTN_Ajouter.TabIndex = 5;
         this.BTN_Ajouter.Text = "Ajouter";
         this.BTN_Ajouter.UseVisualStyleBackColor = true;
         // 
         // BTN_Annuler
         // 
         this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.BTN_Annuler.Location = new System.Drawing.Point(119, 228);
         this.BTN_Annuler.Name = "BTN_Annuler";
         this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
         this.BTN_Annuler.TabIndex = 5;
         this.BTN_Annuler.Text = "Annuler";
         this.BTN_Annuler.UseVisualStyleBackColor = true;
         this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
         // 
         // AjouterQuestion
         // 
         this.AcceptButton = this.BTN_Ajouter;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.BTN_Annuler;
         this.ClientSize = new System.Drawing.Size(284, 257);
         this.Controls.Add(this.BTN_Annuler);
         this.Controls.Add(this.BTN_Ajouter);
         this.Controls.Add(this.GRB_Reponses);
         this.Controls.Add(this.CMB_Categories);
         this.Controls.Add(this.LBL_Categorie);
         this.Controls.Add(this.LBL_Question);
         this.Controls.Add(this.TB_Question);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "AjouterQuestion";
         this.Text = "AjouterQuestion";
         this.Load += new System.EventHandler(this.AjouterQuestion_Load);
         this.GRB_Reponses.ResumeLayout(false);
         this.GRB_Reponses.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Question;
        private System.Windows.Forms.Label LBL_Question;
        private System.Windows.Forms.Label LBL_Categorie;
        private System.Windows.Forms.ComboBox CMB_Categories;
        private System.Windows.Forms.GroupBox GRB_Reponses;
        private System.Windows.Forms.RadioButton RB_Reponse1;
        private System.Windows.Forms.TextBox TB_Reponse1;
        private System.Windows.Forms.TextBox TB_Reponse4;
        private System.Windows.Forms.RadioButton RB_Reponse4;
        private System.Windows.Forms.TextBox TB_Reponse3;
        private System.Windows.Forms.RadioButton RB_Reponse3;
        private System.Windows.Forms.TextBox TB_Reponse2;
        private System.Windows.Forms.RadioButton RB_Reponse2;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}