using ClosedXML.Excel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MedicinasResidenciaCanoGonzalo
{
    public partial class FormInformes : Form
    {
        private int _idUsuario;
        private int _idRol;
        public FormInformes(int idUsuario, int idRol)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _idRol = idRol;



        }

        private void FormInformes_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = true;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<string> camposSeleccionados = new List<string>();

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {

                    string campoBD = MapearCampo(cb.Text);
                    if (!string.IsNullOrEmpty(campoBD))
                        camposSeleccionados.Add(campoBD);
                }
            }

            if (camposSeleccionados.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un campo para generar el informe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string camposSQL = string.Join(", ", camposSeleccionados);

            string consulta = $@"
                SELECT {camposSQL}
                FROM Residente r
                INNER JOIN Prescripcion p ON r.IdResidente = p.IdResidente
                WHERE p.Estado = 'A'";

            try
            {
                DataTable dt = EjecutarConsulta(consulta);
                dgvInforme.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string MapearCampo(string campoVisible)
        {
            switch (campoVisible)
            {
                case "Nombre completo": return "r.Nombre";
                case "Id residente": return "r.IdResidente";
                case "Fecha de entrada": return "r.FechaEntrada";
                case "Habitación": return "r.NumeroHabitacion";
                case "Medicamento": return "p.NombreMedicamento";
                case "Fecha de inicio": return "p.FechaAlta";
                case "Fecha de modificacion": return "p.FechaModificacion";
                case "Estado": return "p.Estado";
                case "Dosis": return "p.Dosis";
                default: return null;
            }
        }

        private DataTable EjecutarConsulta(string consulta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvInforme.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var wb = new XLWorkbook();
                        var ws = wb.Worksheets.Add("Informe");

                        for (int i = 0; i < dgvInforme.Columns.Count; i++)
                            ws.Cell(1, i + 1).Value = dgvInforme.Columns[i].HeaderText;

                        for (int i = 0; i < dgvInforme.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvInforme.Columns.Count; j++)
                            {
                                ws.Cell(i + 2, j + 1).Value = dgvInforme.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                        }

                        ws.Cell(1, dgvInforme.Columns.Count + 2).Value = "Fecha generación:";
                        ws.Cell(2, dgvInforme.Columns.Count + 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                        ws.Cell(4, dgvInforme.Columns.Count + 2).Value = "Número de líneas:";
                        ws.Cell(5, dgvInforme.Columns.Count + 2).Value = dgvInforme.Rows.Count;

                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Exportado correctamente a Excel.", "Éxito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar a Excel: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvInforme.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                        {
                            PdfWriter writer = new PdfWriter(fs);
                            PdfDocument pdf = new PdfDocument(writer);
                            Document document = new Document(pdf);

                            document.Add(new Paragraph("Informe de residentes y prescripciones")
                                .SetTextAlignment(TextAlignment.CENTER).SetFontSize(16));
                            document.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                                .SetTextAlignment(TextAlignment.RIGHT));
                            document.Add(new Paragraph("\n"));

                            Table table = new Table(dgvInforme.Columns.Count, true);

                            foreach (DataGridViewColumn column in dgvInforme.Columns)
                            {
                                table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                            }

                            foreach (DataGridViewRow row in dgvInforme.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                                    }
                                }
                            }

                            document.Add(table);
                            document.Add(new Paragraph($"\nNúmero de líneas: {dgvInforme.Rows.Count}"));

                            document.Close();
                        }

                        MessageBox.Show("Exportado correctamente a PDF.", "Éxito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error");
                    }
                }
            }
        }
    }
}
