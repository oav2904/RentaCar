namespace GUI
{
    partial class MantenimientoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoClientes));
            this.tblUs = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblApellidoDos = new System.Windows.Forms.Label();
            this.lblApellidoUno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblUs
            // 
            this.tblUs.AllowUserToAddRows = false;
            this.tblUs.AllowUserToDeleteRows = false;
            this.tblUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUs.Location = new System.Drawing.Point(361, 56);
            this.tblUs.Name = "tblUs";
            this.tblUs.ReadOnly = true;
            this.tblUs.Size = new System.Drawing.Size(641, 150);
            this.tblUs.TabIndex = 55;
            this.tblUs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblUs_CellMouseClick_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(29, 196);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 63;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(124, 27);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 59;
            // 
            // txtSApellido
            // 
            this.txtSApellido.Location = new System.Drawing.Point(124, 123);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(100, 20);
            this.txtSApellido.TabIndex = 58;
            // 
            // txtPApellido
            // 
            this.txtPApellido.Location = new System.Drawing.Point(124, 78);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(100, 20);
            this.txtPApellido.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(64, 34);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 52;
            this.lblCedula.Text = "Cedula";
            // 
            // lblApellidoDos
            // 
            this.lblApellidoDos.AutoSize = true;
            this.lblApellidoDos.Location = new System.Drawing.Point(10, 130);
            this.lblApellidoDos.Name = "lblApellidoDos";
            this.lblApellidoDos.Size = new System.Drawing.Size(90, 13);
            this.lblApellidoDos.TabIndex = 51;
            this.lblApellidoDos.Text = "Segundo Apellido";
            // 
            // lblApellidoUno
            // 
            this.lblApellidoUno.AutoSize = true;
            this.lblApellidoUno.Location = new System.Drawing.Point(28, 85);
            this.lblApellidoUno.Name = "lblApellidoUno";
            this.lblApellidoUno.Size = new System.Drawing.Size(76, 13);
            this.lblApellidoUno.TabIndex = 50;
            this.lblApellidoUno.Text = "Primer Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtSApellido);
            this.panel1.Controls.Add(this.txtPApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.lblApellidoDos);
            this.panel1.Controls.Add(this.lblApellidoUno);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 248);
            this.panel1.TabIndex = 54;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 287);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "     ";
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tblUs);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoClientes_FormClosing);
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblUs;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblApellidoDos;
        private System.Windows.Forms.Label lblApellidoUno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
    }
}