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
    public partial class frmExistencias : Form
    {
        public frmExistencias()
        {
            InitializeComponent();

			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "existencias", "SIC");
			navegador1.MetodoSalirVista(this);
			navegador1.LlenarCombobox(cbxCodBodega, "bodegas", "codigo_bodega", "nombre_bodega", "estatus_bodega");
			navegador1.LlenarCombobox(cbxCodProd, "productos", "codigo_producto", "nombre_producto", "estatus_producto");
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

        private void frmExistencias_Load(object sender, EventArgs e)
        {

        }

        private void cbxCodBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.EnviarDatoComboaTextbox(cbxCodBodega, txtCodBodega);
		}

        private void txtCodBodega_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxCodBodega, txtCodBodega);
		}

        private void cbxCodProd_SelectedIndexChanged(object sender, EventArgs e)
        {
			navegador1.EnviarDatoComboaTextbox(cbxCodProd, txtCodProd);
		}

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {
			navegador1.SeleccionarElementosenCombo(cbxCodProd, txtCodProd);
		}
    }
}
