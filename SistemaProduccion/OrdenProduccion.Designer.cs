namespace SistemaProduccion
{
    partial class OrdenProduccion
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textIDsupervisor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDplanificacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdenProduccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.dgvOatos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textIDoperarios = new System.Windows.Forms.TextBox();
            this.textHorarios = new System.Windows.Forms.TextBox();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(560, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 61;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(560, 111);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 63;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textIDsupervisor
            // 
            this.textIDsupervisor.Location = new System.Drawing.Point(134, 58);
            this.textIDsupervisor.Name = "textIDsupervisor";
            this.textIDsupervisor.Size = new System.Drawing.Size(58, 20);
            this.textIDsupervisor.TabIndex = 52;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(548, 86);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(548, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "ID Operarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID Supervisor";
            // 
            // txtIDplanificacion
            // 
            this.txtIDplanificacion.Location = new System.Drawing.Point(134, 93);
            this.txtIDplanificacion.Name = "txtIDplanificacion";
            this.txtIDplanificacion.Size = new System.Drawing.Size(58, 20);
            this.txtIDplanificacion.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID Orden Planificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Orden Produccion";
            // 
            // txtOrdenProduccion
            // 
            this.txtOrdenProduccion.Location = new System.Drawing.Point(134, 21);
            this.txtOrdenProduccion.Name = "txtOrdenProduccion";
            this.txtOrdenProduccion.Size = new System.Drawing.Size(58, 20);
            this.txtOrdenProduccion.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estado";
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
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "ORDEN PRODUCCION";
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.textHorarios);
            this.grupBoxDatos.Controls.Add(this.textIDoperarios);
            this.grupBoxDatos.Controls.Add(this.textIDsupervisor);
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.txtIDplanificacion);
            this.grupBoxDatos.Controls.Add(this.label8);
            this.grupBoxDatos.Controls.Add(this.label7);
            this.grupBoxDatos.Controls.Add(this.txtOrdenProduccion);
            this.grupBoxDatos.Controls.Add(this.label5);
            this.grupBoxDatos.Controls.Add(this.cbEstado);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 194);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(634, 183);
            this.grupBoxDatos.TabIndex = 65;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos Orden Produccion";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(560, 54);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 62;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // dgvOatos
            // 
            this.dgvOatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOatos.Location = new System.Drawing.Point(12, 25);
            this.dgvOatos.Name = "dgvOatos";
            this.dgvOatos.Size = new System.Drawing.Size(542, 150);
            this.dgvOatos.TabIndex = 64;
            this.dgvOatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOatos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Horaios";
            // 
            // textIDoperarios
            // 
            this.textIDoperarios.Location = new System.Drawing.Point(134, 126);
            this.textIDoperarios.Name = "textIDoperarios";
            this.textIDoperarios.Size = new System.Drawing.Size(58, 20);
            this.textIDoperarios.TabIndex = 53;
            // 
            // textHorarios
            // 
            this.textHorarios.Location = new System.Drawing.Point(134, 152);
            this.textHorarios.Name = "textHorarios";
            this.textHorarios.Size = new System.Drawing.Size(58, 20);
            this.textHorarios.TabIndex = 54;
            // 
            // OrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.dgvOatos);
            this.Name = "OrdenProduccion";
            this.Text = "OrdenProduccion";
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textIDsupervisor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDplanificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrdenProduccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.DataGridView dgvOatos;
        private System.Windows.Forms.TextBox textHorarios;
        private System.Windows.Forms.TextBox textIDoperarios;
        private System.Windows.Forms.Label label4;
    }
}