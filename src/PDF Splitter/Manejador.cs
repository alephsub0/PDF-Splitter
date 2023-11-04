using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.FileIO;

namespace PDF_Splitter
{
    class Manejador
    {
        public OpenFileDialog ofdPDF { get; set; }
        public OpenFileDialog ofdCSV { get; set; }
        private bool TieneTitulo = false;

        public Manejador() { }

        public bool Dividir()
        {
            try
            {
                IEnumerable<string[]> CSV = LeerCSV();
                string[] nombres = GenerarNombres(CSV);
                int[] paginas = ObtenerPaginas(CSV);
                string PathCarpeta = Path.GetDirectoryName(ofdPDF.FileName);
                PdfDocument OutputFile;
                PdfDocument InputFile;

                InputFile = PdfReader.Open(ofdPDF.FileName, PdfDocumentOpenMode.Import);

                if (!ComprobarTamano(paginas, InputFile))
                {
                    MensajeError("La cantidad de páginas del PDF no se ha repartido completamente en el CSV.");
                    return false;
                }

                // Asignar
                string NombreCarpeta = string.Concat(ofdPDF.SafeFileName.Substring(0, ofdPDF.SafeFileName.Length - 4), "_Split_", DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"));
                string PathNuevaCarpeta = Path.Combine(PathCarpeta, NombreCarpeta);
                Directory.CreateDirectory(PathNuevaCarpeta);
                for (int i = 0, acum = 0; i < nombres.Length; i++)
                {
                    if (paginas[i] > 0)
                    {
                        OutputFile = new PdfDocument();
                        acum += paginas[i];
                        for (int j = acum - paginas[i]; j < acum; j++)
                        {
                            OutputFile.AddPage(InputFile.Pages[j]);
                        }
                        OutputFile.Save(Path.Combine(PathNuevaCarpeta, nombres[i]));
                    }
                }
                // Zip
                Zippear(PathNuevaCarpeta, NombreCarpeta, PathCarpeta);
                // Borrar Carpeta
                Borrar(PathNuevaCarpeta);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool ComprobarTamano(int[] paginas, PdfDocument InputFile)
        {
            return InputFile.PageCount == paginas.Sum();
        }

        public string ComprobarCSV()
        {
            string respuesta = "Compruebe que el archivo CSV:\n\n- Esté cerrado.";
            TieneTitulo = false;
            try
            {
                var path = ofdCSV.FileName;
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    bool condicionColumnas = ContarColumnas(csvParser) >= 2;
                    bool condicionFilas = ContarFilas(csvParser) > 0;
                    if (condicionColumnas && condicionFilas && TieneTitulo)
                        respuesta = "";
                    else
                    {
                        if (!condicionColumnas)
                        {
                            respuesta += "\n- Contenga al menos dos columnas.";
                        }
                        if (!condicionFilas)
                        {
                            respuesta += "\n- No esté vacío (Contenga información de al menos un estudiante).";
                        }
                        if (!TieneTitulo)
                        {
                            respuesta += "\n- Las columnas tengan título, que esté correctamente escrito y asignado a los datos.";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
            return respuesta;
        }

        private IEnumerable<string[]> LeerCSV()
        {
            List<string[]> lista = new List<string[]>();
            try
            {
                var path = ofdCSV.FileName;
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    if (TieneTitulo)
                        csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        string[] fila = new string[3];
                        string[] fields = csvParser.ReadFields();
                        fila[0] = fields[1];
                        fila[1] = fields[0].Substring(12, fields[0].Length - 12);
                        fila[2] = fields[fields.Length - 1];
                        lista.Add(fila);
                    }
                }
            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
            return lista;
        }

        private int ContarColumnas(TextFieldParser csvParser)
        {
            string[] respuesta = csvParser.ReadFields();
            if (respuesta[0].Equals("Identificador"))
                TieneTitulo = true;
            return respuesta.Length;
        }

        private int ContarFilas(TextFieldParser csvParser)
        {
            int respuesta = 0;
            while (!csvParser.EndOfData)
            {
                csvParser.ReadLine();
                respuesta++;
            }
            return respuesta;
        }

        private string[] GenerarNombres(IEnumerable<string[]> CSV)
        {
            string[] respuesta = new string[CSV.Count()];
            for (int i = 0; i < respuesta.Length; i++)
            {
                respuesta[i] = string.Concat(CSV.ElementAt(i)[0], "_", CSV.ElementAt(i)[1], "_assignsubmission_file_", ofdPDF.SafeFileName);
            }
            return respuesta;
        }

        public void MensajeError(string Mensaje = "Ha ocurrido un error. Comprueba que todos los campos estén llenos.")
        {
            MessageBox.Show(Mensaje, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int[] ObtenerPaginas(IEnumerable<string[]> CSV)
        {
            int[] respuesta = new int[CSV.Count()];
            try
            {
                for (int i = 0; i < respuesta.Length; i++)
                {
                    respuesta[i] = (Convert.ToInt32(CSV.ElementAt(i)[2])) * 2;
                }
            }
            catch
            {
                MensajeError("Ha ocurrido un error en la lectura del archivo CSV. Asegúrate que los datos de la columna \"Hojas\" sean únicamente números.");
                throw;
            }
            return respuesta;
        }

        private void Zippear(string PathSub, string NombreArchivo, string PathCarpeta)
        {
            string ZipName = string.Concat(NombreArchivo, ".zip");
            string ZipLocation = Path.Combine(PathCarpeta, ZipName);
            ZipFile.CreateFromDirectory(PathSub, ZipLocation);
        }

        private void Borrar(string PathSub)
        {
            System.Threading.Thread.Sleep(500);
            ClearAttributes(PathSub);
            Directory.Delete(PathSub, true);
        }

        private void ClearAttributes(string currentDir)
        {
            if (Directory.Exists(currentDir))
            {
                File.SetAttributes(currentDir, FileAttributes.Normal);

                string[] files = Directory.GetFiles(currentDir);
                foreach (string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                }
            }
        }
    }
}
