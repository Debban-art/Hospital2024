using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospital2024
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEmpleados"] != null)
            {
                Application.OpenForms["frmEmpleados"].Activate();
            }
            else
            {
                //Creamos un objeto para el frmEmpleados
                frmEmpleados frmEmpleados = new frmEmpleados();
                frmEmpleados.MdiParent = this;
                frmEmpleados.Show();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Variable para salir del sistema
            DialogResult respuesta = MessageBox.Show("¿Desea salir del sistema?", "Sistema Hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDepartamentos"] != null)
            {
                Application.OpenForms["frmDepartamentos"].Activate();
            }
            else
            {
                frmDepartamentos frmDepartamentos = new frmDepartamentos();
                frmDepartamentos.MdiParent = this;
                frmDepartamentos.Show();
            }


        }

        private void hospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmHospital"] != null)
            {
                Application.OpenForms["frmHospital"].Activate();
            }
            else
            {
                frmHospital frmHospital = new frmHospital();
                frmHospital.MdiParent = this;
                frmHospital.Show();
            }
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSalas"] != null)
            {
                Application.OpenForms["frmSalas"].Activate();
            }
            else
            {
                frmSalas frmSalas = new frmSalas();
                frmSalas.MdiParent = this;
                frmSalas.Show();
            }

        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDoctores"] != null)
            {
                Application.OpenForms["frmDoctores"].Activate();
            }
            else
            {
                frmDoctores frmDoctores = new frmDoctores();
                frmDoctores.MdiParent = this;
                frmDoctores.Show();
            }

        }

        private void plantillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPlantillas"] != null)
            {
                Application.OpenForms["frmPlantillas"].Activate();
            }
            else
            {
                frmPlantillas frmPlantillas = new frmPlantillas();
                frmPlantillas.MdiParent = this;
                frmPlantillas.Show();
            }

        }

        private void enfermosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEnfermos"] != null)
            {
                Application.OpenForms["frmEnfermos"].Activate();
            }
            else
            {
                frmEnfermos frmEnfermos = new frmEnfermos();
                frmEnfermos.MdiParent = this;
                frmEnfermos.Show();
            }

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUsuarios"] != null)
            {
                Application.OpenForms["frmUsuarios"].Activate();
            }
            else
            {
                frmUsuarios frmUsuarios = new frmUsuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
            }

        }
    }
}
