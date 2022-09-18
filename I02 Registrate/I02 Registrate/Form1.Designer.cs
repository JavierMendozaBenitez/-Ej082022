namespace I02_Registrate
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
            this.gpDetallesDelUsuario = new System.Windows.Forms.GroupBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gpGenero = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.gpCursos = new System.Windows.Forms.GroupBox();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.cbCMasMas = new System.Windows.Forms.CheckBox();
            this.cbJavaScript = new System.Windows.Forms.CheckBox();
            this.lbPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gpDetallesDelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gpGenero.SuspendLayout();
            this.gpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDetallesDelUsuario
            // 
            this.gpDetallesDelUsuario.Controls.Add(this.lblEdad);
            this.gpDetallesDelUsuario.Controls.Add(this.lblDireccion);
            this.gpDetallesDelUsuario.Controls.Add(this.lblNombre);
            this.gpDetallesDelUsuario.Controls.Add(this.nudEdad);
            this.gpDetallesDelUsuario.Controls.Add(this.tbDireccion);
            this.gpDetallesDelUsuario.Controls.Add(this.tbNombre);
            this.gpDetallesDelUsuario.Location = new System.Drawing.Point(12, 12);
            this.gpDetallesDelUsuario.Name = "gpDetallesDelUsuario";
            this.gpDetallesDelUsuario.Size = new System.Drawing.Size(204, 122);
            this.gpDetallesDelUsuario.TabIndex = 0;
            this.gpDetallesDelUsuario.TabStop = false;
            this.gpDetallesDelUsuario.Text = "Detalles del usuario";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(98, 22);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 23);
            this.tbNombre.TabIndex = 0;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(98, 51);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 23);
            this.tbDireccion.TabIndex = 1;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(98, 80);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(14, 51);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(14, 80);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // gpGenero
            // 
            this.gpGenero.Controls.Add(this.rbNoBinario);
            this.gpGenero.Controls.Add(this.rbFemenino);
            this.gpGenero.Controls.Add(this.rbMasculino);
            this.gpGenero.Location = new System.Drawing.Point(281, 12);
            this.gpGenero.Name = "gpGenero";
            this.gpGenero.Size = new System.Drawing.Size(114, 122);
            this.gpGenero.TabIndex = 1;
            this.gpGenero.TabStop = false;
            this.gpGenero.Text = "Género";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(6, 55);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(6, 80);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // gpCursos
            // 
            this.gpCursos.Controls.Add(this.cbJavaScript);
            this.gpCursos.Controls.Add(this.cbCMasMas);
            this.gpCursos.Controls.Add(this.cbCSharp);
            this.gpCursos.Location = new System.Drawing.Point(281, 140);
            this.gpCursos.Name = "gpCursos";
            this.gpCursos.Size = new System.Drawing.Size(114, 100);
            this.gpCursos.TabIndex = 2;
            this.gpCursos.TabStop = false;
            this.gpCursos.Text = "Cursos";
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(17, 22);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(41, 19);
            this.cbCSharp.TabIndex = 0;
            this.cbCSharp.Text = "C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // cbCMasMas
            // 
            this.cbCMasMas.AutoSize = true;
            this.cbCMasMas.Location = new System.Drawing.Point(17, 47);
            this.cbCMasMas.Name = "cbCMasMas";
            this.cbCMasMas.Size = new System.Drawing.Size(50, 19);
            this.cbCMasMas.TabIndex = 1;
            this.cbCMasMas.Text = "C++";
            this.cbCMasMas.UseVisualStyleBackColor = true;
            // 
            // cbJavaScript
            // 
            this.cbJavaScript.AutoSize = true;
            this.cbJavaScript.Location = new System.Drawing.Point(17, 72);
            this.cbJavaScript.Name = "cbJavaScript";
            this.cbJavaScript.Size = new System.Drawing.Size(78, 19);
            this.cbJavaScript.TabIndex = 2;
            this.cbJavaScript.Text = "JavaScript";
            this.cbJavaScript.UseVisualStyleBackColor = true;
            // 
            // lbPaises
            // 
            this.lbPaises.FormattingEnabled = true;
            this.lbPaises.ItemHeight = 15;
            this.lbPaises.Location = new System.Drawing.Point(12, 162);
            this.lbPaises.Name = "lbPaises";
            this.lbPaises.Size = new System.Drawing.Size(204, 94);
            this.lbPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 137);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(287, 246);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 277);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lbPaises);
            this.Controls.Add(this.gpCursos);
            this.Controls.Add(this.gpGenero);
            this.Controls.Add(this.gpDetallesDelUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpDetallesDelUsuario.ResumeLayout(false);
            this.gpDetallesDelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gpGenero.ResumeLayout(false);
            this.gpGenero.PerformLayout();
            this.gpCursos.ResumeLayout(false);
            this.gpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDetallesDelUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox gpGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gpCursos;
        private System.Windows.Forms.CheckBox cbJavaScript;
        private System.Windows.Forms.CheckBox cbCMasMas;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.ListBox lbPaises;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
