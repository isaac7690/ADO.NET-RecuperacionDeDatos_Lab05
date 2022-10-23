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
    public partial class frmFacturasxFechas : Form
    {
        DAOVendedor objDAO = new DAOVendedor();
        public frmFacturasxFechas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime f1 = dtFecha1.Value;
            DateTime f2 = dtFecha2.Value;

            dgVendedores.DataSource = objDAO.listadoFacturasxFechas(f1, f2);
        }
    }
}
