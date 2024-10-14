namespace ClubDeportivo
{
    partial class frmRegistrar
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
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbTipoDoc = new System.Windows.Forms.ComboBox();
            txtDocumento = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            cmbTipoCliente = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            chkAptoFisico = new System.Windows.Forms.CheckBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 14);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(225, 34);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(191, 22);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(225, 74);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(191, 22);
            txtApellido.TabIndex = 3;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 14);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 14);
            label3.TabIndex = 4;
            label3.Text = "Tipo documento";
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new System.Drawing.Point(225, 113);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new System.Drawing.Size(82, 22);
            cmbTipoDoc.TabIndex = 5;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(225, 154);
            txtDocumento.MaxLength = 11;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(191, 22);
            txtDocumento.TabIndex = 7;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(27, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 14);
            label4.TabIndex = 6;
            label4.Text = "Numero Documento";
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Location = new System.Drawing.Point(225, 199);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new System.Drawing.Size(82, 22);
            cmbTipoCliente.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 206);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(186, 14);
            label5.TabIndex = 8;
            label5.Text = "Tipo Cliente (Socio/No socio)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(27, 248);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 14);
            label6.TabIndex = 10;
            label6.Text = "Presentó apto fisico";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new System.Drawing.Point(225, 249);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new System.Drawing.Size(15, 14);
            chkAptoFisico.TabIndex = 11;
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(142, 336);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(233, 21);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(677, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(233, 21);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1007, 387);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(chkAptoFisico);
            Controls.Add(label6);
            Controls.Add(cmbTipoCliente);
            Controls.Add(label5);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(cmbTipoDoc);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmRegistrar";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAptoFisico;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}