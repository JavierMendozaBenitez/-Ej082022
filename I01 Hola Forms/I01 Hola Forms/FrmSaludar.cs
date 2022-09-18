using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I01_Hola_Forms
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar(string titulo, string mensaje)
        {
            InitializeComponent();
            this.lblTitulo.Text = titulo;
            this.lblMensaje.Text = mensaje;
        }
    }
}
