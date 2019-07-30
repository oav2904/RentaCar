namespace GUI
{
    partial class MAIN
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
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnVeh = new System.Windows.Forms.Button();
            this.BtnSedes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Location = new System.Drawing.Point(80, 40);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(152, 23);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "Mantenimiento Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(79, 85);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(153, 23);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Mantenimiento de Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnVeh
            // 
            this.BtnVeh.Location = new System.Drawing.Point(79, 132);
            this.BtnVeh.Name = "BtnVeh";
            this.BtnVeh.Size = new System.Drawing.Size(153, 23);
            this.BtnVeh.TabIndex = 2;
            this.BtnVeh.Text = "Mantenimiento de Vehículos";
            this.BtnVeh.UseVisualStyleBackColor = true;
            this.BtnVeh.Click += new System.EventHandler(this.BtnVeh_Click);
            // 
            // BtnSedes
            // 
            this.BtnSedes.Location = new System.Drawing.Point(79, 185);
            this.BtnSedes.Name = "BtnSedes";
            this.BtnSedes.Size = new System.Drawing.Size(153, 23);
            this.BtnSedes.TabIndex = 3;
            this.BtnSedes.Text = "Mantenimiento de Sedes";
            this.BtnSedes.UseVisualStyleBackColor = true;
            this.BtnSedes.Click += new System.EventHandler(this.BtnSedes_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 271);
            this.Controls.Add(this.BtnSedes);
            this.Controls.Add(this.BtnVeh);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnUsuarios);
            this.Name = "MAIN";
            this.Text = "Menu General";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MAIN_FormClosing);
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnVeh;
        private System.Windows.Forms.Button BtnSedes;
    }
}