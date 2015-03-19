namespace ClassesQuestionnaires
{
    partial class ModifierMotDePasse
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NouveauMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NMPValidation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ancien Mot de passe :";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(144, 6);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '●';
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 6;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(169, 84);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 5;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(88, 84);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 4;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nouveau Mot de passe :";
            // 
            // TB_NouveauMP
            // 
            this.TB_NouveauMP.Location = new System.Drawing.Point(144, 32);
            this.TB_NouveauMP.Name = "TB_NouveauMP";
            this.TB_NouveauMP.PasswordChar = '●';
            this.TB_NouveauMP.Size = new System.Drawing.Size(100, 20);
            this.TB_NouveauMP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Validation Mot de passe :";
            // 
            // TB_NMPValidation
            // 
            this.TB_NMPValidation.Location = new System.Drawing.Point(144, 58);
            this.TB_NMPValidation.Name = "TB_NMPValidation";
            this.TB_NMPValidation.PasswordChar = '●';
            this.TB_NMPValidation.Size = new System.Drawing.Size(100, 20);
            this.TB_NMPValidation.TabIndex = 10;
            // 
            // ModifierMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 116);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_NMPValidation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NouveauMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Annuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifierMotDePasse";
            this.Text = "Gestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NouveauMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NMPValidation;
    }
}