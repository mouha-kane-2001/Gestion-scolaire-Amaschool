using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionScolaireAmaSchool.controls
{
    internal class Validation
    {
        public Validation() { }

      
        
        public static Boolean ChampsEstvide(string txt)
        {
          return  string.IsNullOrEmpty(txt);
        }
        public static Boolean ComboEstvide(ComboBox combo)
        {
            return true;
        }
       public static void chargementCombo(ComboBox combo, string display, string value,object datasource)
        {
            combo.DataSource = null;
            combo.DataSource = datasource;
            combo.DisplayMember = display;
            combo.ValueMember = value;
        }

        public static void MessageErreur(string message)
        {
            MessageBox.Show(message,"erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageWarning(string message)
        {
            MessageBox.Show(message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void MessageInfo(string message)
        {
            MessageBox.Show(message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static  bool MessageConfirmation(string message)
        {
          return  MessageBox.Show(message, "confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void chargerGridvies(DataGridView gtgv,object datasource)
        {
            gtgv.DataSource = null;
            gtgv.DataSource = datasource;
        }
        public static void Hidee(Control hiden )
        {
            hiden.Visible=false;
        }
        public static void Showw(Control hiden)
        {
            hiden.Visible = true;
        }
    }
}
