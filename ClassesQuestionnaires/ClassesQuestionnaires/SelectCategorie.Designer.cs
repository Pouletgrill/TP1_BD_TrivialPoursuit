namespace ClassesQuestionnaires
{
    partial class SelectCategorie
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
            this.PNL_Science = new System.Windows.Forms.Panel();
            this.PNL_Histoire = new System.Windows.Forms.Panel();
            this.PNL_Geographie = new System.Windows.Forms.Panel();
            this.PNL_Cinema = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PNL_Science
            // 
            this.PNL_Science.BackColor = System.Drawing.Color.DarkSalmon;
            this.PNL_Science.Location = new System.Drawing.Point(12, 12);
            this.PNL_Science.Name = "PNL_Science";
            this.PNL_Science.Size = new System.Drawing.Size(50, 50);
            this.PNL_Science.TabIndex = 0;
            this.PNL_Science.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.PNL_Science.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.PNL_Science.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            this.PNL_Science.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // PNL_Histoire
            // 
            this.PNL_Histoire.BackColor = System.Drawing.Color.LawnGreen;
            this.PNL_Histoire.Location = new System.Drawing.Point(68, 12);
            this.PNL_Histoire.Name = "PNL_Histoire";
            this.PNL_Histoire.Size = new System.Drawing.Size(50, 50);
            this.PNL_Histoire.TabIndex = 1;
            this.PNL_Histoire.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.PNL_Histoire.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.PNL_Histoire.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            this.PNL_Histoire.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // PNL_Geographie
            // 
            this.PNL_Geographie.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PNL_Geographie.Location = new System.Drawing.Point(12, 68);
            this.PNL_Geographie.Name = "PNL_Geographie";
            this.PNL_Geographie.Size = new System.Drawing.Size(50, 50);
            this.PNL_Geographie.TabIndex = 2;
            this.PNL_Geographie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.PNL_Geographie.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.PNL_Geographie.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            this.PNL_Geographie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // PNL_Cinema
            // 
            this.PNL_Cinema.BackColor = System.Drawing.Color.Yellow;
            this.PNL_Cinema.Location = new System.Drawing.Point(68, 68);
            this.PNL_Cinema.Name = "PNL_Cinema";
            this.PNL_Cinema.Size = new System.Drawing.Size(50, 50);
            this.PNL_Cinema.TabIndex = 3;
            this.PNL_Cinema.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.PNL_Cinema.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.PNL_Cinema.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            this.PNL_Cinema.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // SelectCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 131);
            this.Controls.Add(this.PNL_Cinema);
            this.Controls.Add(this.PNL_Geographie);
            this.Controls.Add(this.PNL_Histoire);
            this.Controls.Add(this.PNL_Science);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectCategorie";
            this.Text = "SelectCategorie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Science;
        private System.Windows.Forms.Panel PNL_Histoire;
        private System.Windows.Forms.Panel PNL_Geographie;
        private System.Windows.Forms.Panel PNL_Cinema;
    }
}