using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock 
{
    public partial class LoginForm : Form
    {
        internal DBcontext _dbContext;
        
        internal LoginForm(DBcontext dbcontext)
        {
            InitializeComponent();
            _dbContext = dbcontext;
            


        }

        private void button_enter_Click(object sender, EventArgs e)
        {

            FromHandler.ShowFrom("ClockFrom");

        }
        public void Login()
        {
            MessageBox.Show(textBox_Id.Text);

            DataTable dt = _dbContext.MakeQuery("select e.employeeID, p.Password    " +
                                                "from Employees e " +
                                               "join Passwords p on e.EmployeeCode = p.EmployeeCode " +
                                               $"where {int.Parse (textBox_Id.Text)} = e.employeeID"
                                               );


            List<string> results = new List<string>();

            // מעבר על כל שורה בטבלה
            foreach (DataRow row in dt.Rows)
            {
                // אחסון הערכים של כל עמודה בשורה במחרוזת אחת
                string rowString = string.Join(", ", row.ItemArray.Select(item => item.ToString()));

                // הוספת המחרוזת לרשימת התוצאות
                results.Add(rowString);
            }

            // הפיכת הרשימה למחרוזת אחת עם שורות נפרדות (אפשר להחליף "\n" בהתאם לפורמט הרצוי)
            string resultString = string.Join("\n", results);

            // הצגת התוצאה
            MessageBox.Show(resultString);

        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            FromHandler.ShowFrom("password_Click");
            Login();
        }


    }
}
