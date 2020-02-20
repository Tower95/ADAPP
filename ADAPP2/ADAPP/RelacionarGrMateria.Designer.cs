namespace ADAPP
{
    partial class RelacionarGrMateria
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBSelectMateria = new System.Windows.Forms.ComboBox();
            this.LBGrupos = new System.Windows.Forms.ListBox();
            this.dgvRelaciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRelacionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Materia";
            // 
            // CBSelectMateria
            // 
            this.CBSelectMateria.BackColor = System.Drawing.Color.White;
            this.CBSelectMateria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBSelectMateria.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSelectMateria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBSelectMateria.FormattingEnabled = true;
            this.CBSelectMateria.Location = new System.Drawing.Point(303, 12);
            this.CBSelectMateria.Name = "CBSelectMateria";
            this.CBSelectMateria.Size = new System.Drawing.Size(200, 29);
            this.CBSelectMateria.TabIndex = 16;
            this.CBSelectMateria.SelectedIndexChanged += new System.EventHandler(this.CBSelectMateria_SelectedIndexChanged);
            // 
            // LBGrupos
            // 
            this.LBGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.LBGrupos.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBGrupos.FormattingEnabled = true;
            this.LBGrupos.ItemHeight = 21;
            this.LBGrupos.Location = new System.Drawing.Point(12, 12);
            this.LBGrupos.Name = "LBGrupos";
            this.LBGrupos.Size = new System.Drawing.Size(200, 424);
            this.LBGrupos.TabIndex = 18;
            this.LBGrupos.DoubleClick += new System.EventHandler(this.LBGrupos_DoubleClick);
            this.LBGrupos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBGrupos_MouseDoubleClick);
            // 
            // dgvRelaciones
            // 
            this.dgvRelaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelaciones.Location = new System.Drawing.Point(218, 155);
            this.dgvRelaciones.Name = "dgvRelaciones";
            this.dgvRelaciones.Size = new System.Drawing.Size(327, 281);
            this.dgvRelaciones.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Relacionados";
            // 
            // BtnRelacionar
            // 
            this.BtnRelacionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.BtnRelacionar.Enabled = false;
            this.BtnRelacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelacionar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelacionar.ForeColor = System.Drawing.Color.White;
            this.BtnRelacionar.Location = new System.Drawing.Point(226, 67);
            this.BtnRelacionar.Name = "BtnRelacionar";
            this.BtnRelacionar.Size = new System.Drawing.Size(91, 36);
            this.BtnRelacionar.TabIndex = 22;
            this.BtnRelacionar.Text = "Relacionar";
            this.BtnRelacionar.UseVisualStyleBackColor = false;
            this.BtnRelacionar.Click += new System.EventHandler(this.BtnRelacionar_Click);
            // 
            // RelacionarGrMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.BtnRelacionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRelaciones);
            this.Controls.Add(this.LBGrupos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBSelectMateria);
            this.Name = "RelacionarGrMateria";
            this.Text = "RelacionarGrMateria";
            this.Load += new System.EventHandler(this.RelacionarGrMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBSelectMateria;
        private System.Windows.Forms.ListBox LBGrupos;
        private System.Windows.Forms.DataGridView dgvRelaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRelacionar;
    }
}