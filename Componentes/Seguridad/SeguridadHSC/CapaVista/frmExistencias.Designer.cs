
namespace CapaVistaSeguridadHSC
{
    partial class frmExistencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.cbxCodProd = new System.Windows.Forms.ComboBox();
            this.txtCodBodega = new System.Windows.Forms.TextBox();
            this.cbxCodBodega = new System.Windows.Forms.ComboBox();
            this.navegador1 = new DLL.nav.navegador();
            this.txtSaldoE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(381, 144);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.Size = new System.Drawing.Size(744, 281);
            this.dgvVistaPrevia.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 169;
            this.label4.Text = "Saldo Existencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 168;
            this.label2.Text = "Cod Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 166;
            this.label1.Text = "Cod Bodega";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(262, 252);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(43, 20);
            this.txtCodProd.TabIndex = 174;
            this.txtCodProd.Tag = "codigo_producto";
            this.txtCodProd.Visible = false;
            this.txtCodProd.TextChanged += new System.EventHandler(this.txtCodProd_TextChanged);
            // 
            // cbxCodProd
            // 
            this.cbxCodProd.FormattingEnabled = true;
            this.cbxCodProd.Location = new System.Drawing.Point(135, 251);
            this.cbxCodProd.Name = "cbxCodProd";
            this.cbxCodProd.Size = new System.Drawing.Size(121, 21);
            this.cbxCodProd.TabIndex = 173;
            this.cbxCodProd.SelectedIndexChanged += new System.EventHandler(this.cbxCodProd_SelectedIndexChanged);
            // 
            // txtCodBodega
            // 
            this.txtCodBodega.Location = new System.Drawing.Point(262, 214);
            this.txtCodBodega.Name = "txtCodBodega";
            this.txtCodBodega.Size = new System.Drawing.Size(43, 20);
            this.txtCodBodega.TabIndex = 176;
            this.txtCodBodega.Tag = "codigo_bodega";
            this.txtCodBodega.Visible = false;
            this.txtCodBodega.TextChanged += new System.EventHandler(this.txtCodBodega_TextChanged);
            // 
            // cbxCodBodega
            // 
            this.cbxCodBodega.FormattingEnabled = true;
            this.cbxCodBodega.Location = new System.Drawing.Point(135, 213);
            this.cbxCodBodega.Name = "cbxCodBodega";
            this.cbxCodBodega.Size = new System.Drawing.Size(121, 21);
            this.cbxCodBodega.TabIndex = 175;
            this.cbxCodBodega.SelectedIndexChanged += new System.EventHandler(this.cbxCodBodega_SelectedIndexChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-4, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 177;
            // 
            // txtSaldoE
            // 
            this.txtSaldoE.Location = new System.Drawing.Point(135, 306);
            this.txtSaldoE.Name = "txtSaldoE";
            this.txtSaldoE.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoE.TabIndex = 178;
            this.txtSaldoE.Tag = "saldo_existencia";
            // 
            // frmExistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.txtSaldoE);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.txtCodBodega);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cbxCodBodega);
            this.Controls.Add(this.cbxCodProd);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExistencias";
            this.Load += new System.EventHandler(this.frmExistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.ComboBox cbxCodProd;
        private System.Windows.Forms.TextBox txtCodBodega;
        private System.Windows.Forms.ComboBox cbxCodBodega;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtSaldoE;
    }
}