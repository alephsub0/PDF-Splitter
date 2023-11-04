using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Splitter
{
    public partial class MainForm : Form
    {
        private Manejador manejador = new Manejador();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ofdPDF.Filter = "Archivos PDF (*.pdf) | *.pdf";
            if (ofdPDF.ShowDialog() == DialogResult.OK)
            {
                manejador.ofdPDF = ofdPDF;
                lbPath1.Text = ofdPDF.SafeFileName;
            }
        }

        private void btnXLSX_Click(object sender, EventArgs e)
        {
            //ofdXLSX.Filter = "Archivos Excel (*.xlsx;*.xls) | *.xlsx;*.xls";
            ofdCSV.Filter = "Archivos CSV (*.csv) | *.csv";
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                manejador.ofdCSV = ofdCSV;
                string error = manejador.ComprobarCSV();
                if (error.Equals(""))
                    lbPath2.Text = ofdCSV.SafeFileName;
                else
                {
                    ofdCSV = new OpenFileDialog();
                    manejador.MensajeError(error);
                }
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ofdPDF.FileName != "" && ofdCSV.FileName != "")
            {
                if (manejador.Dividir())
                {
                    MessageBox.Show("¡Se ha completado la división con éxito!", "¡Éxito!", MessageBoxButtons.OK);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Los archivos no tienen el formato correcto.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione ambos archivos para continuar.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            lbPath1.Text = "";
            lbPath2.Text = "";
            ofdPDF.Dispose();
            ofdCSV.Dispose();
        }
    }
}
