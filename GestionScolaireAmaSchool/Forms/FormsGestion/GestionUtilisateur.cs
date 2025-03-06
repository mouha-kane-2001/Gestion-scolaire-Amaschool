﻿using System;
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
using BCrypt.Net;
namespace GestionScolaireAmaSchool.Forms.FormsGestion
{
    public partial class GestionUtilisateur : Form
    {
        private DbContextAmaSchool Db;
        public GestionUtilisateur()
        {
            InitializeComponent();
            Db = new DbContextAmaSchool();
            refresh();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string PasswordHacher = BCrypt.Net.BCrypt.HashPassword(Password);
            string role = cmbRole.Text.Trim();
            string telephon = txtTelephon.Text.Trim();
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(Password) ||
       string.IsNullOrEmpty(role) || string.IsNullOrEmpty(telephon))
            {
                MessageBox.Show("Veuiller remplir toute les champs");
                return;
            }
            if (!telephon.All(char.IsDigit) || telephon.Length < 9)
            {
                MessageBox.Show("Le numéro de téléphone est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Utilisateurs utilisateurs = new Utilisateurs();
                utilisateurs.Role = role;
                utilisateurs.MotDePasse = PasswordHacher;
                utilisateurs.Telephone = telephon;
                utilisateurs.NomUtilisateur = nom;
                Db.Utilisateur.Add(utilisateurs);
                Db.SaveChanges();
                clear();
                MessageBox.Show("ajout d un utilisateur avec succes");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'utilisateur : {ex.Message}");

            }
        }

       private void clear()
        {
            
            txtNom.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            txtTelephon.Clear();
        }
        private void refresh()
        {
            dtgvUser.DataSource = null;
            dtgvUser.DataSource = Db.Utilisateur.ToList();
        }

        void remplirChmps()
        {
            if (dtgvUser.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgvUser.SelectedRows[0];
                int Id = Int32.Parse(Row.Cells["Id"].Value.ToString());
                string ID = Id.ToString();
                MessageBox.Show("l id est "); MessageBox.Show(ID);
                Utilisateurs utilisateurs = new Utilisateurs();
                utilisateurs = Db.Utilisateur.Find(Id);
                if (utilisateurs != null)
                {
                    txtNom.Text = utilisateurs.NomUtilisateur;
                    txtPassword.Text = (utilisateurs.MotDePasse).ToString();
                    cmbRole.SelectedItem = utilisateurs.Role;
                    txtTelephon.Text = (utilisateurs.Telephone).ToString();

                }
            } else { MessageBox.Show("aucun ligne recupere"); }

        }


       

        private void dtgvUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            remplirChmps();
            MessageBox.Show("ok doubleclik");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string PasswordHAsh = BCrypt.Net.BCrypt.HashPassword(Password);
            string role = cmbRole.Text.Trim();
            string telephon = txtTelephon.Text.Trim();
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(Password) ||
       string.IsNullOrEmpty(role) || string.IsNullOrEmpty(telephon))
            {
                MessageBox.Show("Veuiller remplir toute les champs");
                return;
            }
            if (!telephon.All(char.IsDigit) || telephon.Length < 9)
            {
                MessageBox.Show("Le numéro de téléphone est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Utilisateurs utilisateurs = new Utilisateurs();
                utilisateurs.Role = role;
                utilisateurs.MotDePasse = PasswordHAsh;
                utilisateurs.Telephone = telephon;
                utilisateurs.NomUtilisateur = nom;
            
                Db.SaveChanges();
                clear();
                MessageBox.Show("Modification d un utilisateur avec succes");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors deModification de l'utilisateur : {ex.Message}");

            }

        }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {


            if (dtgvUser.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = dtgvUser.SelectedRows[0];
                int Id = Int32.Parse(Row.Cells["Id"].Value.ToString());
                string ID = Id.ToString();
                MessageBox.Show("l id est "); MessageBox.Show(ID);
                Utilisateurs utilisateurs = new Utilisateurs();
                utilisateurs = Db.Utilisateur.Find(Id);
                if (utilisateurs != null)
                {
                    DialogResult resultat = MessageBox.Show("est tu sur de vouloir suprimer ", "confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultat == DialogResult.Yes)
                    {
                        Db.Utilisateur.Remove(utilisateurs);
                        Db.SaveChanges();
                        MessageBox.Show("Supression avec succes");
                    }
                   
                }
                else { MessageBox.Show("Aucun user trouver"); }
            }
            else { MessageBox.Show("Supression avec succes"); }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1; 
            txtTelephon.Text = "";

            dtgvUser.ClearSelection();
            MessageBox.Show("Operation annule. Les champs ont ete reinitialiser.", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    }

}