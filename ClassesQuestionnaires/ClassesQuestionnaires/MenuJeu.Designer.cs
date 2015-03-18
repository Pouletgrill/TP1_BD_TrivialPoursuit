namespace ClassesQuestionnaires
{
   partial class MenuJeu
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
         this.BTN_Jouer = new System.Windows.Forms.Button();
         this.TB_Joueur4 = new System.Windows.Forms.TextBox();
         this.TB_Joueur3 = new System.Windows.Forms.TextBox();
         this.TB_Joueur2 = new System.Windows.Forms.TextBox();
         this.TB_Joueur1 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.label5 = new System.Windows.Forms.Label();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // BTN_Jouer
         // 
         this.BTN_Jouer.Enabled = false;
         this.BTN_Jouer.Location = new System.Drawing.Point(99, 192);
         this.BTN_Jouer.Name = "BTN_Jouer";
         this.BTN_Jouer.Size = new System.Drawing.Size(75, 23);
         this.BTN_Jouer.TabIndex = 0;
         this.BTN_Jouer.Text = "Jouer !";
         this.BTN_Jouer.UseVisualStyleBackColor = true;
         this.BTN_Jouer.Click += new System.EventHandler(this.BTN_Jouer_Click);
         // 
         // TB_Joueur4
         // 
         this.TB_Joueur4.Location = new System.Drawing.Point(99, 131);
         this.TB_Joueur4.Name = "TB_Joueur4";
         this.TB_Joueur4.Size = new System.Drawing.Size(100, 20);
         this.TB_Joueur4.TabIndex = 1;
         this.TB_Joueur4.TextChanged += new System.EventHandler(this.TB_Joueur1_TextChanged);
         // 
         // TB_Joueur3
         // 
         this.TB_Joueur3.Location = new System.Drawing.Point(99, 105);
         this.TB_Joueur3.Name = "TB_Joueur3";
         this.TB_Joueur3.Size = new System.Drawing.Size(100, 20);
         this.TB_Joueur3.TabIndex = 2;
         this.TB_Joueur3.TextChanged += new System.EventHandler(this.TB_Joueur1_TextChanged);
         // 
         // TB_Joueur2
         // 
         this.TB_Joueur2.Location = new System.Drawing.Point(99, 79);
         this.TB_Joueur2.Name = "TB_Joueur2";
         this.TB_Joueur2.Size = new System.Drawing.Size(100, 20);
         this.TB_Joueur2.TabIndex = 3;
         this.TB_Joueur2.TextChanged += new System.EventHandler(this.TB_Joueur1_TextChanged);
         // 
         // TB_Joueur1
         // 
         this.TB_Joueur1.Location = new System.Drawing.Point(99, 53);
         this.TB_Joueur1.Name = "TB_Joueur1";
         this.TB_Joueur1.Size = new System.Drawing.Size(100, 20);
         this.TB_Joueur1.TabIndex = 4;
         this.TB_Joueur1.TextChanged += new System.EventHandler(this.TB_Joueur1_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(38, 56);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(55, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Joueur #1";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(38, 82);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(55, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Joueur #2";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(38, 108);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(55, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Joueur #3";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(38, 134);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(55, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Joueur #4";
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(136, 27);
         this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
         this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
         this.numericUpDown1.TabIndex = 9;
         this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(28, 29);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(102, 13);
         this.label5.TabIndex = 10;
         this.label5.Text = "Nombre de joueur(s)";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(284, 24);
         this.menuStrip1.TabIndex = 11;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // editionToolStripMenuItem
         // 
         this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
         this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
         this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
         this.editionToolStripMenuItem.Text = "Edition";
         // 
         // gestionToolStripMenuItem
         // 
         this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
         this.gestionToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.gestionToolStripMenuItem.Text = "Gestion";
         this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
         // 
         // MenuJeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 262);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.TB_Joueur1);
         this.Controls.Add(this.TB_Joueur2);
         this.Controls.Add(this.TB_Joueur3);
         this.Controls.Add(this.TB_Joueur4);
         this.Controls.Add(this.BTN_Jouer);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MenuJeu";
         this.Text = "MenuJeu";
         this.Load += new System.EventHandler(this.MenuJeu_Load);
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Jouer;
      private System.Windows.Forms.TextBox TB_Joueur4;
      private System.Windows.Forms.TextBox TB_Joueur3;
      private System.Windows.Forms.TextBox TB_Joueur2;
      private System.Windows.Forms.TextBox TB_Joueur1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
   }
}