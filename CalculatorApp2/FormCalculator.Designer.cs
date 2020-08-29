namespace CalculatorApp2
{
    partial class FormCalculator
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
            this.numericUpDownTermen1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTermen2 = new System.Windows.Forms.NumericUpDown();
            this.butonAdunare = new System.Windows.Forms.Button();
            this.butonScadere = new System.Windows.Forms.Button();
            this.butonInmultire = new System.Windows.Forms.Button();
            this.butonImpartire = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTermen1
            // 
            this.numericUpDownTermen1.Location = new System.Drawing.Point(190, 72);
            this.numericUpDownTermen1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTermen1.Name = "numericUpDownTermen1";
            this.numericUpDownTermen1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTermen1.TabIndex = 0;
            // 
            // numericUpDownTermen2
            // 
            this.numericUpDownTermen2.Location = new System.Drawing.Point(449, 72);
            this.numericUpDownTermen2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTermen2.Name = "numericUpDownTermen2";
            this.numericUpDownTermen2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTermen2.TabIndex = 1;
            // 
            // butonAdunare
            // 
            this.butonAdunare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butonAdunare.Location = new System.Drawing.Point(108, 167);
            this.butonAdunare.Name = "butonAdunare";
            this.butonAdunare.Size = new System.Drawing.Size(103, 37);
            this.butonAdunare.TabIndex = 2;
            this.butonAdunare.Text = "adunare";
            this.butonAdunare.UseVisualStyleBackColor = false;
            this.butonAdunare.Click += new System.EventHandler(this.butonAdunare_Click);
            // 
            // butonScadere
            // 
            this.butonScadere.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butonScadere.Location = new System.Drawing.Point(280, 167);
            this.butonScadere.Name = "butonScadere";
            this.butonScadere.Size = new System.Drawing.Size(103, 37);
            this.butonScadere.TabIndex = 3;
            this.butonScadere.Text = "scadere";
            this.butonScadere.UseVisualStyleBackColor = false;
            this.butonScadere.Click += new System.EventHandler(this.butonScadere_Click);
            // 
            // butonInmultire
            // 
            this.butonInmultire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butonInmultire.Location = new System.Drawing.Point(449, 167);
            this.butonInmultire.Name = "butonInmultire";
            this.butonInmultire.Size = new System.Drawing.Size(103, 37);
            this.butonInmultire.TabIndex = 4;
            this.butonInmultire.Text = "inmultire";
            this.butonInmultire.UseVisualStyleBackColor = false;
            this.butonInmultire.Click += new System.EventHandler(this.butonInmultire_Click);
            // 
            // butonImpartire
            // 
            this.butonImpartire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butonImpartire.Location = new System.Drawing.Point(606, 167);
            this.butonImpartire.Name = "butonImpartire";
            this.butonImpartire.Size = new System.Drawing.Size(103, 37);
            this.butonImpartire.TabIndex = 5;
            this.butonImpartire.Text = "impartire";
            this.butonImpartire.UseVisualStyleBackColor = false;
            this.butonImpartire.Click += new System.EventHandler(this.butonImpartire_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Enabled = false;
            this.textBoxRezultat.Location = new System.Drawing.Point(258, 346);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(311, 20);
            this.textBoxRezultat.TabIndex = 6;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.butonImpartire);
            this.Controls.Add(this.butonInmultire);
            this.Controls.Add(this.butonScadere);
            this.Controls.Add(this.butonAdunare);
            this.Controls.Add(this.numericUpDownTermen2);
            this.Controls.Add(this.numericUpDownTermen1);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTermen1;
        private System.Windows.Forms.NumericUpDown numericUpDownTermen2;
        private System.Windows.Forms.Button butonAdunare;
        private System.Windows.Forms.Button butonScadere;
        private System.Windows.Forms.Button butonInmultire;
        private System.Windows.Forms.Button butonImpartire;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}