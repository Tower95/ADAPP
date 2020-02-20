namespace ADAPP
{
    partial class Form_Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btnClase = new System.Windows.Forms.Button();
            this.btn_materia = new System.Windows.Forms.Button();
            this.btn_Grupo = new System.Windows.Forms.Button();
            this.Contenido = new System.Windows.Forms.Panel();
            this.ucAlumnos1 = new ADAPP.UCAlumnos();
            this.ucGrupo1 = new ADAPP.UCGrupo();
            this.ucMateria1 = new ADAPP.UCMateria();
            this.ucClases1 = new ADAPP.UCClases();
            this.panel1.SuspendLayout();
            this.Contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btn_Regresar);
            this.panel1.Controls.Add(this.btnClase);
            this.panel1.Controls.Add(this.btn_materia);
            this.panel1.Controls.Add(this.btn_Grupo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 525);
            this.panel1.TabIndex = 0;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.FlatAppearance.BorderSize = 0;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regresar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btn_Regresar.Location = new System.Drawing.Point(0, 4);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(165, 30);
            this.btn_Regresar.TabIndex = 5;
            this.btn_Regresar.Text = "Inicio";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btnClase
            // 
            this.btnClase.FlatAppearance.BorderSize = 0;
            this.btnClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClase.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btnClase.Location = new System.Drawing.Point(0, 161);
            this.btnClase.Name = "btnClase";
            this.btnClase.Size = new System.Drawing.Size(165, 50);
            this.btnClase.TabIndex = 4;
            this.btnClase.Text = "Clase";
            this.btnClase.UseVisualStyleBackColor = true;
            this.btnClase.Click += new System.EventHandler(this.btnClase_Click);
            // 
            // btn_materia
            // 
            this.btn_materia.FlatAppearance.BorderSize = 0;
            this.btn_materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_materia.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_materia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btn_materia.Location = new System.Drawing.Point(0, 102);
            this.btn_materia.Name = "btn_materia";
            this.btn_materia.Size = new System.Drawing.Size(165, 50);
            this.btn_materia.TabIndex = 2;
            this.btn_materia.Text = "Materia";
            this.btn_materia.UseVisualStyleBackColor = true;
            this.btn_materia.Click += new System.EventHandler(this.btn_materia_Click);
            // 
            // btn_Grupo
            // 
            this.btn_Grupo.FlatAppearance.BorderSize = 0;
            this.btn_Grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Grupo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btn_Grupo.Location = new System.Drawing.Point(0, 43);
            this.btn_Grupo.Name = "btn_Grupo";
            this.btn_Grupo.Size = new System.Drawing.Size(165, 50);
            this.btn_Grupo.TabIndex = 1;
            this.btn_Grupo.Text = "Grupo";
            this.btn_Grupo.UseVisualStyleBackColor = true;
            this.btn_Grupo.Click += new System.EventHandler(this.btn_Grupo_Click);
            // 
            // Contenido
            // 
            this.Contenido.BackColor = System.Drawing.Color.White;
            this.Contenido.Controls.Add(this.ucClases1);
            this.Contenido.Controls.Add(this.ucMateria1);
            this.Contenido.Controls.Add(this.ucGrupo1);
            this.Contenido.Controls.Add(this.ucAlumnos1);
            this.Contenido.Location = new System.Drawing.Point(162, 0);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(878, 525);
            this.Contenido.TabIndex = 1;
            // 
            // ucAlumnos1
            // 
            this.ucAlumnos1.Location = new System.Drawing.Point(3, -3);
            this.ucAlumnos1.Name = "ucAlumnos1";
            this.ucAlumnos1.Size = new System.Drawing.Size(870, 527);
            this.ucAlumnos1.TabIndex = 0;
            // 
            // ucGrupo1
            // 
            this.ucGrupo1.BackColor = System.Drawing.Color.White;
            this.ucGrupo1.Location = new System.Drawing.Point(3, 4);
            this.ucGrupo1.Name = "ucGrupo1";
            this.ucGrupo1.Size = new System.Drawing.Size(876, 541);
            this.ucGrupo1.TabIndex = 1;
            // 
            // ucMateria1
            // 
            this.ucMateria1.BackColor = System.Drawing.SystemColors.Control;
            this.ucMateria1.Location = new System.Drawing.Point(3, 0);
            this.ucMateria1.Name = "ucMateria1";
            this.ucMateria1.Size = new System.Drawing.Size(870, 527);
            this.ucMateria1.TabIndex = 2;
            // 
            // ucClases1
            // 
            this.ucClases1.BackColor = System.Drawing.Color.White;
            this.ucClases1.Location = new System.Drawing.Point(-1, 0);
            this.ucClases1.Name = "ucClases1";
            this.ucClases1.Size = new System.Drawing.Size(876, 541);
            this.ucClases1.TabIndex = 3;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1037, 525);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.Contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_materia;
        private System.Windows.Forms.Button btn_Grupo;
        private System.Windows.Forms.Button btnClase;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Panel Contenido;
        private UCMateria ucMateria1;
        private UCGrupo ucGrupo1;
        private UCAlumnos ucAlumnos1;
        private UCClases ucClases1;
    }
}