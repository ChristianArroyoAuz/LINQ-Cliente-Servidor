namespace Cliente
{
    partial class Cliente
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
            this.etiquetaId = new System.Windows.Forms.Label();
            this.etoquetaNomre = new System.Windows.Forms.Label();
            this.etiquetaDescripcion = new System.Windows.Forms.Label();
            this.etiquetaCosto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.groupBox_ingresoDatos = new System.Windows.Forms.GroupBox();
            this.groupBox_Administracion = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.boton_Mostrar = new System.Windows.Forms.Button();
            this.boton_Modificar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.dataGridView_Datos = new System.Windows.Forms.DataGridView();
            this.groupBox_ingresoDatos.SuspendLayout();
            this.groupBox_Administracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // etiquetaId
            // 
            this.etiquetaId.AutoSize = true;
            this.etiquetaId.Location = new System.Drawing.Point(6, 23);
            this.etiquetaId.Name = "etiquetaId";
            this.etiquetaId.Size = new System.Drawing.Size(21, 13);
            this.etiquetaId.TabIndex = 0;
            this.etiquetaId.Text = "ID:";
            // 
            // etoquetaNomre
            // 
            this.etoquetaNomre.AutoSize = true;
            this.etoquetaNomre.Location = new System.Drawing.Point(6, 47);
            this.etoquetaNomre.Name = "etoquetaNomre";
            this.etoquetaNomre.Size = new System.Drawing.Size(76, 13);
            this.etoquetaNomre.TabIndex = 1;
            this.etoquetaNomre.Text = "Nombre Pieza:";
            // 
            // etiquetaDescripcion
            // 
            this.etiquetaDescripcion.AutoSize = true;
            this.etiquetaDescripcion.Location = new System.Drawing.Point(6, 73);
            this.etiquetaDescripcion.Name = "etiquetaDescripcion";
            this.etiquetaDescripcion.Size = new System.Drawing.Size(66, 13);
            this.etiquetaDescripcion.TabIndex = 2;
            this.etiquetaDescripcion.Text = "Descripción:";
            // 
            // etiquetaCosto
            // 
            this.etiquetaCosto.AutoSize = true;
            this.etiquetaCosto.Location = new System.Drawing.Point(6, 99);
            this.etiquetaCosto.Name = "etiquetaCosto";
            this.etiquetaCosto.Size = new System.Drawing.Size(37, 13);
            this.etiquetaCosto.TabIndex = 3;
            this.etiquetaCosto.Text = "Costo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(93, 92);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(192, 20);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(96, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(13, 13);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "0";
            // 
            // groupBox_ingresoDatos
            // 
            this.groupBox_ingresoDatos.Controls.Add(this.etiquetaId);
            this.groupBox_ingresoDatos.Controls.Add(this.txtID);
            this.groupBox_ingresoDatos.Controls.Add(this.etoquetaNomre);
            this.groupBox_ingresoDatos.Controls.Add(this.txtCosto);
            this.groupBox_ingresoDatos.Controls.Add(this.etiquetaDescripcion);
            this.groupBox_ingresoDatos.Controls.Add(this.txtDescripcion);
            this.groupBox_ingresoDatos.Controls.Add(this.etiquetaCosto);
            this.groupBox_ingresoDatos.Controls.Add(this.txtNombre);
            this.groupBox_ingresoDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ingresoDatos.Name = "groupBox_ingresoDatos";
            this.groupBox_ingresoDatos.Size = new System.Drawing.Size(302, 128);
            this.groupBox_ingresoDatos.TabIndex = 0;
            this.groupBox_ingresoDatos.TabStop = false;
            this.groupBox_ingresoDatos.Text = "Ingreso de Datos";
            this.groupBox_ingresoDatos.Enter += new System.EventHandler(this.groupBox_ingresoDatos_Enter);
            // 
            // groupBox_Administracion
            // 
            this.groupBox_Administracion.Controls.Add(this.txtBuscar);
            this.groupBox_Administracion.Controls.Add(this.boton_Mostrar);
            this.groupBox_Administracion.Controls.Add(this.boton_Modificar);
            this.groupBox_Administracion.Controls.Add(this.boton_Eliminar);
            this.groupBox_Administracion.Controls.Add(this.boton_Buscar);
            this.groupBox_Administracion.Controls.Add(this.boton_Agregar);
            this.groupBox_Administracion.Location = new System.Drawing.Point(12, 146);
            this.groupBox_Administracion.Name = "groupBox_Administracion";
            this.groupBox_Administracion.Size = new System.Drawing.Size(302, 197);
            this.groupBox_Administracion.TabIndex = 1;
            this.groupBox_Administracion.TabStop = false;
            this.groupBox_Administracion.Text = "Admiistracion";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 164);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(279, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // boton_Mostrar
            // 
            this.boton_Mostrar.Location = new System.Drawing.Point(6, 106);
            this.boton_Mostrar.Name = "boton_Mostrar";
            this.boton_Mostrar.Size = new System.Drawing.Size(279, 23);
            this.boton_Mostrar.TabIndex = 3;
            this.boton_Mostrar.Text = "Mostrar Todos";
            this.boton_Mostrar.UseVisualStyleBackColor = true;
            this.boton_Mostrar.Click += new System.EventHandler(this.boton_Mostrar_Click);
            // 
            // boton_Modificar
            // 
            this.boton_Modificar.Location = new System.Drawing.Point(6, 48);
            this.boton_Modificar.Name = "boton_Modificar";
            this.boton_Modificar.Size = new System.Drawing.Size(279, 23);
            this.boton_Modificar.TabIndex = 1;
            this.boton_Modificar.Text = "Modificar";
            this.boton_Modificar.UseVisualStyleBackColor = true;
            this.boton_Modificar.Click += new System.EventHandler(this.boton_Modificar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(6, 77);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(279, 23);
            this.boton_Eliminar.TabIndex = 2;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.Location = new System.Drawing.Point(6, 135);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(279, 23);
            this.boton_Buscar.TabIndex = 4;
            this.boton_Buscar.Text = "Buscar por ID";
            this.boton_Buscar.UseVisualStyleBackColor = true;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.Location = new System.Drawing.Point(6, 19);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(279, 23);
            this.boton_Agregar.TabIndex = 0;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = true;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // dataGridView_Datos
            // 
            this.dataGridView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Datos.Location = new System.Drawing.Point(320, 18);
            this.dataGridView_Datos.Name = "dataGridView_Datos";
            this.dataGridView_Datos.Size = new System.Drawing.Size(404, 325);
            this.dataGridView_Datos.TabIndex = 2;
            this.dataGridView_Datos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Datos_CellMouseClick);
            this.dataGridView_Datos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Datos_RowEnter);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 355);
            this.Controls.Add(this.dataGridView_Datos);
            this.Controls.Add(this.groupBox_Administracion);
            this.Controls.Add(this.groupBox_ingresoDatos);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox_ingresoDatos.ResumeLayout(false);
            this.groupBox_ingresoDatos.PerformLayout();
            this.groupBox_Administracion.ResumeLayout(false);
            this.groupBox_Administracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label etiquetaId;
        private System.Windows.Forms.Label etoquetaNomre;
        private System.Windows.Forms.Label etiquetaDescripcion;
        private System.Windows.Forms.Label etiquetaCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.GroupBox groupBox_ingresoDatos;
        private System.Windows.Forms.GroupBox groupBox_Administracion;
        private System.Windows.Forms.Button boton_Mostrar;
        private System.Windows.Forms.Button boton_Modificar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView_Datos;
    }
}

