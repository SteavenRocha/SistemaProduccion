namespace SistemaProduccion
{
    partial class MantenedorTipoPlano
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDtipoPlano = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTipoPlano = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grupBoxTipoPlanos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoPlano = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPlano)).BeginInit();
            this.grupBoxTipoPlanos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(310, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(310, 87);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 49;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(310, 29);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 48;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 76);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Tipo Plano";
            // 
            // txtIDtipoPlano
            // 
            this.txtIDtipoPlano.Location = new System.Drawing.Point(128, 25);
            this.txtIDtipoPlano.Name = "txtIDtipoPlano";
            this.txtIDtipoPlano.Size = new System.Drawing.Size(58, 20);
            this.txtIDtipoPlano.TabIndex = 33;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(128, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(143, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(298, 47);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripcion Plano";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(298, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTipoPlano
            // 
            this.dgvTipoPlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPlano.Location = new System.Drawing.Point(12, 29);
            this.dgvTipoPlano.Name = "dgvTipoPlano";
            this.dgvTipoPlano.Size = new System.Drawing.Size(271, 150);
            this.dgvTipoPlano.TabIndex = 51;
            this.dgvTipoPlano.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoPlano_CellClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(310, 58);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grupBoxTipoPlanos
            // 
            this.grupBoxTipoPlanos.Controls.Add(this.cbxTipoPlano);
            this.grupBoxTipoPlanos.Controls.Add(this.label2);
            this.grupBoxTipoPlanos.Controls.Add(this.btnCancelar);
            this.grupBoxTipoPlanos.Controls.Add(this.label7);
            this.grupBoxTipoPlanos.Controls.Add(this.txtIDtipoPlano);
            this.grupBoxTipoPlanos.Controls.Add(this.txtDescripcion);
            this.grupBoxTipoPlanos.Controls.Add(this.btnModificar);
            this.grupBoxTipoPlanos.Controls.Add(this.label4);
            this.grupBoxTipoPlanos.Controls.Add(this.btnAgregar);
            this.grupBoxTipoPlanos.Location = new System.Drawing.Point(12, 198);
            this.grupBoxTipoPlanos.Name = "grupBoxTipoPlanos";
            this.grupBoxTipoPlanos.Size = new System.Drawing.Size(392, 124);
            this.grupBoxTipoPlanos.TabIndex = 52;
            this.grupBoxTipoPlanos.TabStop = false;
            this.grupBoxTipoPlanos.Text = "Datos del Plano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "MANTENEDOR TIPOS PLANOS";
            // 
            // cbxTipoPlano
            // 
            this.cbxTipoPlano.AutoSize = true;
            this.cbxTipoPlano.Location = new System.Drawing.Point(128, 93);
            this.cbxTipoPlano.Name = "cbxTipoPlano";
            this.cbxTipoPlano.Size = new System.Drawing.Size(15, 14);
            this.cbxTipoPlano.TabIndex = 46;
            this.cbxTipoPlano.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Estado";
            // 
            // MantenedorTipoPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 329);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvTipoPlano);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.grupBoxTipoPlanos);
            this.Controls.Add(this.label1);
            this.Name = "MantenedorTipoPlano";
            this.Text = "MantenedorTipoPlano";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPlano)).EndInit();
            this.grupBoxTipoPlanos.ResumeLayout(false);
            this.grupBoxTipoPlanos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDtipoPlano;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTipoPlano;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grupBoxTipoPlanos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxTipoPlano;
        private System.Windows.Forms.Label label2;
    }
}