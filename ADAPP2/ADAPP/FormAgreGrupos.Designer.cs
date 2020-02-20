namespace ADAPP
{
    partial class FormAgreGrupos
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
            this.cbCiclo = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtNombreCiclo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbCiclo
            // 
            this.cbCiclo.BackColor = System.Drawing.Color.White;
            this.cbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCiclo.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiclo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCiclo.FormattingEnabled = true;
            this.cbCiclo.Location = new System.Drawing.Point(151, 60);
            this.cbCiclo.Name = "cbCiclo";
            this.cbCiclo.Size = new System.Drawing.Size(242, 29);
            this.cbCiclo.TabIndex = 34;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Guardar.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(79, 220);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(247, 72);
            this.btn_Guardar.TabIndex = 35;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(139, 21);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre Gupo: ";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.White;
            this.lblGrupo.Location = new System.Drawing.Point(48, 68);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(58, 21);
            this.lblGrupo.TabIndex = 37;
            this.lblGrupo.Text = "Ciclo:";
            // 
            // txtNombreCiclo
            // 
            this.txtNombreCiclo.BackColor = System.Drawing.Color.White;
            this.txtNombreCiclo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCiclo.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCiclo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreCiclo.Location = new System.Drawing.Point(151, 27);
            this.txtNombreCiclo.Name = "txtNombreCiclo";
            this.txtNombreCiclo.Size = new System.Drawing.Size(242, 21);
            this.txtNombreCiclo.TabIndex = 33;
            // 
            // FormAgreGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(162)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cbCiclo);
            this.Controls.Add(this.txtNombreCiclo);
            this.Name = "FormAgreGrupos";
            this.Text = "FormAgreGrupos";
            this.Load += new System.EventHandler(this.FormAgreGrupos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCiclo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtNombreCiclo;
    }
}