namespace Pruebas_diarias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtvacunas = new System.Windows.Forms.TextBox();
            this.cboraza = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvPerros = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 170);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vacunas";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(99, 276);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(200, 22);
            this.txtedad.TabIndex = 5;
            // 
            // txtvacunas
            // 
            this.txtvacunas.Location = new System.Drawing.Point(97, 340);
            this.txtvacunas.Name = "txtvacunas";
            this.txtvacunas.Size = new System.Drawing.Size(202, 22);
            this.txtvacunas.TabIndex = 6;
            // 
            // cboraza
            // 
            this.cboraza.FormattingEnabled = true;
            this.cboraza.Location = new System.Drawing.Point(98, 198);
            this.cboraza.Name = "cboraza";
            this.cboraza.Size = new System.Drawing.Size(201, 24);
            this.cboraza.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 133);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(198, 22);
            this.txtnombre.TabIndex = 8;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(98, 400);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(136, 42);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "EDITAR";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Image = ((System.Drawing.Image)(resources.GetObject("btnborrar.Image")));
            this.btnborrar.Location = new System.Drawing.Point(240, 400);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(60, 42);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.Location = new System.Drawing.Point(101, 456);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(198, 41);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvPerros
            // 
            this.dgvPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerros.Location = new System.Drawing.Point(470, 119);
            this.dgvPerros.Name = "dgvPerros";
            this.dgvPerros.RowHeadersWidth = 51;
            this.dgvPerros.RowTemplate.Height = 24;
            this.dgvPerros.Size = new System.Drawing.Size(596, 391);
            this.dgvPerros.TabIndex = 12;
            this.dgvPerros.SelectionChanged += new System.EventHandler(this.dgvPerros_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(525, 80);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(157, 22);
            this.txtbuscar.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(688, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "+";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.Image")));
            this.btnExportarPDF.Location = new System.Drawing.Point(965, 66);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(101, 37);
            this.btnExportarPDF.TabIndex = 16;
            this.btnExportarPDF.Text = " PDF";
            this.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1108, 575);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPerros);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cboraza);
            this.Controls.Add(this.txtvacunas);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtvacunas;
        private System.Windows.Forms.ComboBox cboraza;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvPerros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

