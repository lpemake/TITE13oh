namespace OsallistujaForms
{
    partial class OsallistujaLista
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
            this.listBoxOsallistujat = new System.Windows.Forms.ListBox();
            this.buttonLisaa = new System.Windows.Forms.Button();
            this.buttonPoista = new System.Windows.Forms.Button();
            this.buttonMuuta = new System.Windows.Forms.Button();
            this.buttonTulosta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOsallistujat
            // 
            this.listBoxOsallistujat.FormattingEnabled = true;
            this.listBoxOsallistujat.Location = new System.Drawing.Point(13, 13);
            this.listBoxOsallistujat.Name = "listBoxOsallistujat";
            this.listBoxOsallistujat.Size = new System.Drawing.Size(240, 420);
            this.listBoxOsallistujat.TabIndex = 0;
            // 
            // buttonLisaa
            // 
            this.buttonLisaa.Location = new System.Drawing.Point(259, 13);
            this.buttonLisaa.Name = "buttonLisaa";
            this.buttonLisaa.Size = new System.Drawing.Size(75, 23);
            this.buttonLisaa.TabIndex = 1;
            this.buttonLisaa.Text = "Lisää";
            this.buttonLisaa.UseVisualStyleBackColor = true;
            this.buttonLisaa.Click += new System.EventHandler(this.buttonLisaa_Click);
            // 
            // buttonPoista
            // 
            this.buttonPoista.Location = new System.Drawing.Point(260, 43);
            this.buttonPoista.Name = "buttonPoista";
            this.buttonPoista.Size = new System.Drawing.Size(75, 23);
            this.buttonPoista.TabIndex = 2;
            this.buttonPoista.Text = "Poista";
            this.buttonPoista.UseVisualStyleBackColor = true;
            // 
            // buttonMuuta
            // 
            this.buttonMuuta.Location = new System.Drawing.Point(260, 73);
            this.buttonMuuta.Name = "buttonMuuta";
            this.buttonMuuta.Size = new System.Drawing.Size(75, 23);
            this.buttonMuuta.TabIndex = 3;
            this.buttonMuuta.Text = "Muuta";
            this.buttonMuuta.UseVisualStyleBackColor = true;
            this.buttonMuuta.Click += new System.EventHandler(this.buttonMuuta_Click);
            // 
            // buttonTulosta
            // 
            this.buttonTulosta.Location = new System.Drawing.Point(260, 103);
            this.buttonTulosta.Name = "buttonTulosta";
            this.buttonTulosta.Size = new System.Drawing.Size(75, 23);
            this.buttonTulosta.TabIndex = 4;
            this.buttonTulosta.Text = "Tulosta";
            this.buttonTulosta.UseVisualStyleBackColor = true;
            // 
            // OsallistujaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 447);
            this.Controls.Add(this.buttonTulosta);
            this.Controls.Add(this.buttonMuuta);
            this.Controls.Add(this.buttonPoista);
            this.Controls.Add(this.buttonLisaa);
            this.Controls.Add(this.listBoxOsallistujat);
            this.Name = "OsallistujaLista";
            this.Text = "Osallistujat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOsallistujat;
        private System.Windows.Forms.Button buttonLisaa;
        private System.Windows.Forms.Button buttonPoista;
        private System.Windows.Forms.Button buttonMuuta;
        private System.Windows.Forms.Button buttonTulosta;
    }
}

