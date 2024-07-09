using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock
{
     internal static class FromHandler
    { 
        static private string  connStr = "Data Source=YAIR-ACHRACK;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";
        static DBcontext DBcontext = new DBcontext(connStr);
        public static void CloseAllForms()
        {
            while (Application.OpenForms.Count > 0) 
            {
                Application.OpenForms[0].Close();
            }


        }
        public static void ShowFrom(string formName)
        {
            CloseAllForms();
            

            Form form = formName switch
            {
                "password_Click" => new PasswordChangeForm(),
                "ClockFrom" => new ClockFrom(),
                "LoginForm" => new LoginForm(DBcontext),

                _ => throw new ArgumentException("Invalid", nameof(formName)),
            };
            form.Show();
        }

    }
}
