namespace Szoveg
{
    partial class Fo_Ablak
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            file_nev_text = new TextBox();
            Beolvas_gomb = new Button();
            szoveg_megjelen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // file_nev_text
            // 
            file_nev_text.Location = new Point(56, 6);
            file_nev_text.Name = "file_nev_text";
            file_nev_text.Size = new Size(100, 23);
            file_nev_text.TabIndex = 1;
            // 
            // Beolvas_gomb
            // 
            Beolvas_gomb.Location = new Point(174, 5);
            Beolvas_gomb.Name = "Beolvas_gomb";
            Beolvas_gomb.Size = new Size(75, 23);
            Beolvas_gomb.TabIndex = 2;
            Beolvas_gomb.Text = "Beolvas";
            Beolvas_gomb.UseVisualStyleBackColor = true;
            Beolvas_gomb.Click += Beolvas_gomb_Click;
            // 
            // szoveg_megjelen
            // 
            szoveg_megjelen.Location = new Point(12, 54);
            szoveg_megjelen.Multiline = true;
            szoveg_megjelen.Name = "szoveg_megjelen";
            szoveg_megjelen.Size = new Size(776, 384);
            szoveg_megjelen.TabIndex = 3;
            // 
            // Fo_Ablak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(szoveg_megjelen);
            Controls.Add(Beolvas_gomb);
            Controls.Add(file_nev_text);
            Controls.Add(label1);
            Name = "Fo_Ablak";
            Text = "Form1";
            Load += Fo_Ablak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox file_nev_text;
        private Button Beolvas_gomb;
        private TextBox szoveg_megjelen;
    }
}
