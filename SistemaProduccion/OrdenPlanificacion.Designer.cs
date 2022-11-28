namespace SistemaProduccion
{
    partial class OrdenPlanificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textIDsupervisor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDplano = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdenPlanificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.dgvOatos = new System.Windows.Forms.DataGridView();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ORDEN PLANIFICACION";
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.textIDsupervisor);
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.dtpFechaLimite);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.txtIDplano);
            this.grupBoxDatos.Controls.Add(this.label8);
            this.grupBoxDatos.Controls.Add(this.label7);
            this.grupBoxDatos.Controls.Add(this.txtOrdenPlanificacion);
            this.grupBoxDatos.Controls.Add(this.label5);
            this.grupBoxDatos.Controls.Add(this.cbEstado);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 193);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(634, 164);
            this.grupBoxDatos.TabIndex = 59;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos Orden Plano";
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
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Location = new System.Drawing.Point(134, 123);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaLimite.TabIndex = 46;
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
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha Limite";
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
            // txtIDplano
            // 
            this.txtIDplano.Location = new System.Drawing.Point(134, 93);
            this.txtIDplano.Name = "txtIDplano";
            this.txtIDplano.Size = new System.Drawing.Size(58, 20);
            this.txtIDplano.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID Plano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Orden Planificacion";
            // 
            // txtOrdenPlanificacion
            // 
            this.txtOrdenPlanificacion.Location = new System.Drawing.Point(134, 21);
            this.txtOrdenPlanificacion.Name = "txtOrdenPlanificacion";
            this.txtOrdenPlanificacion.Size = new System.Drawing.Size(58, 20);
            this.txtOrdenPlanificacion.TabIndex = 33;
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
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(560, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 55;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(560, 110);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(560, 53);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 56;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // dgvOatos
            // 
            this.dgvOatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOatos.Location = new System.Drawing.Point(12, 24);
            this.dgvOatos.Name = "dgvOatos";
            this.dgvOatos.Size = new System.Drawing.Size(542, 150);
            this.dgvOatos.TabIndex = 58;
            this.dgvOatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOatos_CellClick);
            // 
            // OrdenPlanificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.dgvOatos);
            this.Name = "OrdenPlanificacion";
            this.Text = "OrdenPlanificacion";
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDplano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrdenPlanificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.DataGridView dgvOatos;
        private System.Windows.Forms.TextBox textIDsupervisor;
    }
}