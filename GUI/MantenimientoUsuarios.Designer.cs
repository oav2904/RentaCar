namespace GUI
{
    partial class MantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtReContrasenna = new System.Windows.Forms.TextBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblApellidoDos = new System.Windows.Forms.Label();
            this.lblApellidoUno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tblUs = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chkAdminSede = new System.Windows.Forms.CheckBox();
            this.chkDVeh = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkDVeh);
            this.panel1.Controls.Add(this.chkAdminSede);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.txtReContrasenna);
            this.panel1.Controls.Add(this.txtContrasenna);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtSApellido);
            this.panel1.Controls.Add(this.txtPApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblApellidoDos);
            this.panel1.Controls.Add(this.lblApellidoUno);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 339);
            this.panel1.TabIndex = 52;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(29, 285);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 63;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // txtReContrasenna
            // 
            this.txtReContrasenna.Location = new System.Drawing.Point(140, 191);
            this.txtReContrasenna.Name = "txtReContrasenna";
            this.txtReContrasenna.PasswordChar = '*';
            this.txtReContrasenna.Size = new System.Drawing.Size(100, 20);
            this.txtReContrasenna.TabIndex = 62;
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(140, 154);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '*';
            this.txtContrasenna.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenna.TabIndex = 61;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(140, 120);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 60;
            // 
            // txtSApellido
            // 
            this.txtSApellido.Location = new System.Drawing.Point(140, 78);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(100, 20);
            this.txtSApellido.TabIndex = 58;
            // 
            // txtPApellido
            // 
            this.txtPApellido.Location = new System.Drawing.Point(140, 44);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(100, 20);
            this.txtPApellido.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Confirmar Contraseña";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(59, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 54;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(77, 120);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 53;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblApellidoDos
            // 
            this.lblApellidoDos.AutoSize = true;
            this.lblApellidoDos.Location = new System.Drawing.Point(30, 78);
            this.lblApellidoDos.Name = "lblApellidoDos";
            this.lblApellidoDos.Size = new System.Drawing.Size(90, 13);
            this.lblApellidoDos.TabIndex = 51;
            this.lblApellidoDos.Text = "Segundo Apellido";
            // 
            // lblApellidoUno
            // 
            this.lblApellidoUno.AutoSize = true;
            this.lblApellidoUno.Location = new System.Drawing.Point(44, 44);
            this.lblApellidoUno.Name = "lblApellidoUno";
            this.lblApellidoUno.Size = new System.Drawing.Size(76, 13);
            this.lblApellidoUno.TabIndex = 50;
            this.lblApellidoUno.Text = "Primer Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(76, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "Nombre";
            // 
            // tblUs
            // 
            this.tblUs.AllowUserToAddRows = false;
            this.tblUs.AllowUserToDeleteRows = false;
            this.tblUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUs.Location = new System.Drawing.Point(363, 66);
            this.tblUs.Name = "tblUs";
            this.tblUs.ReadOnly = true;
            this.tblUs.Size = new System.Drawing.Size(650, 150);
            this.tblUs.TabIndex = 53;
            this.tblUs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblUs_CellMouseClick_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 380);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(22, 13);
            this.lblEstado.TabIndex = 54;
            this.lblEstado.Text = "     ";
            // 
            // chkAdminSede
            // 
            this.chkAdminSede.AutoSize = true;
            this.chkAdminSede.Location = new System.Drawing.Point(33, 238);
            this.chkAdminSede.Name = "chkAdminSede";
            this.chkAdminSede.Size = new System.Drawing.Size(132, 17);
            this.chkAdminSede.TabIndex = 66;
            this.chkAdminSede.Text = "Administrador de Sede";
            this.chkAdminSede.UseVisualStyleBackColor = true;
            // 
            // chkDVeh
            // 
            this.chkDVeh.AutoSize = true;
            this.chkDVeh.Location = new System.Drawing.Point(164, 238);
            this.chkDVeh.Name = "chkDVeh";
            this.chkDVeh.Size = new System.Drawing.Size(119, 17);
            this.chkDVeh.TabIndex = 67;
            this.chkDVeh.Text = "Dueño de Vehículo";
            this.chkDVeh.UseVisualStyleBackColor = true;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 405);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tblUs);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoUsuarios";
            this.Text = "MantenimientoUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtReContrasenna;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApellidoDos;
        private System.Windows.Forms.Label lblApellidoUno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView tblUs;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkDVeh;
        private System.Windows.Forms.CheckBox chkAdminSede;
    }
}