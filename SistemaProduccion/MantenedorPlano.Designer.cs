namespace SistemaProduccion
{
    partial class MantenedorPlano
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
            this.cbxCatPlano = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDplano = new System.Windows.Forms.TextBox();
            this.txtIDdiseñador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtOrdePlano = new System.Windows.Forms.TextBox();
            this.grupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCatPlano
            // 
            this.cbxCatPlano.FormattingEnabled = true;
            this.cbxCatPlano.Location = new System.Drawing.Point(128, 121);
            this.cbxCatPlano.Name = "cbxCatPlano";
            this.cbxCatPlano.Size = new System.Drawing.Size(143, 21);
            this.cbxCatPlano.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 86);
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
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Diseñador";
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.txtOrdePlano);
            this.grupBoxDatos.Controls.Add(this.cbxEstado);
            this.grupBoxDatos.Controls.Add(this.label5);
            this.grupBoxDatos.Controls.Add(this.cbxCatPlano);
            this.grupBoxDatos.Controls.Add(this.btnCancelar);
            this.grupBoxDatos.Controls.Add(this.label7);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.txtIDplano);
            this.grupBoxDatos.Controls.Add(this.txtIDdiseñador);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.btnModificar);
            this.grupBoxDatos.Controls.Add(this.label4);
            this.grupBoxDatos.Controls.Add(this.btnAgregar);
            this.grupBoxDatos.Location = new System.Drawing.Point(15, 210);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(536, 187);
            this.grupBoxDatos.TabIndex = 52;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos Plano";
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(128, 153);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(15, 14);
            this.cbxEstado.TabIndex = 48;
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Estado";
            // 
            // txtIDplano
            // 
            this.txtIDplano.Location = new System.Drawing.Point(128, 25);
            this.txtIDplano.Name = "txtIDplano";
            this.txtIDplano.Size = new System.Drawing.Size(58, 20);
            this.txtIDplano.TabIndex = 33;
            // 
            // txtIDdiseñador
            // 
            this.txtIDdiseñador.Location = new System.Drawing.Point(128, 56);
            this.txtIDdiseñador.Name = "txtIDdiseñador";
            this.txtIDdiseñador.Size = new System.Drawing.Size(58, 20);
            this.txtIDdiseñador.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Orden Plano";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(461, 57);
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
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "CategoriaPlano";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(461, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(476, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(174, 181);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 49;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 181);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 48;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 181);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "MANTENEDOR PLANO\r\n";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 25);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(539, 150);
            this.dgvDatos.TabIndex = 51;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick_1);
            // 
            // txtOrdePlano
            // 
            this.txtOrdePlano.Location = new System.Drawing.Point(128, 89);
            this.txtOrdePlano.Name = "txtOrdePlano";
            this.txtOrdePlano.Size = new System.Drawing.Size(58, 20);
            this.txtOrdePlano.TabIndex = 49;
            // 
            // MantenedorPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Name = "MantenedorPlano";
            this.Text = "MantenedorPlano";
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCatPlano;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.TextBox txtIDplano;
        private System.Windows.Forms.TextBox txtIDdiseñador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrdePlano;
    }
}