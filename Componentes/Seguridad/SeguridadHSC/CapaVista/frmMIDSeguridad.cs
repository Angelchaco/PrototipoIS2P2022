using System;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControladorSeguridadHSC;
using static datosUsuario;
//Forma Creada por Roberto Lopez 0901-18-4982
namespace CapaVistaSeguridadHSC
{
    public partial class frmMIDSeguridad : Form
    {
        private ObtenerPermisos global = new ObtenerPermisos();

        public frmMIDSeguridad()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
        //Kevin Flores 9959-18-17632
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                //Jorge González 0901-18-3920

                bitacora.guardarEnBitacora(IdUsuario, "1", "0001", "Cerrar sesión");
                txtUsuario.Text = form.usuario();
            }
            else { this.Close(); }
        }


        private void btnPerfiles_Click(object sender, EventArgs e)
        {
           /* frmMantenimientoPerfil form3 = new frmMantenimientoPerfil();
            form3.MdiParent = this;
            //Jorge González 0901-18-3920
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form3.Show();*/
        }
       
        private void btnCambioContraseña_Click(object sender, EventArgs e)
        {
           /*frmCambioContraseña form3 = new frmCambioContraseña();
            form3.MdiParent = this;
            //Jorge González 0901-18-3920
            bitacora.guardarEnBitacora(IdUsuario, "1", "0010", "Entrada a la Vista");
            form3.Show();*/
        }

        private void btnAsiginaciónDePerfilesAUsuarios_Click(object sender, EventArgs e)
        {
            /*frmPerfiles form3 = new frmPerfiles();
            form3.MdiParent = this;
            //Jorge González 0901-18-3920
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Asignación de Perfiles a Usuarios");
            form3.Show();*/
        }
        
        private void bitácoraDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitacora.guardarEnBitacora(IdUsuario, "1", "0011", "Entrada a la Vista");
            frmBitacora form3 = new frmBitacora();
            form3.MdiParent = this;
            //Jorge González 0901-18-3920
            form3.Show();
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmLoginHSC_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                global.usuarioglobal = txtUsuario.Text;
            }
            else
            {
                this.Close();
            }
        }

        private void mantenimientosVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

           frmVendedores form = new frmVendedores();
           form.MdiParent = this;
           bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
           form.Show();

        }

        private void mantenimientosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente form = new frmCliente();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form.Show();
        }

        private void mantenimientosMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas form = new frmMarcas();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form.Show();
        }

        private void mantenimientosLineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLineas form = new frmLineas();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form.Show();
        }

        private void mantenimientosBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBodega form = new frmBodega();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form.Show();
        }

        private void mantenimientosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form.Show();
        }

        private void mantenimientosExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExistencias form = new frmExistencias();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0007", "Entrada a la Vista");
            form.Show();
        }
    }
}