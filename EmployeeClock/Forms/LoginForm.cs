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
        internal DBcontext db = new DBcontext("Data Source=YAIR-ACHRACK;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        internal LoginForm(DBcontext dbcontext)
        {
            InitializeComponent();
            _dbContext = dbcontext;
            Login();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {

            FromHandler.ShowFrom("ClockFrom");

        }
        public void Login()
        {

            DataTable dt = _dbContext.MakeQuery("select e.employeeID, p.Password from Employees e join Passwords p where @textBox_Id.text = e.employeeID and textBox_Password =  p.Password ");
             static void printDT(DataTable dt)
            {
                [DllImport("kernel32.dll")]
                static extern bool AllocConsole();
                [DllImport("kernel32.dll")]
                static extern bool FreeConsole();
                // Call AllocConsole() to create a console window
                AllocConsole();
                // Now Console.WriteLine() will output to this console window
                foreach (DataColumn column in dt.Columns)
                {
                    Console.Write($"{column.ColumnName,-20}"); // Adjust the width as needed
                }
                Console.WriteLine();
                // Print data rows
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write($"{item,-20}"); // Adjust the width as needed
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                // Don't forget to free the console when done
                FreeConsole();
            }
            printDT(dt);
        }


        private void button_change_password_Click(object sender, EventArgs e)
        {
            FromHandler.ShowFrom("password_Click");
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
