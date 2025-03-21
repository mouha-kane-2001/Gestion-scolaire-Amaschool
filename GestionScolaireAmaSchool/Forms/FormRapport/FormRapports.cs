using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;

namespace GestionScolaireAmaSchool.Forms.FormRapport
{
    public partial class FormRapports : Form
    {
        private DbContextAmaSchool Db;
        public FormRapports()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
        }

        private void FormRapports_Load(object sender, EventArgs e)
        {

        }


        private void btnAllUser1_Click(object sender, EventArgs e)
        {
            dtgvRapport.DataSource = null;
            var user = Db.Utilisateur.ToList();
            if (user.Count > 0)
            {
                dtgvRapport.DataSource = user;

            }
            else
            {
                MessageBox.Show("ERREUR", "aucun utilisateur", MessageBoxButtons.OK);
                dtgvRapport.Rows.Clear();
            }
        }

        private void FormRapport_Load(object sender, EventArgs e)
        {

        }



        private void btnAllEtudiant1_Click_1(object sender, EventArgs e)
        {
            dtgvRapport.DataSource = null;
            var etudiant = Db.Etudiant.ToList();
            if (etudiant.Count > 0)
            {
                dtgvRapport.DataSource = etudiant;

            }
            else
            {
                MessageBox.Show("ERREUR", "aucun etudiant", MessageBoxButtons.OK);
            }
        }

        private void btnAllProf1_Click_1(object sender, EventArgs e)
        {

            dtgvRapport.DataSource = null;
            var etudiant = Db.Utilisateur.Where(
                c => c.Role == "professeur").ToList();
            if (etudiant.Count > 0)
            {
                dtgvRapport.DataSource = etudiant;
            }
            else
            {
                MessageBox.Show("ERREUR", "aucun Professeur", MessageBoxButtons.OK);
                dtgvRapport.Rows.Clear();
            }
        }

        private void btnAllClasse1_Click_1(object sender, EventArgs e)
        {

            dtgvRapport.DataSource = null;
            var classe = Db.Classe.ToList();
            if (classe.Count > 0)
            {
                dtgvRapport.DataSource = classe;

            }
            else
            {
                MessageBox.Show("ERREUR", "aucun classe", MessageBoxButtons.OK);
                dtgvRapport.Rows.Clear();
            }
        }

        private void btnAllMatiere1_Click_1(object sender, EventArgs e)
        {
            dtgvRapport.DataSource = null;
            var mat = Db.Matiere.ToList();
            if (mat.Count > 0)
            {
                dtgvRapport.DataSource = mat;

            }
            else
            {
                MessageBox.Show("ERREUR", "Aucun Matiere", MessageBoxButtons.OK);
                dtgvRapport.Rows.Clear();
            }
        }

        private void btnAllUser1_Click_1(object sender, EventArgs e)
        {
            dtgvRapport.DataSource = null;
            var user = Db.Utilisateur.ToList();
            if (user.Count > 0)
            {
                dtgvRapport.DataSource = user;

            }
            else
            {
                MessageBox.Show("ERREUR", "aucun UTILISATEUR", MessageBoxButtons.OK);
                dtgvRapport.Rows.Clear();
            }
        }

        private void btnExporterPdf_Click(object sender, EventArgs e)
        {


            if (dtgvRapport.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Rapport.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Impossible d'écrire sur le disque. Détails : " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgvRapport.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dtgvRapport.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgvRapport.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Exporté en PDF avec succès !", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun enregistrement à exporter !", "Info");
            }

        }

        private void btnExporterExcel_Click(object sender, EventArgs e)
        {
            if (dtgvRapport.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Rapport.xlsx";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Impossible d'écrire sur le disque. Détails : " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            using (ExcelPackage pck = new ExcelPackage(new FileInfo(sfd.FileName)))
                            {
                                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Rapport");
                                ws.Cells["A1"].LoadFromDataTable((DataTable)dtgvRapport.DataSource, true);
                                pck.Save();
                            }

                            MessageBox.Show("Exporté en Excel avec succès !", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun enregistrement à exporter !", "Info");
            }

        }
    }
}
