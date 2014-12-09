namespace OsallistujaForms
{
    partial class OsallistujaLomake
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
            this.textBoxSukunimi = new System.Windows.Forms.TextBox();
            this.textBoxEtunimi = new System.Windows.Forms.TextBox();
            this.textBoxPuhelinnumero = new System.Windows.Forms.TextBox();
            this.radioButtonMies = new System.Windows.Forms.RadioButton();
            this.radioButtonNainen = new System.Windows.Forms.RadioButton();
            this.groupBoxSukupuoli = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPeruuta = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxSukupuoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSukunimi
            // 
            this.textBoxSukunimi.Location = new System.Drawing.Point(120, 12);
            this.textBoxSukunimi.Name = "textBoxSukunimi";
            this.textBoxSukunimi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSukunimi.TabIndex = 0;
            // 
            // textBoxEtunimi
            // 
            this.textBoxEtunimi.Location = new System.Drawing.Point(120, 39);
            this.textBoxEtunimi.Name = "textBoxEtunimi";
            this.textBoxEtunimi.Size = new System.Drawing.Size(100, 20);
            this.textBoxEtunimi.TabIndex = 1;
            // 
            // textBoxPuhelinnumero
            // 
            this.textBoxPuhelinnumero.Location = new System.Drawing.Point(120, 66);
            this.textBoxPuhelinnumero.Name = "textBoxPuhelinnumero";
            this.textBoxPuhelinnumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuhelinnumero.TabIndex = 2;
            // 
            // radioButtonMies
            // 
            this.radioButtonMies.AutoSize = true;
            this.radioButtonMies.Location = new System.Drawing.Point(17, 34);
            this.radioButtonMies.Name = "radioButtonMies";
            this.radioButtonMies.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMies.TabIndex = 3;
            this.radioButtonMies.TabStop = true;
            this.radioButtonMies.Text = "Mies";
            this.radioButtonMies.UseVisualStyleBackColor = true;
            // 
            // radioButtonNainen
            // 
            this.radioButtonNainen.AutoSize = true;
            this.radioButtonNainen.Location = new System.Drawing.Point(17, 57);
            this.radioButtonNainen.Name = "radioButtonNainen";
            this.radioButtonNainen.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNainen.TabIndex = 4;
            this.radioButtonNainen.TabStop = true;
            this.radioButtonNainen.Text = "Nainen";
            this.radioButtonNainen.UseVisualStyleBackColor = true;
            // 
            // groupBoxSukupuoli
            // 
            this.groupBoxSukupuoli.Controls.Add(this.radioButtonMies);
            this.groupBoxSukupuoli.Controls.Add(this.radioButtonNainen);
            this.groupBoxSukupuoli.Location = new System.Drawing.Point(20, 116);
            this.groupBoxSukupuoli.Name = "groupBoxSukupuoli";
            this.groupBoxSukupuoli.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSukupuoli.TabIndex = 5;
            this.groupBoxSukupuoli.TabStop = false;
            this.groupBoxSukupuoli.Text = "Sukupuoli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sukunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Etunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puhelinnumero";
            // 
            // buttonPeruuta
            // 
            this.buttonPeruuta.Location = new System.Drawing.Point(23, 247);
            this.buttonPeruuta.Name = "buttonPeruuta";
            this.buttonPeruuta.Size = new System.Drawing.Size(75, 23);
            this.buttonPeruuta.TabIndex = 9;
            this.buttonPeruuta.Text = "Peruuta";
            this.buttonPeruuta.UseVisualStyleBackColor = true;
            this.buttonPeruuta.Click += new System.EventHandler(this.buttonPeruuta_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(145, 247);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // OsallistujaLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 282);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonPeruuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPuhelinnumero);
            this.Controls.Add(this.textBoxEtunimi);
            this.Controls.Add(this.textBoxSukunimi);
            this.Controls.Add(this.groupBoxSukupuoli);
            this.Name = "OsallistujaLomake";
            this.Text = "OsallistujaLomake";
            this.Load += new System.EventHandler(this.OsallistujaLomake_Load);
            this.groupBoxSukupuoli.ResumeLayout(false);
            this.groupBoxSukupuoli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSukunimi;
        private System.Windows.Forms.TextBox textBoxEtunimi;
        private System.Windows.Forms.TextBox textBoxPuhelinnumero;
        private System.Windows.Forms.RadioButton radioButtonMies;
        private System.Windows.Forms.RadioButton radioButtonNainen;
        private System.Windows.Forms.GroupBox groupBoxSukupuoli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPeruuta;
        private System.Windows.Forms.Button buttonOK;
    }
}