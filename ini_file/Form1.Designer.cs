namespace ini_file
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
            this.btnLeesBestand = new System.Windows.Forms.Button();
            this.labelTekstbestand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeesBestand
            // 
            this.btnLeesBestand.Location = new System.Drawing.Point(154, 76);
            this.btnLeesBestand.Name = "btnLeesBestand";
            this.btnLeesBestand.Size = new System.Drawing.Size(75, 23);
            this.btnLeesBestand.TabIndex = 0;
            this.btnLeesBestand.Text = "lees bestand";
            this.btnLeesBestand.UseVisualStyleBackColor = true;
            this.btnLeesBestand.Click += new System.EventHandler(this.btnLeesBestand_Click);
            // 
            // labelTekstbestand
            // 
            this.labelTekstbestand.AutoSize = true;
            this.labelTekstbestand.Location = new System.Drawing.Point(13, 13);
            this.labelTekstbestand.Name = "labelTekstbestand";
            this.labelTekstbestand.Size = new System.Drawing.Size(103, 13);
            this.labelTekstbestand.TabIndex = 1;
            this.labelTekstbestand.Text = "inhoud tekstbestand";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 187);
            this.Controls.Add(this.labelTekstbestand);
            this.Controls.Add(this.btnLeesBestand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeesBestand;
        private System.Windows.Forms.Label labelTekstbestand;
    }
}

