namespace Proyecto_Ingeneria_Software_II
{
    partial class frmCrearAsignarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearAsignarTareas));
            this.cbDepEncargado = new System.Windows.Forms.ComboBox();
            this.lblDepEncargado = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCrearTarea = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarUsuarios = new System.Windows.Forms.Button();
            this.btnCrearDepartamentos = new System.Windows.Forms.Button();
            this.btnCrearAsigarTareas = new System.Windows.Forms.Button();
            this.pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDepEncargado
            // 
            this.cbDepEncargado.FormattingEnabled = true;
            this.cbDepEncargado.Location = new System.Drawing.Point(493, 228);
            this.cbDepEncargado.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbDepEncargado.Name = "cbDepEncargado";
            this.cbDepEncargado.Size = new System.Drawing.Size(238, 25);
            this.cbDepEncargado.TabIndex = 24;
            // 
            // lblDepEncargado
            // 
            this.lblDepEncargado.AutoSize = true;
            this.lblDepEncargado.Location = new System.Drawing.Point(287, 238);
            this.lblDepEncargado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDepEncargado.Name = "lblDepEncargado";
            this.lblDepEncargado.Size = new System.Drawing.Size(186, 17);
            this.lblDepEncargado.TabIndex = 23;
            this.lblDepEncargado.Text = "Departamento encargado:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(287, 275);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(110, 17);
            this.lblFechaInicio.TabIndex = 19;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(286, 109);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(445, 113);
            this.txtDescripcion.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(284, 87);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 17);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(443, 8);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 25);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Crear Tarea";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(435, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 23);
            this.txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(284, 59);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 17);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre de Tarea:";
            // 
            // btnCrearTarea
            // 
            this.btnCrearTarea.BackColor = System.Drawing.Color.Turquoise;
            this.btnCrearTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTarea.ForeColor = System.Drawing.Color.White;
            this.btnCrearTarea.Location = new System.Drawing.Point(582, 338);
            this.btnCrearTarea.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCrearTarea.Name = "btnCrearTarea";
            this.btnCrearTarea.Size = new System.Drawing.Size(150, 38);
            this.btnCrearTarea.TabIndex = 13;
            this.btnCrearTarea.Text = "Crear Tarea";
            this.btnCrearTarea.UseVisualStyleBackColor = false;
            this.btnCrearTarea.Click += new System.EventHandler(this.btnCrearTarea_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(286, 305);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(266, 23);
            this.dtpFechaInicio.TabIndex = 26;
            // 
            // dtpFechaFinalizacion
            // 
            this.dtpFechaFinalizacion.Location = new System.Drawing.Point(286, 389);
            this.dtpFechaFinalizacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion";
            this.dtpFechaFinalizacion.Size = new System.Drawing.Size(266, 23);
            this.dtpFechaFinalizacion.TabIndex = 28;
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(286, 359);
            this.lblFechaFinalizacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(151, 17);
            this.lblFechaFinalizacion.TabIndex = 27;
            this.lblFechaFinalizacion.Text = "Fecha de Finalización:";
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlNavegacion.Controls.Add(this.btnVerTareas);
            this.pnlNavegacion.Controls.Add(this.label1);
            this.pnlNavegacion.Controls.Add(this.pbAtras);
            this.pnlNavegacion.Controls.Add(this.pictureBox1);
            this.pnlNavegacion.Controls.Add(this.btnRegistrarUsuarios);
            this.pnlNavegacion.Controls.Add(this.btnCrearDepartamentos);
            this.pnlNavegacion.Controls.Add(this.btnCrearAsigarTareas);
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(221, 429);
            this.pnlNavegacion.TabIndex = 29;
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
            this.btnVerTareas.Size = new System.Drawing.Size(196, 41);
            this.btnVerTareas.TabIndex = 16;
            this.btnVerTareas.Text = "Ver Tareas";
            this.btnVerTareas.UseVisualStyleBackColor = false;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "username";
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = ((System.Drawing.Image)(resources.GetObject("pbAtras.Image")));
            this.pbAtras.Location = new System.Drawing.Point(0, 3);
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
            this.pictureBox1.Location = new System.Drawing.Point(31, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 109);
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
            this.btnRegistrarUsuarios.Location = new System.Drawing.Point(12, 195);
            this.btnRegistrarUsuarios.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
            this.btnRegistrarUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrarUsuarios.Size = new System.Drawing.Size(198, 41);
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
            this.btnCrearDepartamentos.Location = new System.Drawing.Point(12, 256);
            this.btnCrearDepartamentos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCrearDepartamentos.Name = "btnCrearDepartamentos";
            this.btnCrearDepartamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearDepartamentos.Size = new System.Drawing.Size(198, 41);
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
            this.btnCrearAsigarTareas.Location = new System.Drawing.Point(12, 317);
            this.btnCrearAsigarTareas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCrearAsigarTareas.Name = "btnCrearAsigarTareas";
            this.btnCrearAsigarTareas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearAsigarTareas.Size = new System.Drawing.Size(198, 41);
            this.btnCrearAsigarTareas.TabIndex = 2;
            this.btnCrearAsigarTareas.Text = "Crear y Asignar Tareas";
            this.btnCrearAsigarTareas.UseVisualStyleBackColor = false;
            this.btnCrearAsigarTareas.Click += new System.EventHandler(this.btnCrearAsigarTareas_Click);
            // 
            // frmCrearAsignarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 429);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.dtpFechaFinalizacion);
            this.Controls.Add(this.lblFechaFinalizacion);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbDepEncargado);
            this.Controls.Add(this.lblDepEncargado);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCrearTarea);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmCrearAsignarTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear y AsignarTareas";
            this.Load += new System.EventHandler(this.frmCrearAsignarTareas_Load);
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDepEncargado;
        private System.Windows.Forms.Label lblDepEncargado;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCrearTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacion;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarUsuarios;
        private System.Windows.Forms.Button btnCrearDepartamentos;
        private System.Windows.Forms.Button btnCrearAsigarTareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerTareas;
    }
}