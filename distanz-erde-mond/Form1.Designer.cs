namespace distanz_erde_mond
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonTage = new System.Windows.Forms.RadioButton();
            this.radioButtonStd = new System.Windows.Forms.RadioButton();
            this.labelGeschwindigkeit = new System.Windows.Forms.Label();
            this.textBoxGeschwindigkeit = new System.Windows.Forms.TextBox();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonTage
            // 
            this.radioButtonTage.AutoSize = true;
            this.radioButtonTage.Location = new System.Drawing.Point(42, 95);
            this.radioButtonTage.Name = "radioButtonTage";
            this.radioButtonTage.Size = new System.Drawing.Size(95, 24);
            this.radioButtonTage.TabIndex = 0;
            this.radioButtonTage.TabStop = true;
            this.radioButtonTage.Text = "in Tagen";
            this.radioButtonTage.UseVisualStyleBackColor = true;
            // 
            // radioButtonStd
            // 
            this.radioButtonStd.AutoSize = true;
            this.radioButtonStd.Location = new System.Drawing.Point(266, 95);
            this.radioButtonStd.Name = "radioButtonStd";
            this.radioButtonStd.Size = new System.Drawing.Size(111, 24);
            this.radioButtonStd.TabIndex = 1;
            this.radioButtonStd.TabStop = true;
            this.radioButtonStd.Text = "in Stunden";
            this.radioButtonStd.UseVisualStyleBackColor = true;
            // 
            // labelGeschwindigkeit
            // 
            this.labelGeschwindigkeit.AutoSize = true;
            this.labelGeschwindigkeit.Location = new System.Drawing.Point(38, 169);
            this.labelGeschwindigkeit.Name = "labelGeschwindigkeit";
            this.labelGeschwindigkeit.Size = new System.Drawing.Size(163, 20);
            this.labelGeschwindigkeit.TabIndex = 2;
            this.labelGeschwindigkeit.Text = "Geschwindigkeit km/h";
            // 
            // textBoxGeschwindigkeit
            // 
            this.textBoxGeschwindigkeit.Location = new System.Drawing.Point(218, 163);
            this.textBoxGeschwindigkeit.Name = "textBoxGeschwindigkeit";
            this.textBoxGeschwindigkeit.Size = new System.Drawing.Size(159, 26);
            this.textBoxGeschwindigkeit.TabIndex = 3;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(42, 232);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(335, 65);
            this.buttonBerechnen.TabIndex = 4;
            this.buttonBerechnen.Text = "Reisedauer zum Mond berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBerechnen);
            this.groupBox1.Controls.Add(this.textBoxGeschwindigkeit);
            this.groupBox1.Controls.Add(this.labelGeschwindigkeit);
            this.groupBox1.Controls.Add(this.radioButtonStd);
            this.groupBox1.Controls.Add(this.radioButtonTage);
            this.groupBox1.Location = new System.Drawing.Point(63, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 324);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reisedauer zum Mond berechnen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ausgabe Reisedauer";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(261, 416);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(222, 26);
            this.textBoxResult.TabIndex = 7;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(489, 2);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(112, 58);
            this.buttonBeenden.TabIndex = 8;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 499);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonTage;
        private System.Windows.Forms.RadioButton radioButtonStd;
        private System.Windows.Forms.Label labelGeschwindigkeit;
        private System.Windows.Forms.TextBox textBoxGeschwindigkeit;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonBeenden;
    }
}

