using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobMatch
{
    [Flags]
    public enum Type
    {
        None = 0,
        JobSeeker = 1,
        Employer = 2
    }
    public partial class LoginForm : Form
    {
        Type type;
        public LoginForm()
        {
            type = Type.None;
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check The Input data with the registered data;

            if (radioButton1.Checked)
            {
                type = Type.JobSeeker;
                if (LoginValidation.Validate(type, username_box.Text, password_box.Text))
                {
                    Hide();
                    JobSeekerMenu JSMenu = new JobSeekerMenu();
                    JSMenu.ShowDialog(this);
                    Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }
            else if (radioButton2.Checked)
            {
                type = Type.Employer;
                if (LoginValidation.Validate(type, username_box.Text, password_box.Text))
                {
                    Hide();
                    EmployerMenu EMenu = new EmployerMenu();
                    EMenu.ShowDialog(this);
                    Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Please choose a type of login");
            }
    
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterUser registerForm = new RegisterUser();
            registerForm.ShowDialog(this);
            Show();
            
            
        }
    }
}
