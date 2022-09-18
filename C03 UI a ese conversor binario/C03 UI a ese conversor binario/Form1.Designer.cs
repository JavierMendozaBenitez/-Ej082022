namespace C03_UI_a_ese_conversor_binario
{
    partial class Form1
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
            this.lblBinADec = new System.Windows.Forms.Label();
            this.lblDecABin = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinADec
            // 
            this.lblBinADec.AutoSize = true;
            this.lblBinADec.Location = new System.Drawing.Point(12, 23);
            this.lblBinADec.Name = "lblBinADec";
            this.lblBinADec.Size = new System.Drawing.Size(99, 15);
            this.lblBinADec.TabIndex = 0;
            this.lblBinADec.Text = "Binario a Decimal";
            // 
            // lblDecABin
            // 
            this.lblDecABin.AutoSize = true;
            this.lblDecABin.Location = new System.Drawing.Point(12, 60);
            this.lblDecABin.Name = "lblDecABin";
            this.lblDecABin.Size = new System.Drawing.Size(99, 15);
            this.lblDecABin.TabIndex = 1;
            this.lblDecABin.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(134, 20);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 23);
            this.txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(134, 57);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 23);
            this.txtDecimal.TabIndex = 3;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(267, 20);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(75, 23);
            this.btnBinToDec.TabIndex = 4;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(267, 57);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btnDecToBin.TabIndex = 5;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Location = new System.Drawing.Point(387, 60);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoBin.TabIndex = 6;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Location = new System.Drawing.Point(387, 20);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDec.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 111);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecABin);
            this.Controls.Add(this.lblBinADec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinADec;
        private System.Windows.Forms.Label lblDecABin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
    }
}
