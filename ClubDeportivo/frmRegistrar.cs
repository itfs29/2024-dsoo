using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using ClubDeportivo.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
            cmbTipoDoc.Items.AddRange(E_Persona.tipoDocs);
            cmbTipoDoc.SelectedIndex = 0;
            cmbTipoCliente.Items.Add("Socio");
            cmbTipoCliente.Items.Add("NoSocio");
            cmbTipoCliente.SelectedIndex=0;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtApellido.Focus();
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbTipoDoc.Focus();
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbTipoCliente.Focus();
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoCliente.SelectedIndex == 0)
                {
                    E_Socio eSocio = new E_Socio(txtNombre.Text,
                        txtApellido.Text,
                        cmbTipoDoc.Items[cmbTipoDoc.SelectedIndex].ToString(),
                        txtDocumento.Text,
                        chkAptoFisico.Checked);
                    ServicioSocio servicioSocio = new ServicioSocio();
                    servicioSocio.registrar(eSocio);

                }
                else if (cmbTipoCliente.SelectedIndex == 1)
                {
                    E_NoSocio eNoSocio = new E_NoSocio(txtNombre.Text,
                        txtApellido.Text,
                        cmbTipoDoc.Items[cmbTipoDoc.SelectedIndex].ToString(),
                        txtDocumento.Text,
                        chkAptoFisico.Checked);

                    ServicioNoSocio servicioNoSocio = new ServicioNoSocio();
                    servicioNoSocio.registrar(eNoSocio);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ExcepcionGeneral ex)
            {
                MessageBox.Show(ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El cliente fue registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
