using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjLaboratorio05_Consultas
{
    public partial class frmVendedorInicial : Form
    {
        DAOVendedor objDAO = new DAOVendedor();
        public frmVendedorInicial()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string ini = txtNombre.Text;
            dgVendedores.DataSource = objDAO.listadoVendedorxInicial(ini);
        }

    }
}
