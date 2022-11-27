namespace SistemaProduccion
{
    partial class RequerimientosCliente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDReqClientes = new System.Windows.Forms.TextBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMedidas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textCaracteristicas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReqCliente = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(676, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(676, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Req. Cliente";
            // 
            // txtIDReqClientes
            // 
            this.txtIDReqClientes.Location = new System.Drawing.Point(102, 25);
            this.txtIDReqClientes.Name = "txtIDReqClientes";
            this.txtIDReqClientes.Size = new System.Drawing.Size(58, 20);
            this.txtIDReqClientes.TabIndex = 33;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(676, 87);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 39;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(676, 58);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 38;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha Registro";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(364, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estado Req. Cliente";
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.cmbCliente);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.textMedidas);
            this.grupBoxDatos.Controls.Add(this.label9);
            this.grupBoxDatos.Controls.Add(this.textObservaciones);
            this.grupBoxDatos.Controls.Add(this.label10);
            this.grupBoxDatos.Controls.Add(this.textCaracteristicas);
            this.grupBoxDatos.Controls.Add(this.label8);
            this.grupBoxDatos.Controls.Add(this.label7);
            this.grupBoxDatos.Controls.Add(this.txtIDReqClientes);
            this.grupBoxDatos.Controls.Add(this.label6);
            this.grupBoxDatos.Controls.Add(this.label5);
            this.grupBoxDatos.Controls.Add(this.cbEstado);
            this.grupBoxDatos.Controls.Add(this.dtpFecha);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 194);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(754, 209);
            this.grupBoxDatos.TabIndex = 45;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos Requerimientos Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID Cliente";
            // 
            // textMedidas
            // 
            this.textMedidas.Location = new System.Drawing.Point(102, 163);
            this.textMedidas.Name = "textMedidas";
            this.textMedidas.Size = new System.Drawing.Size(234, 20);
            this.textMedidas.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Medidas";
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(102, 128);
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(471, 20);
            this.textObservaciones.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Observaciones";
            // 
            // textCaracteristicas
            // 
            this.textCaracteristicas.Location = new System.Drawing.Point(102, 96);
            this.textCaracteristicas.Name = "textCaracteristicas";
            this.textCaracteristicas.Size = new System.Drawing.Size(471, 20);
            this.textCaracteristicas.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Caracteristicas";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(364, 27);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 25;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "REQUERIMIENTOS CLIENTES\r\n";
            // 
            // dgvReqCliente
            // 
            this.dgvReqCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReqCliente.Location = new System.Drawing.Point(12, 25);
            this.dgvReqCliente.Name = "dgvReqCliente";
            this.dgvReqCliente.Size = new System.Drawing.Size(640, 150);
            this.dgvReqCliente.TabIndex = 44;
            this.dgvReqCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReqCliente_CellClick);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(102, 56);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(149, 21);
            this.cmbCliente.TabIndex = 44;
            // 
            // RequerimientosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 415);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReqCliente);
            this.Name = "RequerimientosCliente";
            this.Text = "RequerimientosCliente";
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDReqClientes;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReqCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMedidas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textCaracteristicas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}