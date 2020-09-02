namespace USteuerbetrag
{
    partial class Form1
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
            this.CmdBerechne = new System.Windows.Forms.Button();
            this.LblGehalt = new System.Windows.Forms.Label();
            this.LblSteuerbetrag = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdBerechne
            // 
            this.CmdBerechne.Location = new System.Drawing.Point(21, 158);
            this.CmdBerechne.Name = "CmdBerechne";
            this.CmdBerechne.Size = new System.Drawing.Size(100, 38);
            this.CmdBerechne.TabIndex = 0;
            this.CmdBerechne.Text = "Berechne";
            this.CmdBerechne.UseVisualStyleBackColor = true;
            this.CmdBerechne.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblGehalt
            // 
            this.LblGehalt.AutoSize = true;
            this.LblGehalt.Location = new System.Drawing.Point(16, 53);
            this.LblGehalt.Name = "LblGehalt";
            this.LblGehalt.Size = new System.Drawing.Size(81, 25);
            this.LblGehalt.TabIndex = 1;
            this.LblGehalt.Text = "Gehalt:";
            this.LblGehalt.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSteuerbetrag
            // 
            this.LblSteuerbetrag.AutoSize = true;
            this.LblSteuerbetrag.Location = new System.Drawing.Point(147, 99);
            this.LblSteuerbetrag.Name = "LblSteuerbetrag";
            this.LblSteuerbetrag.Size = new System.Drawing.Size(0, 25);
            this.LblSteuerbetrag.TabIndex = 2;
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(21, 93);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 31);
            this.TxtEingabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.LblSteuerbetrag);
            this.Controls.Add(this.LblGehalt);
            this.Controls.Add(this.CmdBerechne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBerechne;
        private System.Windows.Forms.Label LblGehalt;
        private System.Windows.Forms.Label LblSteuerbetrag;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

