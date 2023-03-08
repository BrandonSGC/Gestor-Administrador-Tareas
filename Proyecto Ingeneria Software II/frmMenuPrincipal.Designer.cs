namespace Proyecto_Ingeneria_Software_II
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarUsuarios = new System.Windows.Forms.Button();
            this.btnCrearDepartamentos = new System.Windows.Forms.Button();
            this.btnCrearAsigarTareas = new System.Windows.Forms.Button();
            this.btnVerTareas = new System.Windows.Forms.Button();
            this.pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido al Gestor de Administración y Seguimiento de Tareas ";
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlNavegacion.Controls.Add(this.btnVerTareas);
            this.pnlNavegacion.Controls.Add(this.lblNombreUsuario);
            this.pnlNavegacion.Controls.Add(this.pictureBox1);
            this.pnlNavegacion.Controls.Add(this.btnRegistrarUsuarios);
            this.pnlNavegacion.Controls.Add(this.btnCrearDepartamentos);
            this.pnlNavegacion.Controls.Add(this.btnCrearAsigarTareas);
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacion.Margin = new System.Windows.Forms.Padding(5);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(222, 431);
            this.pnlNavegacion.TabIndex = 14;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(73, 134);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(71, 17);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 106);
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
            this.btnRegistrarUsuarios.Location = new System.Drawing.Point(14, 209);
            this.btnRegistrarUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
            this.btnRegistrarUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrarUsuarios.Size = new System.Drawing.Size(196, 41);
            this.btnRegistrarUsuarios.TabIndex = 0;
            this.btnRegistrarUsuarios.Text = "Registrar Usuarios";
            this.btnRegistrarUsuarios.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuarios.Click += new System.EventHandler(this.btnRegistrarUsuarios_Click_1);
            // 
            // btnCrearDepartamentos
            // 
            this.btnCrearDepartamentos.BackColor = System.Drawing.Color.Turquoise;
            this.btnCrearDepartamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearDepartamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearDepartamentos.ForeColor = System.Drawing.Color.Black;
            this.btnCrearDepartamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearDepartamentos.Location = new System.Drawing.Point(14, 260);
            this.btnCrearDepartamentos.Margin = new System.Windows.Forms.Padding(5);
            this.btnCrearDepartamentos.Name = "btnCrearDepartamentos";
            this.btnCrearDepartamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearDepartamentos.Size = new System.Drawing.Size(196, 41);
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
            this.btnCrearAsigarTareas.Location = new System.Drawing.Point(14, 311);
            this.btnCrearAsigarTareas.Margin = new System.Windows.Forms.Padding(5);
            this.btnCrearAsigarTareas.Name = "btnCrearAsigarTareas";
            this.btnCrearAsigarTareas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearAsigarTareas.Size = new System.Drawing.Size(196, 41);
            this.btnCrearAsigarTareas.TabIndex = 2;
            this.btnCrearAsigarTareas.Text = "Crear y Asignar Tareas";
            this.btnCrearAsigarTareas.UseVisualStyleBackColor = false;
            this.btnCrearAsigarTareas.Click += new System.EventHandler(this.btnCrearAsigarTareas_Click_1);
            // 
            // btnVerTareas
            // 
            this.btnVerTareas.BackColor = System.Drawing.Color.Turquoise;
            this.btnVerTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTareas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTareas.ForeColor = System.Drawing.Color.Black;
            this.btnVerTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTareas.Location = new System.Drawing.Point(14, 362);
            this.btnVerTareas.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerTareas.Name = "btnVerTareas";
            this.btnVerTareas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerTareas.Size = new System.Drawing.Size(196, 41);
            this.btnVerTareas.TabIndex = 5;
            this.btnVerTareas.Text = "Ver Tareas";
            this.btnVerTareas.UseVisualStyleBackColor = false;
            this.btnVerTareas.Click += new System.EventHandler(this.btnVerTareas_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 430);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarUsuarios;
        private System.Windows.Forms.Button btnCrearDepartamentos;
        private System.Windows.Forms.Button btnCrearAsigarTareas;
        private System.Windows.Forms.Button btnVerTareas;
    }
}

