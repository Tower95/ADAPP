namespace ADAPP
{
    partial class UCClases
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.CBMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBGrupo = new System.Windows.Forms.ComboBox();
            this.btnIniciarClase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RevisarActividad = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAgregarActividad = new System.Windows.Forms.Button();
            this.btnRemoverActividades = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 24;
            this.label1.Tag = "";
            this.label1.Text = "Tema:";
            // 
            // txtTema
            // 
            this.txtTema.BackColor = System.Drawing.Color.White;
            this.txtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTema.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTema.Location = new System.Drawing.Point(106, 38);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(256, 21);
            this.txtTema.TabIndex = 29;
            // 
            // CBMateria
            // 
            this.CBMateria.BackColor = System.Drawing.Color.White;
            this.CBMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBMateria.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMateria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBMateria.FormattingEnabled = true;
            this.CBMateria.Location = new System.Drawing.Point(698, 33);
            this.CBMateria.Name = "CBMateria";
            this.CBMateria.Size = new System.Drawing.Size(161, 29);
            this.CBMateria.TabIndex = 30;
            this.CBMateria.SelectedIndexChanged += new System.EventHandler(this.CBMateria_SelectedIndexChanged);
            this.CBMateria.Click += new System.EventHandler(this.CBMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 31;
            this.label2.Tag = "";
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 33;
            this.label3.Tag = "";
            this.label3.Text = "Grupo";
            // 
            // CBGrupo
            // 
            this.CBGrupo.BackColor = System.Drawing.Color.White;
            this.CBGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBGrupo.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGrupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBGrupo.FormattingEnabled = true;
            this.CBGrupo.Location = new System.Drawing.Point(442, 33);
            this.CBGrupo.Name = "CBGrupo";
            this.CBGrupo.Size = new System.Drawing.Size(161, 29);
            this.CBGrupo.TabIndex = 32;
            this.CBGrupo.SelectedIndexChanged += new System.EventHandler(this.CBGrupo_SelectedIndexChanged);
            this.CBGrupo.Click += new System.EventHandler(this.CBGrupo_Click);
            // 
            // btnIniciarClase
            // 
            this.btnIniciarClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnIniciarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarClase.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarClase.ForeColor = System.Drawing.Color.White;
            this.btnIniciarClase.Location = new System.Drawing.Point(42, 82);
            this.btnIniciarClase.Name = "btnIniciarClase";
            this.btnIniciarClase.Size = new System.Drawing.Size(102, 36);
            this.btnIniciarClase.TabIndex = 35;
            this.btnIniciarClase.Text = "Iniciar";
            this.btnIniciarClase.UseVisualStyleBackColor = false;
            this.btnIniciarClase.Click += new System.EventHandler(this.btnIniciarClase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAlumnos);
            this.panel1.Controls.Add(this.RevisarActividad);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnAgregarActividad);
            this.panel1.Controls.Add(this.btnRemoverActividades);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvActividades);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 417);
            this.panel1.TabIndex = 36;
            // 
            // RevisarActividad
            // 
            this.RevisarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.RevisarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevisarActividad.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisarActividad.ForeColor = System.Drawing.Color.White;
            this.RevisarActividad.Location = new System.Drawing.Point(531, 361);
            this.RevisarActividad.Name = "RevisarActividad";
            this.RevisarActividad.Size = new System.Drawing.Size(150, 36);
            this.RevisarActividad.TabIndex = 41;
            this.RevisarActividad.Text = "Revision";
            this.RevisarActividad.UseVisualStyleBackColor = false;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(42, 361);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(150, 36);
            this.btnAsistencia.TabIndex = 37;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnAgregarActividad
            // 
            this.btnAgregarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnAgregarActividad.Enabled = false;
            this.btnAgregarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarActividad.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarActividad.ForeColor = System.Drawing.Color.White;
            this.btnAgregarActividad.Location = new System.Drawing.Point(449, 361);
            this.btnAgregarActividad.Name = "btnAgregarActividad";
            this.btnAgregarActividad.Size = new System.Drawing.Size(35, 36);
            this.btnAgregarActividad.TabIndex = 39;
            this.btnAgregarActividad.Text = "+";
            this.btnAgregarActividad.UseVisualStyleBackColor = false;
            // 
            // btnRemoverActividades
            // 
            this.btnRemoverActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnRemoverActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverActividades.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverActividades.ForeColor = System.Drawing.Color.White;
            this.btnRemoverActividades.Location = new System.Drawing.Point(490, 361);
            this.btnRemoverActividades.Name = "btnRemoverActividades";
            this.btnRemoverActividades.Size = new System.Drawing.Size(35, 36);
            this.btnRemoverActividades.TabIndex = 40;
            this.btnRemoverActividades.Text = "-";
            this.btnRemoverActividades.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 38;
            this.label5.Tag = "";
            this.label5.Text = "Actividades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 37;
            this.label4.Tag = "";
            this.label4.Text = "Alumnos";
            // 
            // dgvActividades
            // 
            this.dgvActividades.BackgroundColor = System.Drawing.Color.White;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(317, 57);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(542, 298);
            this.dgvActividades.TabIndex = 18;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(21, 57);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(290, 298);
            this.dgvAlumnos.TabIndex = 42;
            // 
            // UCClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIniciarClase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBMateria);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.label1);
            this.Name = "UCClases";
            this.Size = new System.Drawing.Size(876, 541);
            this.Load += new System.EventHandler(this.UCClases_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.ComboBox CBMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBGrupo;
        private System.Windows.Forms.Button btnIniciarClase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RevisarActividad;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAgregarActividad;
        private System.Windows.Forms.Button btnRemoverActividades;
        private System.Windows.Forms.DataGridView dgvAlumnos;
    }
}
