using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionScolaireAmaSchool.Data;
using GestionScolaireAmaSchool.Entity;
using GestionScolaireAmaSchool.controls;
using System.Net;
using iTextSharp.text;


namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class FormGestionNotes : Form
    {
        private DbContextAmaSchool Db;
        private List<Etudiants> listEtudiants = new List<Etudiants>();
        private List<Matieres> listMatieres = new List<Matieres>();
        private List<Classes> listClasses = new List<Classes>();

       
        public FormGestionNotes()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
            listClasses = Db.Classe.ToList();
            listEtudiants = Db.Etudiant.ToList();
            listMatieres = Db.Matiere.ToList();

        }
        
        
           
            
        private void FormGestionNotes_Load(object sender, EventArgs e)
        {
           
            chargementDedonneeinitial();
            chargementDedonnee2();
            caherTout();
        }

        void chargementDedonneeinitial()
        {
            Validation.chargementCombo(cmbClasse,"NomClasse", "Id",listClasses);
            Validation.chargementCombo(cmbMatiere, "NomMatiere", "Id", listMatieres);
            Validation.chargementCombo(cmbEtudiant, "Matricule", "Id",listEtudiants);
        }
        void chargementDedonnee2()
        {
            Validation.chargementCombo(cmbClasse1, "NomClasse", "Id", listClasses);
            Validation.chargementCombo(cmbMatiere1, "NomMatiere", "Id", listMatieres);
            Validation.chargementCombo(cmbEtudiant1, "Matricule", "Id", listEtudiants);
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int notedefaut = 0;
            if (Validation.ChampsEstvide(txtNote.Text) )
            {  
                Validation.MessageErreur("veuillez remplir tous les champs");
                return;
            }
            if (!int.TryParse(txtNote.Text, out notedefaut))
            {             
                Validation.MessageErreur("erreur de conversion");
                return;
            }
            
            
            int noteInt = int.Parse(txtNote.Text);
            if (char.IsDigit((char)noteInt)) {               
                Validation.MessageErreur("pas de caractere dans le note");
                return;
            }

            if (noteInt < 0 || noteInt > 20)
            {
                Validation.MessageErreur("veuillez entrer un note  invalide compri entre 0 et 2");            
                return;
            }


            int idMatiere = ((Matieres)cmbMatiere.SelectedItem).Id;
            int idEtu = ((Etudiants)cmbEtudiant.SelectedItem).Id;
          
                Notes notes = new Notes();
                notes.IdMatiere = idMatiere;
                notes.IdEtudiant = idEtu;
                notes.Valeur = (noteInt);
                Db.Note.Add(notes);
                Db.SaveChanges();

            Validation.MessageInfo("note ajouter avec succes");

            refresh(notes.IdEtudiant,notes.IdMatiere);
            Validation.Showw(paneldtgvNote);

        }
        private void refresh(int idEtu, int matiere)
        {

            var list = Db.Note.Where(
                c=>c.IdEtudiant== idEtu && c.IdMatiere ==c.IdMatiere)
                .Select(p => new {p.Id,p.Etudiants.Matricule,p.Matieres.NomMatiere,p.Valeur}).ToList();
            if (list.Count > 0)
            {
                Validation.chargerGridvies(dtgvNote, list);
            }
            else
            {
                Validation.MessageErreur("aucun note pour cette etudiant dans cette matiere ");
            }
        }

        private void cmbClasse_TextChanged(object sender, EventArgs e)
        {
           
            int idClasse = ((Classes)(cmbClasse.SelectedItem)).Id;
            var list = Db.Etudiant.Where(c=>c.IdClasse== idClasse)
                .Select(c =>  new {c.Matricule,c.Id}).ToList();
            Validation.chargementCombo(cmbEtudiant, "Matricule", "Id", list);

        }

        private void btnAllEtudiant_Click(object sender, EventArgs e)
        {
            var list = Db.Etudiant.Select(c => new {c.Id,c.Matricule}).ToList();
            Validation.chargementCombo(cmbEtudiant, "Matricule", "Id", list);
        }

        private void cmbClasse_TextChanged1(object sender, EventArgs e)
        {
            int idClasse = ((Classes)(cmbClasse1.SelectedItem)).Id;
            var list = Db.Etudiant.Where(c => c.IdClasse == idClasse)
                .Select(c => new { c.Matricule, c.Id }).ToList();
            Validation.chargementCombo(cmbEtudiant1, "Matricule", "Id", list);
        }

        private void btnVoirRelever_Click(object sender, EventArgs e)
        {
            caherTout();
            panelReleverEtNote.Visible = true;
            panelConteneur.Controls.Clear();
            panelConteneur.Controls.Add(panelReleverEtNote);
            panelReleverEtNote.BringToFront();
            panelReleverEtNote.Refresh();
            btnNote.Visible = false;
            btnRe.Visible = true;
        }

        private void btnVoirNote_Click(object sender, EventArgs e)
        {
            caherTout();
            panelReleverEtNote.Visible = true;
            panelConteneur.Controls.Clear();
            panelConteneur.Controls.Add(panelReleverEtNote);
            panelReleverEtNote.BringToFront();
            panelReleverEtNote.Refresh();
            btnNote.Visible = true;
            btnRe.Visible = false;
            panelReleverEtNote.Visible = true;
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            int idClasse = ((Classes)(cmbClasse1.SelectedItem)).Id;
            int idEtu = ((Etudiants)(cmbEtudiant1.SelectedItem)).Id;
            int idmatier = ((Matieres)(cmbMatiere1.SelectedItem)).Id;

            var list = Db.Note.Where(
                c => c.IdEtudiant == idEtu && c.IdMatiere == c.IdMatiere)
                .Select(p => new {p.Id, p.Etudiants.Matricule, p.Matieres.NomMatiere, p.Valeur }).ToList();
          
            if (list.Count > 0)
            {
                Validation.chargerGridvies(dtgvNote, list);
                Validation.Showw(paneldtgvNote);

            }
            else {
                MessageBox.Show("Aucun note pour cette etudiant", "note vide ", MessageBoxButtons.OK);
                dtgvNote = null;
                dtgvNote.Rows.Clear();
            }
            
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            string matEtu = cmbEtudiant1.Text;
               
            int idEtu = Db.Etudiant.Where(c => c.Matricule == matEtu)
                .Select(p => p.Id).FirstOrDefault();

          
            var moyenneParMatiere = Db.Note.Where(
                c => c.IdEtudiant == idEtu).GroupBy(
                n=>n.Matieres.NomMatiere
                )
           .Select(p => new { 
               Matiere = p.Key,
               Moyenne = p.Average(c=>c.Valeur)
            }).ToList();

            if (moyenneParMatiere.Count > 0)
            {
                Validation.chargerGridvies(dtgvNote, moyenneParMatiere);
                Validation.Showw(paneldtgvNote);

            }
            else
            {
               
                Validation.MessageErreur("aucun relever pour ce note");

            }

            var MoyenGeneral = moyenneParMatiere.Average
                (c=>c.Moyenne);
             txtMGeneral.Text = MoyenGeneral.ToString();
                 
        }
        public void caherTout()
        {
            Validation.Hidee(panelAjoutEtud);
            Validation.Hidee(paneldtgvNote);
            Validation.Hidee(panelMoyene);
            Validation.Hidee(panelReleverEtNote);
            
        }

        private void btnVajout_Click(object sender, EventArgs e)
        {
            caherTout();
            panelAjoutEtud.Visible = true;   
            panelConteneur.Controls.Clear();
            panelConteneur.Controls.Add(panelAjoutEtud);
            panelAjoutEtud.BringToFront();
            panelAjoutEtud.Refresh();
        
        }

        void remplirChmps()
        {
            if (dtgvNote.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgvNote.SelectedRows[0];
                int Id = Int32.Parse(Row.Cells["Id"].Value.ToString());
                string ID = Id.ToString();

                Notes notes = Db.Note.Find(Id);
                
                if (notes != null)
                {
                    txtNote.Text = (notes.Valeur).ToString();
                    cmbClasse.Hide();
                    cmbEtudiant.Hide();
                    cmbMatiere.Hide();
                    txtId.Text = Id.ToString();
           
                }
            }
            else
            {
                Validation.MessageErreur("aucun ligne recupere");
            }

        }

        private void dtgvNote_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            remplirChmps();
            caherTout();
            panelAjoutEtud.Visible = true;
            panelConteneur.Controls.Clear();
            panelConteneur.Controls.Add(panelAjoutEtud);
            panelAjoutEtud.BringToFront();
            panelAjoutEtud.Refresh();
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            int notedefaut = 0;
            if (Validation.ChampsEstvide(txtNote.Text))
            {
                Validation.MessageErreur("veuillez remplir tous les champs");
                return;
            }
            if (!int.TryParse(txtNote.Text, out notedefaut))
            {
                Validation.MessageErreur("erreur de conversion");
                return;
            }


            int noteInt = int.Parse(txtNote.Text);
            if (char.IsDigit((char)noteInt))
            {
                Validation.MessageErreur("pas de caractere dans le note");
                return;
            }

            if (noteInt < 0 || noteInt > 20)
            {
                Validation.MessageErreur("veuillez entrer un note  invalide compri entre 0 et 2");
                return;
            }

            int idNote = int.Parse(txtId.Text);
            Notes notes = Db.Note.Find(idNote);    
            notes.Valeur = (noteInt);
            Db.SaveChanges();
            Validation.MessageInfo("note modifier avec succes");
            refresh(notes.IdEtudiant, notes.IdMatiere);
            Validation.Showw(paneldtgvNote);
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            if (dtgvNote.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgvNote.SelectedRows[0];
                int Id = Int32.Parse(Row.Cells["Id"].Value.ToString());
                string ID = Id.ToString();
                MessageBox.Show("l id est "); MessageBox.Show(ID);
                Utilisateurs utilisateurs = new Utilisateurs();
                Notes not = Db.Note.Find(Id);
                if (not != null)
                {

                    if (Validation.MessageConfirmation("est tu sur de vouloir suprimer"))
                    {
                        Db.Note.Remove(not);
                        Db.SaveChanges();
                        Validation.MessageInfo("Supression avec succes");

                    }

                }
                else
                {
                    Validation.MessageErreur("Aucun note trouver");
                }
            }
            else { Validation.MessageErreur("erreur de supression avec succes"); }

        }
    }
}
