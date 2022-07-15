namespace Tesis_Barberia.Formularios
{
    partial class frmRegistrosAgregar
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
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.cmbbarbero = new System.Windows.Forms.ComboBox();
            this.cmbmetodopago = new System.Windows.Forms.ComboBox();
            this.cmbservicio = new System.Windows.Forms.ComboBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbcliente
            // 
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(158, 56);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(135, 21);
            this.cmbcliente.TabIndex = 0;
            // 
            // cmbbarbero
            // 
            this.cmbbarbero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbarbero.FormattingEnabled = true;
            this.cmbbarbero.Location = new System.Drawing.Point(158, 113);
            this.cmbbarbero.Name = "cmbbarbero";
            this.cmbbarbero.Size = new System.Drawing.Size(135, 21);
            this.cmbbarbero.TabIndex = 1;
            // 
            // cmbmetodopago
            // 
            this.cmbmetodopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmetodopago.FormattingEnabled = true;
            this.cmbmetodopago.Location = new System.Drawing.Point(158, 167);
            this.cmbmetodopago.Name = "cmbmetodopago";
            this.cmbmetodopago.Size = new System.Drawing.Size(135, 21);
            this.cmbmetodopago.TabIndex = 2;
            // 
            // cmbservicio
            // 
            this.cmbservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbservicio.FormattingEnabled = true;
            this.cmbservicio.Location = new System.Drawing.Point(158, 237);
            this.cmbservicio.Name = "cmbservicio";
            this.cmbservicio.Size = new System.Drawing.Size(135, 21);
            this.cmbservicio.TabIndex = 3;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(143, 311);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(12, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 24);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 29;
            this.label3.Text = "Metodo de \r\n     Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Barbero";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(143, 361);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 37);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(143, 373);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(107, 37);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(158, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(49, 20);
            this.txtid.TabIndex = 35;
            // 
            // frmRegistrosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 434);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.cmbservicio);
            this.Controls.Add(this.cmbmetodopago);
            this.Controls.Add(this.cmbbarbero);
            this.Controls.Add(this.cmbcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(391, 473);
            this.MinimumSize = new System.Drawing.Size(391, 473);
            this.Name = "frmRegistrosAgregar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.ComboBox cmbbarbero;
        private System.Windows.Forms.ComboBox cmbmetodopago;
        private System.Windows.Forms.ComboBox cmbservicio;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
    }
}