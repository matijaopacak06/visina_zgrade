namespace visina_zgrade2
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
            this.txtBrojKatova = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisinaZgrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrojKatova
            // 
            this.txtBrojKatova.Location = new System.Drawing.Point(168, 25);
            this.txtBrojKatova.Multiline = true;
            this.txtBrojKatova.Name = "txtBrojKatova";
            this.txtBrojKatova.Size = new System.Drawing.Size(123, 56);
            this.txtBrojKatova.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "broj katova";
            // 
            // txtVisinaZgrade
            // 
            this.txtVisinaZgrade.Location = new System.Drawing.Point(205, 204);
            this.txtVisinaZgrade.Name = "txtVisinaZgrade";
            this.txtVisinaZgrade.Size = new System.Drawing.Size(100, 26);
            this.txtVisinaZgrade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Visina zgrade";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(140, 113);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(109, 54);
            this.btnIzracunaj.TabIndex = 5;
            this.btnIzracunaj.Text = "IZRACUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVisinaZgrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojKatova);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojKatova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisinaZgrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzracunaj;
    }
}

