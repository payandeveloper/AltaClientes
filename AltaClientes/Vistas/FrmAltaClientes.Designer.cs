﻿namespace AltaClientes
{
    partial class frmAltaClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.cboAccion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicilio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "N. Interior:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(48, 271);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(187, 70);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(89, 22);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(187, 175);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(223, 22);
            this.txtDomicilio.TabIndex = 6;
            this.txtDomicilio.Enter += new System.EventHandler(this.txtDomicilio_Enter);
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Location = new System.Drawing.Point(187, 200);
            this.txtNumCasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(89, 22);
            this.txtNumCasa.TabIndex = 7;
            this.txtNumCasa.Enter += new System.EventHandler(this.txtNumCasa_Enter);
            this.txtNumCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCasa_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(187, 145);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2040, 1, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(110, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(125, 231);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(63, 23);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "Estado:";
            this.lblMensaje.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(160, 271);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 32);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(257, 271);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 32);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(417, 94);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 24);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "🔎";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboEstatus
            // 
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstatus.Location = new System.Drawing.Point(187, 227);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(122, 24);
            this.cboEstatus.TabIndex = 8;
            this.cboEstatus.SelectedIndexChanged += new System.EventHandler(this.cboEstatus_SelectedIndexChanged);
            // 
            // cboAccion
            // 
            this.cboAccion.FormattingEnabled = true;
            this.cboAccion.Location = new System.Drawing.Point(187, 28);
            this.cboAccion.Name = "cboAccion";
            this.cboAccion.Size = new System.Drawing.Size(122, 24);
            this.cboAccion.TabIndex = 1;
            this.cboAccion.SelectedIndexChanged += new System.EventHandler(this.cboAccion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(125, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Opcion:";
            this.label7.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(187, 121);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            // 
            // frmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 333);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cboAccion);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNumCasa);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAltaClientes";
            this.Text = "Alta Clientes";
            this.Load += new System.EventHandler(this.frmAltaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtNumCasa;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.ComboBox cboEstatus;
        public System.Windows.Forms.ComboBox cboAccion;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}

