namespace ADAPP
{
    partial class Form_AgregarMateria
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
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cbCiclo = new System.Windows.Forms.ComboBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorasTotales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.Location = new System.Drawing.Point(95, 119);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(58, 21);
            this.lblGrupo.TabIndex = 42;
            this.lblGrupo.Text = "Ciclo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(17, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(152, 21);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre Materia:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Guardar.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(84, 220);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(247, 72);
            this.btn_Guardar.TabIndex = 40;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cbCiclo
            // 
            this.cbCiclo.BackColor = System.Drawing.Color.White;
            this.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCiclo.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiclo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCiclo.FormattingEnabled = true;
            this.cbCiclo.Location = new System.Drawing.Point(170, 111);
            this.cbCiclo.Name = "cbCiclo";
            this.cbCiclo.Size = new System.Drawing.Size(228, 29);
            this.cbCiclo.TabIndex = 39;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.BackColor = System.Drawing.Color.White;
            this.txtNombreMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreMateria.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMateria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreMateria.Location = new System.Drawing.Point(170, 27);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(228, 21);
            this.txtNombreMateria.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Horas Totales:";
            // 
            // txtHorasTotales
            // 
            this.txtHorasTotales.BackColor = System.Drawing.Color.White;
            this.txtHorasTotales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasTotales.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTotales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHorasTotales.Location = new System.Drawing.Point(170, 63);
            this.txtHorasTotales.Name = "txtHorasTotales";
            this.txtHorasTotales.Size = new System.Drawing.Size(228, 21);
            this.txtHorasTotales.TabIndex = 43;
            // 
            // Form_AgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorasTotales);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cbCiclo);
            this.Controls.Add(this.txtNombreMateria);
            this.Name = "Form_AgregarMateria";
            this.Text = "Form_AgregarMateria";
            this.Load += new System.EventHandler(this.Form_AgregarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cbCiclo;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorasTotales;
    }
}