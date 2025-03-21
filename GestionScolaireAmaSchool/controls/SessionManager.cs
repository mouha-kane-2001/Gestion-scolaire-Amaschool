using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionScolaireAmaSchool.Forms.FormsAuthentification;
using System.Windows.Forms;

namespace GestionScolaireAmaSchool.controls
{
    internal class SessionManager
    {
        private static string userRole = ""; 

       
        public static string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }

        public static bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(userRole);
        }

        public static void LogoutAndRedirectToLogin()
        {
            foreach (Form form in Application.OpenForms)
            {
                    form.Close();              
            }

            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        public static void CheckAuthentication()
        {
            if (!IsAuthenticated())
            {
                LogoutAndRedirectToLogin();
            }
        }

        
    }
}
