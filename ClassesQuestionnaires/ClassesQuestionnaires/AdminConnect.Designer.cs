﻿namespace ClassesQuestionnaires
{
   partial class AdminConnect
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
         this.BTN_Annuler = new System.Windows.Forms.Button();
         this.BTN_Ok = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // BTN_Annuler
         // 
         this.BTN_Annuler.Location = new System.Drawing.Point(12, 47);
         this.BTN_Annuler.Name = "BTN_Annuler";
         this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
         this.BTN_Annuler.TabIndex = 0;
         this.BTN_Annuler.Text = "Annuler";
         this.BTN_Annuler.UseVisualStyleBackColor = true;
         // 
         // BTN_Ok
         // 
         this.BTN_Ok.Location = new System.Drawing.Point(120, 47);
         this.BTN_Ok.Name = "BTN_Ok";
         this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
         this.BTN_Ok.TabIndex = 1;
         this.BTN_Ok.Text = "Ok";
         this.BTN_Ok.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(95, 12);
         this.textBox1.Name = "textBox1";
         this.textBox1.PasswordChar = '●';
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(77, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Mot de passe :";
         // 
         // AdminConnect
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(206, 82);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.BTN_Ok);
         this.Controls.Add(this.BTN_Annuler);
         this.Name = "AdminConnect";
         this.Text = "Gestion";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Annuler;
      private System.Windows.Forms.Button BTN_Ok;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label1;
   }
}