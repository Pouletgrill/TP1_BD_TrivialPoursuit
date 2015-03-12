namespace ClassesQuestionnaires
{
   partial class Gestion
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
         this.DGV_Question = new System.Windows.Forms.DataGridView();
         this.BTN_Ajouter = new System.Windows.Forms.Button();
         this.BTN_Modifier = new System.Windows.Forms.Button();
         this.BTN_Supprimer = new System.Windows.Forms.Button();
         this.BTN_NMotPasse = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Question)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // DGV_Question
         // 
         this.DGV_Question.AllowUserToAddRows = false;
         this.DGV_Question.AllowUserToDeleteRows = false;
         this.DGV_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.DGV_Question.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.DGV_Question.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.DGV_Question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DGV_Question.Location = new System.Drawing.Point(12, 63);
         this.DGV_Question.MultiSelect = false;
         this.DGV_Question.Name = "DGV_Question";
         this.DGV_Question.ReadOnly = true;
         this.DGV_Question.RowHeadersVisible = false;
         this.DGV_Question.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.DGV_Question.Size = new System.Drawing.Size(388, 251);
         this.DGV_Question.TabIndex = 4;
         this.DGV_Question.SelectionChanged += new System.EventHandler(this.DGV_Question_SelectionChanged);
         // 
         // BTN_Ajouter
         // 
         this.BTN_Ajouter.Location = new System.Drawing.Point(6, 16);
         this.BTN_Ajouter.Name = "BTN_Ajouter";
         this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
         this.BTN_Ajouter.TabIndex = 1;
         this.BTN_Ajouter.Text = "Ajouter";
         this.BTN_Ajouter.UseVisualStyleBackColor = true;
         this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
         // 
         // BTN_Modifier
         // 
         this.BTN_Modifier.Location = new System.Drawing.Point(87, 16);
         this.BTN_Modifier.Name = "BTN_Modifier";
         this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
         this.BTN_Modifier.TabIndex = 2;
         this.BTN_Modifier.Text = "Modifier";
         this.BTN_Modifier.UseVisualStyleBackColor = true;
         this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
         // 
         // BTN_Supprimer
         // 
         this.BTN_Supprimer.Location = new System.Drawing.Point(168, 16);
         this.BTN_Supprimer.Name = "BTN_Supprimer";
         this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
         this.BTN_Supprimer.TabIndex = 3;
         this.BTN_Supprimer.Text = "Supprimer";
         this.BTN_Supprimer.UseVisualStyleBackColor = true;
         this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
         // 
         // BTN_NMotPasse
         // 
         this.BTN_NMotPasse.Location = new System.Drawing.Point(6, 16);
         this.BTN_NMotPasse.Name = "BTN_NMotPasse";
         this.BTN_NMotPasse.Size = new System.Drawing.Size(122, 23);
         this.BTN_NMotPasse.TabIndex = 5;
         this.BTN_NMotPasse.Text = "Changer mot de passe";
         this.BTN_NMotPasse.UseVisualStyleBackColor = true;
         this.BTN_NMotPasse.Click += new System.EventHandler(this.BTN_NMotPasse_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.BTN_NMotPasse);
         this.groupBox1.Location = new System.Drawing.Point(10, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(134, 45);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Administateur";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.BTN_Ajouter);
         this.groupBox2.Controls.Add(this.BTN_Modifier);
         this.groupBox2.Controls.Add(this.BTN_Supprimer);
         this.groupBox2.Location = new System.Drawing.Point(150, 12);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(250, 45);
         this.groupBox2.TabIndex = 6;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Gestion";
         // 
         // Gestion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(412, 326);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.DGV_Question);
         this.MinimumSize = new System.Drawing.Size(428, 103);
         this.Name = "Gestion";
         this.Text = "Gestion";
         this.Load += new System.EventHandler(this.Gestion_Load);
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Question)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView DGV_Question;
      private System.Windows.Forms.Button BTN_Ajouter;
      private System.Windows.Forms.Button BTN_Modifier;
      private System.Windows.Forms.Button BTN_Supprimer;
      private System.Windows.Forms.Button BTN_NMotPasse;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
   }
}