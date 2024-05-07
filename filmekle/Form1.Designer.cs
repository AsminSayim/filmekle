namespace filmekle
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
            this.FilmEkle = new System.Windows.Forms.Button();
            this.FilmListesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmEkle
            // 
            this.FilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FilmEkle.Location = new System.Drawing.Point(43, 96);
            this.FilmEkle.Name = "FilmEkle";
            this.FilmEkle.Size = new System.Drawing.Size(188, 134);
            this.FilmEkle.TabIndex = 0;
            this.FilmEkle.Text = "Film Ekle";
            this.FilmEkle.UseVisualStyleBackColor = true;
            this.FilmEkle.Click += new System.EventHandler(this.FilmEkle_Click);
            // 
            // FilmListesi
            // 
            this.FilmListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FilmListesi.Location = new System.Drawing.Point(306, 96);
            this.FilmListesi.Name = "FilmListesi";
            this.FilmListesi.Size = new System.Drawing.Size(188, 134);
            this.FilmListesi.TabIndex = 1;
            this.FilmListesi.Text = "Film Listesi";
            this.FilmListesi.UseVisualStyleBackColor = true;
            this.FilmListesi.Click += new System.EventHandler(this.FilmListesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 365);
            this.Controls.Add(this.FilmListesi);
            this.Controls.Add(this.FilmEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FilmEkle;
        private System.Windows.Forms.Button FilmListesi;
    }
}

