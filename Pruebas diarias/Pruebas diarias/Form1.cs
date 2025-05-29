using Pruebas_diarias.Capa_Entidad;
using Pruebas_diarias.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace Pruebas_diarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        PerroBO logica = new PerroBO();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPerros.DataSource = logica.Listar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Perro p = new Perro
            {
                Nombre = txtnombre.Text,
                Raza = cboraza.Text,
                Edad = int.Parse(txtedad.Text),
                Vacunas = txtvacunas.Text
            };
            logica.Agregar(p);
            dgvPerros.DataSource = logica.Listar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvPerros.CurrentRow != null)
            {
                Perro p = new Perro
                {
                    Id = (int)dgvPerros.CurrentRow.Cells["Id"].Value,
                    Nombre = txtnombre.Text,
                    Raza = cboraza.Text,
                    Edad = int.Parse(txtedad.Text),
                    Vacunas = txtvacunas.Text
                };
                logica.Editar(p);
                dgvPerros.DataSource = logica.Listar();
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (dgvPerros.CurrentRow != null)
            {
                int id = (int)dgvPerros.CurrentRow.Cells["Id"].Value;
                logica.Eliminar(id);
                dgvPerros.DataSource = logica.Listar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPerros.DataSource = logica.Buscar(txtnombre.Text);
        }

        private void dgvPerros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPerros.CurrentRow != null)
            {
                txtnombre.Text = dgvPerros.CurrentRow.Cells["Nombre"].Value.ToString();
                cboraza.Text = dgvPerros.CurrentRow.Cells["Raza"].Value.ToString();
                txtedad.Text = dgvPerros.CurrentRow.Cells["Edad"].Value.ToString();
                txtvacunas.Text = dgvPerros.CurrentRow.Cells["Vacunas"].Value.ToString();
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (dgvPerros.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            // Ruta para guardar el archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "ListaPerros.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        Paragraph titulo = new Paragraph("Lista de Perros", tituloFont);


                        titulo.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(titulo);
                        pdfDoc.Add(new Paragraph("\n"));

                        PdfPTable pdfTable = new PdfPTable(dgvPerros.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Agregar encabezados
                        foreach (DataGridViewColumn column in dgvPerros.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            pdfTable.AddCell(cell);
                        }

                        // Agregar filas
                        foreach (DataGridViewRow row in dgvPerros.Rows)
                        {
                            if (row.IsNewRow) continue;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message);
                }
            }
        }
    }
}
