namespace ADAPP
{
    partial class UCMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMateria));
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.listBMaterias = new System.Windows.Forms.ListBox();
            this.btnAgregarActividades = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.listBPlanEst = new System.Windows.Forms.ListBox();
            this.btnAgregarPE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnRelacionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(777, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMateria.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMateria.Location = new System.Drawing.Point(736, 479);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(35, 36);
            this.btnAgregarMateria.TabIndex = 5;
            this.btnAgregarMateria.Text = "+";
            this.btnAgregarMateria.UseVisualStyleBackColor = false;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // listBMaterias
            // 
            this.listBMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.listBMaterias.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBMaterias.FormattingEnabled = true;
            this.listBMaterias.ItemHeight = 21;
            this.listBMaterias.Location = new System.Drawing.Point(667, 49);
            this.listBMaterias.Name = "listBMaterias";
            this.listBMaterias.Size = new System.Drawing.Size(203, 424);
            this.listBMaterias.TabIndex = 0;
            this.listBMaterias.SelectedIndexChanged += new System.EventHandler(this.listBMaterias_SelectedIndexChanged);
            this.listBMaterias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBMaterias_MouseDoubleClick);
            // 
            // btnAgregarActividades
            // 
            this.btnAgregarActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnAgregarActividades.Enabled = false;
            this.btnAgregarActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarActividades.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarActividades.ForeColor = System.Drawing.Color.White;
            this.btnAgregarActividades.Location = new System.Drawing.Point(176, 479);
            this.btnAgregarActividades.Name = "btnAgregarActividades";
            this.btnAgregarActividades.Size = new System.Drawing.Size(35, 36);
            this.btnAgregarActividades.TabIndex = 7;
            this.btnAgregarActividades.Text = "+";
            this.btnAgregarActividades.UseVisualStyleBackColor = false;
            this.btnAgregarActividades.Click += new System.EventHandler(this.btnAgregarActividades_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(217, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(820, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 39);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(696, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 21);
            this.lblUsuario.TabIndex = 16;
            // 
            // dgvActividades
            // 
            this.dgvActividades.BackgroundColor = System.Drawing.Color.White;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(3, 49);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(449, 424);
            this.dgvActividades.TabIndex = 17;
            this.dgvActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActividades_CellContentClick);
            // 
            // listBPlanEst
            // 
            this.listBPlanEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.listBPlanEst.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBPlanEst.FormattingEnabled = true;
            this.listBPlanEst.ItemHeight = 21;
            this.listBPlanEst.Location = new System.Drawing.Point(458, 49);
            this.listBPlanEst.Name = "listBPlanEst";
            this.listBPlanEst.Size = new System.Drawing.Size(203, 424);
            this.listBPlanEst.TabIndex = 18;
            this.listBPlanEst.SelectedIndexChanged += new System.EventHandler(this.listBPlanEst_SelectedIndexChanged);
            this.listBPlanEst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBPlanEst_MouseDoubleClick);
            // 
            // btnAgregarPE
            // 
            this.btnAgregarPE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.btnAgregarPE.Enabled = false;
            this.btnAgregarPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPE.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPE.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPE.Location = new System.Drawing.Point(511, 479);
            this.btnAgregarPE.Name = "btnAgregarPE";
            this.btnAgregarPE.Size = new System.Drawing.Size(35, 36);
            this.btnAgregarPE.TabIndex = 19;
            this.btnAgregarPE.Text = "+";
            this.btnAgregarPE.UseVisualStyleBackColor = false;
            this.btnAgregarPE.Click += new System.EventHandler(this.btnAgregarPE_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(552, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnRelacionar
            // 
            this.BtnRelacionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(108)))), ((int)(((byte)(128)))));
            this.BtnRelacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelacionar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelacionar.ForeColor = System.Drawing.Color.White;
            this.BtnRelacionar.Location = new System.Drawing.Point(624, 479);
            this.BtnRelacionar.Name = "BtnRelacionar";
            this.BtnRelacionar.Size = new System.Drawing.Size(91, 36);
            this.BtnRelacionar.TabIndex = 21;
            this.BtnRelacionar.Text = "Relacionar";
            this.BtnRelacionar.UseVisualStyleBackColor = false;
            this.BtnRelacionar.Click += new System.EventHandler(this.BtnRelacionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 39;
            this.label5.Tag = "";
            this.label5.Text = "Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 40;
            this.label1.Tag = "";
            this.label1.Text = "Unidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 41;
            this.label2.Tag = "";
            this.label2.Text = "Materias";
            // 
            // UCMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnRelacionar);
            this.Controls.Add(this.btnAgregarPE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBPlanEst);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarActividades);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBMaterias);
            this.Name = "UCMateria";
            this.Size = new System.Drawing.Size(870, 527);
            this.Load += new System.EventHandler(this.UCMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBMaterias;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnAgregarActividades;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.ListBox listBPlanEst;
        private System.Windows.Forms.Button btnAgregarPE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnRelacionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
