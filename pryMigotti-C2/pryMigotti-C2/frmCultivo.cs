using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMigotti_C2
{
    public partial class frmCultivo : Form
    {
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre2.Text = "";
            mtbIdentificacion.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
