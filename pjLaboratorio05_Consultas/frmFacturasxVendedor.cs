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
    public partial class frmFacturasxVendedor : Form
    {
        DAOVendedor objDAO=new DAOVendedor();
        public frmFacturasxVendedor()
        {
            InitializeComponent();
        }

        private void frmFacturasxVendedor_Load(object sender, EventArgs e)
        {
            cboVendedor.DataSource = objDAO.listadoGeneral();
            cboVendedor.DisplayMember = "vendedor";
            cboVendedor.ValueMember = "codigo";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Vendedor objV = new Vendedor();
            objV.ide_ven = int.Parse(cboVendedor.SelectedValue.ToString());
            dgFacturas.DataSource = objDAO.listadoFacturasxVendedor(objV);
        }
    }
}
