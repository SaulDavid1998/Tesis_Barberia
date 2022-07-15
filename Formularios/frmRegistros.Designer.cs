namespace Tesis_Barberia.Formularios
{
    partial class frmRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrearRegistro = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbBarberos = new System.Windows.Forms.ComboBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dgvregistros = new System.Windows.Forms.DataGridView();
            this.RegistroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarberoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarberoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFormadePago = new System.Windows.Forms.ComboBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkBarbero = new System.Windows.Forms.CheckBox();
            this.chkMetodoPago = new System.Windows.Forms.CheckBox();
            this.chkServicio = new System.Windows.Forms.CheckBox();
            this.btntraertodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(36, 99);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(110, 48);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Metodo de\r\n    Pago";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(46, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 24);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Barbero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(46, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(46, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(690, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 62);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "   Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(548, 196);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 62);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "    Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(456, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 62);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCrearRegistro
            // 
            this.btnCrearRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrearRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCrearRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrearRegistro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCrearRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearRegistro.Image")));
            this.btnCrearRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearRegistro.Location = new System.Drawing.Point(406, 196);
            this.btnCrearRegistro.Name = "btnCrearRegistro";
            this.btnCrearRegistro.Size = new System.Drawing.Size(136, 62);
            this.btnCrearRegistro.TabIndex = 21;
            this.btnCrearRegistro.Text = " Crear ";
            this.btnCrearRegistro.UseVisualStyleBackColor = true;
            this.btnCrearRegistro.Click += new System.EventHandler(this.btnCrearRegistro_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(191, 200);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 23;
            // 
            // cmbBarberos
            // 
            this.cmbBarberos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarberos.Enabled = false;
            this.cmbBarberos.FormattingEnabled = true;
            this.cmbBarberos.Location = new System.Drawing.Point(191, 67);
            this.cmbBarberos.Name = "cmbBarberos";
            this.cmbBarberos.Size = new System.Drawing.Size(200, 21);
            this.cmbBarberos.TabIndex = 25;
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.Enabled = false;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(191, 160);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(200, 21);
            this.cmbServicio.TabIndex = 26;
            // 
            // dgvregistros
            // 
            this.dgvregistros.AllowUserToAddRows = false;
            this.dgvregistros.AllowUserToDeleteRows = false;
            this.dgvregistros.AllowUserToResizeColumns = false;
            this.dgvregistros.AllowUserToResizeRows = false;
            this.dgvregistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvregistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvregistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvregistros.ColumnHeadersHeight = 30;
            this.dgvregistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvregistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistroId,
            this.BarberoId,
            this.ServicioId,
            this.ClienteId,
            this.MPId,
            this.BarberoNombre,
            this.ClienteNombre,
            this.MPNombre,
            this.ServicioNombre,
            this.Fecha});
            this.dgvregistros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvregistros.EnableHeadersVisualStyles = false;
            this.dgvregistros.GridColor = System.Drawing.Color.Blue;
            this.dgvregistros.Location = new System.Drawing.Point(0, 264);
            this.dgvregistros.Name = "dgvregistros";
            this.dgvregistros.ReadOnly = true;
            this.dgvregistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvregistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvregistros.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvregistros.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvregistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvregistros.Size = new System.Drawing.Size(833, 324);
            this.dgvregistros.TabIndex = 27;
            this.dgvregistros.Visible = false;
            // 
            // RegistroId
            // 
            this.RegistroId.DataPropertyName = "registroid";
            this.RegistroId.HeaderText = "RegistroId";
            this.RegistroId.Name = "RegistroId";
            this.RegistroId.ReadOnly = true;
            this.RegistroId.Visible = false;
            // 
            // BarberoId
            // 
            this.BarberoId.DataPropertyName = "barberoid";
            this.BarberoId.HeaderText = "BarberoId";
            this.BarberoId.Name = "BarberoId";
            this.BarberoId.ReadOnly = true;
            this.BarberoId.Visible = false;
            // 
            // ServicioId
            // 
            this.ServicioId.DataPropertyName = "servicioid";
            this.ServicioId.HeaderText = "ServicioId";
            this.ServicioId.Name = "ServicioId";
            this.ServicioId.ReadOnly = true;
            this.ServicioId.Visible = false;
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "clienteid";
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Visible = false;
            // 
            // MPId
            // 
            this.MPId.DataPropertyName = "metodopagoid";
            this.MPId.HeaderText = "MPId";
            this.MPId.Name = "MPId";
            this.MPId.ReadOnly = true;
            this.MPId.Visible = false;
            // 
            // BarberoNombre
            // 
            this.BarberoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BarberoNombre.DataPropertyName = "Barbero";
            this.BarberoNombre.HeaderText = "Barbero";
            this.BarberoNombre.Name = "BarberoNombre";
            this.BarberoNombre.ReadOnly = true;
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClienteNombre.DataPropertyName = "Cliente";
            this.ClienteNombre.HeaderText = "Cliente";
            this.ClienteNombre.Name = "ClienteNombre";
            this.ClienteNombre.ReadOnly = true;
            // 
            // MPNombre
            // 
            this.MPNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MPNombre.DataPropertyName = "FormadePago";
            this.MPNombre.HeaderText = "Forma de Pago";
            this.MPNombre.Name = "MPNombre";
            this.MPNombre.ReadOnly = true;
            // 
            // ServicioNombre
            // 
            this.ServicioNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServicioNombre.DataPropertyName = "Servicio";
            this.ServicioNombre.HeaderText = "Servicio";
            this.ServicioNombre.Name = "ServicioNombre";
            this.ServicioNombre.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // cmbFormadePago
            // 
            this.cmbFormadePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormadePago.Enabled = false;
            this.cmbFormadePago.FormattingEnabled = true;
            this.cmbFormadePago.Location = new System.Drawing.Point(191, 113);
            this.cmbFormadePago.Name = "cmbFormadePago";
            this.cmbFormadePago.Size = new System.Drawing.Size(200, 21);
            this.cmbFormadePago.TabIndex = 28;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(170, 204);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(15, 14);
            this.chkFecha.TabIndex = 29;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(191, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(200, 20);
            this.txtCliente.TabIndex = 30;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // chkBarbero
            // 
            this.chkBarbero.AutoSize = true;
            this.chkBarbero.Location = new System.Drawing.Point(170, 72);
            this.chkBarbero.Name = "chkBarbero";
            this.chkBarbero.Size = new System.Drawing.Size(15, 14);
            this.chkBarbero.TabIndex = 31;
            this.chkBarbero.UseVisualStyleBackColor = true;
            this.chkBarbero.CheckedChanged += new System.EventHandler(this.chkBarbero_CheckedChanged);
            // 
            // chkMetodoPago
            // 
            this.chkMetodoPago.AutoSize = true;
            this.chkMetodoPago.Location = new System.Drawing.Point(170, 116);
            this.chkMetodoPago.Name = "chkMetodoPago";
            this.chkMetodoPago.Size = new System.Drawing.Size(15, 14);
            this.chkMetodoPago.TabIndex = 32;
            this.chkMetodoPago.UseVisualStyleBackColor = true;
            this.chkMetodoPago.CheckedChanged += new System.EventHandler(this.chkMetodoPago_CheckedChanged);
            // 
            // chkServicio
            // 
            this.chkServicio.AutoSize = true;
            this.chkServicio.Location = new System.Drawing.Point(170, 163);
            this.chkServicio.Name = "chkServicio";
            this.chkServicio.Size = new System.Drawing.Size(15, 14);
            this.chkServicio.TabIndex = 33;
            this.chkServicio.UseVisualStyleBackColor = true;
            this.chkServicio.CheckedChanged += new System.EventHandler(this.chkServicio_CheckedChanged);
            // 
            // btntraertodo
            // 
            this.btntraertodo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btntraertodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntraertodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntraertodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntraertodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntraertodo.Location = new System.Drawing.Point(633, 26);
            this.btntraertodo.Name = "btntraertodo";
            this.btntraertodo.Size = new System.Drawing.Size(136, 62);
            this.btntraertodo.TabIndex = 34;
            this.btntraertodo.Text = "Traer todo / Actualizar";
            this.btntraertodo.UseVisualStyleBackColor = true;
            this.btntraertodo.Click += new System.EventHandler(this.btntraertodo_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(833, 588);
            this.Controls.Add(this.btntraertodo);
            this.Controls.Add(this.chkServicio);
            this.Controls.Add(this.chkMetodoPago);
            this.Controls.Add(this.chkBarbero);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.cmbFormadePago);
            this.Controls.Add(this.dgvregistros);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.cmbBarberos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCrearRegistro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmRegistros";
            this.Text = "frmRegistros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearRegistro;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbBarberos;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.DataGridView dgvregistros;
        private System.Windows.Forms.ComboBox cmbFormadePago;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkBarbero;
        private System.Windows.Forms.CheckBox chkMetodoPago;
        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarberoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarberoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MPNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btntraertodo;
    }
}