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
    public partial class frmVendedorxDistrito : Form
    {
        DAOVendedor objDAO = new DAOVendedor();
        public frmVendedorxDistrito()
        {
            InitializeComponent();
        }
        private void frmVendedorxDistrito_Load(object sender, EventArgs e)
        {
            dgVendedores.DataSource = objDAO.listadoGeneral();

            cboDistrito.DataSource = objDAO.listadoDistritos();
            cboDistrito.DisplayMember = "nom_dis";
            cboDistrito.ValueMember = "ide_dis";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Vendedor objV = new Vendedor();
            objV.ide_dis = int.Parse(cboDistrito.SelectedValue.ToString());
            dgVendedores.DataSource = objDAO.listadoVendedoresxDistrito(objV);
        }
    }
}
