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
            this.lbTitulo1 = new System.Windows.Forms.Label();
            this.lbTitulo2 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lbPath1 = new System.Windows.Forms.Label();
            this.lbPath2 = new System.Windows.Forms.Label();
            this.btnXLSX = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.ofdPDF = new System.Windows.Forms.OpenFileDialog();
            this.ofdCSV = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbTitulo1
            // 
            this.lbTitulo1.AutoSize = true;
            this.lbTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo1.Location = new System.Drawing.Point(26, 26);
            this.lbTitulo1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTitulo1.Name = "lbTitulo1";
            this.lbTitulo1.Size = new System.Drawing.Size(97, 20);
            this.lbTitulo1.TabIndex = 0;
            this.lbTitulo1.Text = "Archivo PDF";
            // 
            // lbTitulo2
            // 
            this.lbTitulo2.AutoSize = true;
            this.lbTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo2.Location = new System.Drawing.Point(26, 122);
            this.lbTitulo2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbTitulo2.Name = "lbTitulo2";
            this.lbTitulo2.Size = new System.Drawing.Size(98, 20);
            this.lbTitulo2.TabIndex = 1;
            this.lbTitulo2.Text = "Archivo CSV";
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(28, 62);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.lbPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath1.Location = new System.Drawing.Point(179, 68);
            this.lbPath1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPath1.Name = "lbPath1";
            this.lbPath1.Size = new System.Drawing.Size(225, 28);
            this.lbPath1.TabIndex = 3;
            // 
            // lbPath2
            // 
            this.lbPath2.AutoEllipsis = true;
            this.lbPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath2.Location = new System.Drawing.Point(179, 164);
            this.lbPath2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPath2.Name = "lbPath2";
            this.lbPath2.Size = new System.Drawing.Size(225, 28);
            this.lbPath2.TabIndex = 5;
            // 
            // btnXLSX
            // 
            this.btnXLSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXLSX.Location = new System.Drawing.Point(28, 159);
            this.btnXLSX.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnXLSX.Name = "btnXLSX";
            this.btnXLSX.Size = new System.Drawing.Size(122, 28);
            this.btnXLSX.TabIndex = 4;
            this.btnXLSX.Text = "Seleccionar...";
            this.btnXLSX.UseVisualStyleBackColor = true;
            this.btnXLSX.Click += new System.EventHandler(this.btnXLSX_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(158, 214);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(122, 36);
            this.btnDividir.TabIndex = 6;
            this.btnDividir.Text = "Dividir PDF";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 267);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lbPath2);
            this.Controls.Add(this.btnXLSX);
            this.Controls.Add(this.lbPath1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.lbTitulo2);
            this.Controls.Add(this.lbTitulo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "PDF Splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo1;
        private System.Windows.Forms.Label lbTitulo2;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lbPath1;
        private System.Windows.Forms.Label lbPath2;
        private System.Windows.Forms.Button btnXLSX;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.OpenFileDialog ofdPDF;
        private System.Windows.Forms.OpenFileDialog ofdCSV;
    }
}

