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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void listadoGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)//para que no se duplique la ventana
            {
                childForm1.Close();
            }

            frmListadoGeneral childForm = new frmListadoGeneral();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void vendedoresPorDistritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)//para que no se duplique la ventana
            {
                childForm1.Close();
            }

            frmVendedorxDistrito childForm = new frmVendedorxDistrito();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void facturasPorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)//para que no se duplique la ventana
            {
                childForm1.Close();
            }

            frmFacturasxVendedor childForm = new frmFacturasxVendedor();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void facturasPorRangoDeFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)//para que no se duplique la ventana
            {
                childForm1.Close();
            }

            frmFacturasxFechas childForm = new frmFacturasxFechas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendedorPorInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)//para que no se duplique la ventana
            {
                childForm1.Close();
            }

            frmVendedorInicial childForm = new frmVendedorInicial();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
    }

