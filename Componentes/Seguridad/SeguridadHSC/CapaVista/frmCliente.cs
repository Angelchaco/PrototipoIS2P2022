using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSeguridadHSC
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();

			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "clientes", "SIC");
			navegador1.MetodoSalirVista(this);
			navegador1.LlenarCombobox(cbxCodVend, "vendedores", "codigo_vendedor", "nombre_vendedor", "estatus_vendedor");
			//navegador1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estatus_cliente";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "1";
			navegador1.idmodulo = "1";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegador1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegador1.LlenarTabla();
			navegador1.ObtenerReferenciaFormActual(this);

		}

        private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
		}

        private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
        {
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
		}

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
			navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

        private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
        {
			navegador1.SelecciondeFilaDGV(dgvVistaPrevia);
		}

        private void cbxCodVend_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.EnviarDatoComboaTextbox(cbxCodVend, txtCodVend);
		}

        private void txtCodVend_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxCodVend, txtCodVend);
		}
    }
}
