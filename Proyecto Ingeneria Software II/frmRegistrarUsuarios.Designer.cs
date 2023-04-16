namespace Proyecto_Ingeneria_Software_II
{
    partial class frmRegistrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarUsuarios = new System.Windows.Forms.Button();
            this.btnCrearDepartamentos = new System.Windows.Forms.Button();
            this.btnCrearAsigarTareas = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar Usuarios";
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlNavegacion.Controls.Add(this.btnVerTareas);
            this.pnlNavegacion.Controls.Add(this.label2);
            this.pnlNavegacion.Controls.Add(this.pbAtras);
            this.pnlNavegacion.Controls.Add(this.pictureBox1);
            this.pnlNavegacion.Controls.Add(this.btnRegistrarUsuarios);
            this.pnlNavegacion.Controls.Add(this.btnCrearDepartamentos);
            this.pnlNavegacion.Controls.Add(this.btnCrearAsigarTareas);
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(189, 430);
            this.pnlNavegacion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "username";
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = ((System.Drawing.Image)(resources.GetObject("pbAtras.Image")));
            this.pbAtras.Location = new System.Drawing.Point(3, 3);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(34, 28);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 14;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarUsuarios
            // 
            this.btnRegistrarUsuarios.BackColor = System.Drawing.Color.Turquoise;
            this.btnRegistrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuarios.Location = new System.Drawing.Point(12, 221);
            this.btnRegistrarUsuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
            this.btnRegistrarUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrarUsuarios.Size = new System.Drawing.Size(169, 41);
            this.btnRegistrarUsuarios.TabIndex = 0;
            this.btnRegistrarUsuarios.Text = "Registrar Usuarios";
            this.btnRegistrarUsuarios.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuarios.Click += new System.EventHandler(this.btnRegistrarUsuarios_Click);
            // 
            // btnCrearDepartamentos
            // 
            this.btnCrearDepartamentos.BackColor = System.Drawing.Color.Turquoise;
            this.btnCrearDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDepartamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearDepartamentos.ForeColor = System.Drawing.Color.Black;
            this.btnCrearDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearDepartamentos.Location = new System.Drawing.Point(12, 272);
            this.btnCrearDepartamentos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCrearDepartamentos.Name = "btnCrearDepartamentos";
            this.btnCrearDepartamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearDepartamentos.Size = new System.Drawing.Size(169, 41);
            this.btnCrearDepartamentos.TabIndex = 1;
            this.btnCrearDepartamentos.Text = "Crear Departamentos";
            this.btnCrearDepartamentos.UseVisualStyleBackColor = false;
            this.btnCrearDepartamentos.Click += new System.EventHandler(this.btnCrearDepartamentos_Click);
            // 
            // btnCrearAsigarTareas
            // 
            this.btnCrearAsigarTareas.BackColor = System.Drawing.Color.Turquoise;
            this.btnCrearAsigarTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearAsigarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearAsigarTareas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAsigarTareas.ForeColor = System.Drawing.Color.Black;
            this.btnCrearAsigarTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearAsigarTareas.Location = new System.Drawing.Point(12, 323);
            this.btnCrearAsigarTareas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCrearAsigarTareas.Name = "btnCrearAsigarTareas";
            this.btnCrearAsigarTareas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearAsigarTareas.Size = new System.Drawing.Size(169, 41);
            this.btnCrearAsigarTareas.TabIndex = 2;
            this.btnCrearAsigarTareas.Text = "Crear y Asignar Tareas";
            this.btnCrearAsigarTareas.UseVisualStyleBackColor = false;
            this.btnCrearAsigarTareas.Click += new System.EventHandler(this.btnCrearAsigarTareas_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(354, 294);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 17);
            this.lblTexto.TabIndex = 34;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(470, 72);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(159, 23);
            this.txtCedula.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cédula:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(470, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 23);
            this.txtNombre.TabIndex = 42;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(247, 111);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(470, 139);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(159, 23);
            this.txtApellidos.TabIndex = 44;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(247, 145);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(70, 17);
            this.lblApellidos.TabIndex = 43;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(470, 172);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(5);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(159, 23);
            this.txtContrasena.TabIndex = 46;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(247, 178);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(88, 17);
            this.lblContrasena.TabIndex = 45;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(470, 205);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 23);
            this.txtEmail.TabIndex = 48;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(247, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(134, 17);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Correo electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(470, 239);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(159, 23);
            this.txtTelefono.TabIndex = 50;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(247, 245);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 17);
            this.lblTelefono.TabIndex = 49;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(247, 282);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(55, 17);
            this.lblPuesto.TabIndex = 51;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(470, 276);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(5);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(159, 23);
            this.txtPuesto.TabIndex = 56;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(470, 309);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(5);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(159, 25);
            this.cbDepartamento.TabIndex = 61;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(247, 312);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(109, 17);
            this.lblDepartamento.TabIndex = 60;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(331, 360);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(183, 41);
            this.btnRegistrar.TabIndex = 62;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.BackColor = System.Drawing.Color.Turquoise;
            this.btnVerTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTareas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTareas.ForeColor = System.Drawing.Color.Black;
            this.btnVerTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTareas.Location = new System.Drawing.Point(12, 374);
            this.btnVerTareas.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerTareas.Size = new System.Drawing.Size(169, 41);
            this.btnVerTareas.TabIndex = 63;
            this.btnVerTareas.Text = "Ver Tareas";
            this.btnVerTareas.UseVisualStyleBackColor = false;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // frmRegistrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 429);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmRegistrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuarios";
            this.Load += new System.EventHandler(this.frmRegistrarUsuarios_Load);
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarUsuarios;
        private System.Windows.Forms.Button btnCrearDepartamentos;
        private System.Windows.Forms.Button btnCrearAsigarTareas;
        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerTareas;
    }
}