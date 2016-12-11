using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobMatch.Database;

namespace JobMatch
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
           
            if (employer_rdbtn.Checked)
            {
                Employer emp = new Employer()
                {
                    Name = name_box.Text.ToString(),
                    Username = username_box.Text.ToString(),
                    Password = password_box.Text.ToString(),
                    Email = email_box.Text.ToString()
                };
                EmployerController empController = new EmployerController();
                empController.Insert(emp);

            }
            Dispose();
        }
    }
}
