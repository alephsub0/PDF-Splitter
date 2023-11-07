namespace PDF_Splitter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPDF = new System.Windows.Forms.Button();
            this.lbPath1 = new System.Windows.Forms.Label();
            this.lbPath2 = new System.Windows.Forms.Label();
            this.btnXLSX = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.ofdPDF = new System.Windows.Forms.OpenFileDialog();
            this.ofdCSV = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudaVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.MasInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(18, 43);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(1);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(122, 28);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "Seleccionar...";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // lbPath1
            // 
            this.lbPath1.AutoEllipsis = true;
            this.lbPath1.BackColor = System.Drawing.Color.Transparent;
            this.lbPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath1.Location = new System.Drawing.Point(167, 49);
            this.lbPath1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPath1.Name = "lbPath1";
            this.lbPath1.Size = new System.Drawing.Size(225, 28);
            this.lbPath1.TabIndex = 3;
            // 
            // lbPath2
            // 
            this.lbPath2.AutoEllipsis = true;
            this.lbPath2.BackColor = System.Drawing.Color.Transparent;
            this.lbPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath2.Location = new System.Drawing.Point(167, 51);
            this.lbPath2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPath2.Name = "lbPath2";
            this.lbPath2.Size = new System.Drawing.Size(225, 28);
            this.lbPath2.TabIndex = 5;
            // 
            // btnXLSX
            // 
            this.btnXLSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXLSX.Location = new System.Drawing.Point(18, 45);
            this.btnXLSX.Margin = new System.Windows.Forms.Padding(1);
            this.btnXLSX.Name = "btnXLSX";
            this.btnXLSX.Size = new System.Drawing.Size(122, 28);
            this.btnXLSX.TabIndex = 4;
            this.btnXLSX.Text = "Seleccionar...";
            this.btnXLSX.UseVisualStyleBackColor = true;
            this.btnXLSX.Click += new System.EventHandler(this.btnXLSX_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(251)))));
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Transparent;
            this.btnDividir.Location = new System.Drawing.Point(158, 265);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(1);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(122, 40);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Text = "Dividir PDF";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStrip
            // 
            this.ayudaToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAyudaVideo,
            this.MasInformacion,
            this.MenuCreditos});
            this.ayudaToolStrip.Name = "ayudaToolStrip";
            this.ayudaToolStrip.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStrip.Text = "Ayuda";
            // 
            // MenuAyudaVideo
            // 
            this.MenuAyudaVideo.Image = ((System.Drawing.Image)(resources.GetObject("MenuAyudaVideo.Image")));
            this.MenuAyudaVideo.Name = "MenuAyudaVideo";
            this.MenuAyudaVideo.Size = new System.Drawing.Size(190, 22);
            this.MenuAyudaVideo.Text = "Ver Ayuda";
            this.MenuAyudaVideo.Click += new System.EventHandler(this.MenuAyudaVideo_Click);
            // 
            // MasInformacion
            // 
            this.MasInformacion.Image = ((System.Drawing.Image)(resources.GetObject("MasInformacion.Image")));
            this.MasInformacion.Name = "MasInformacion";
            this.MasInformacion.Size = new System.Drawing.Size(190, 22);
            this.MasInformacion.Text = "Más Información";
            this.MasInformacion.Click += new System.EventHandler(this.MasInformacion_Click);
            // 
            // MenuCreditos
            // 
            this.MenuCreditos.Name = "MenuCreditos";
            this.MenuCreditos.Size = new System.Drawing.Size(190, 22);
            this.MenuCreditos.Text = "Acerca de PDF Splitter";
            this.MenuCreditos.Click += new System.EventHandler(this.MenuCreditos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPDF);
            this.groupBox1.Controls.Add(this.lbPath1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo PDF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPath2);
            this.groupBox2.Controls.Add(this.btnXLSX);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivo CSV";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(438, 320);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "PDF Splitter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lbPath1;
        private System.Windows.Forms.Label lbPath2;
        private System.Windows.Forms.Button btnXLSX;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.OpenFileDialog ofdPDF;
        private System.Windows.Forms.OpenFileDialog ofdCSV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudaVideo;
        private System.Windows.Forms.ToolStripMenuItem MasInformacion;
        private System.Windows.Forms.ToolStripMenuItem MenuCreditos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

