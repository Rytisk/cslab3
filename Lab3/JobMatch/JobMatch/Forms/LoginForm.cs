using System;
using System.Windows.Forms;
using JobMatch.Database;

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
        private int _myId;
        Type type;

        public LoginForm()
        {
            type = Type.None;
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                type = Type.JobSeeker;
                if (LoginValidation.Validate(type, username_box.Text, password_box.Text))
                {
                    JobSeekerController jscontr = new JobSeekerController();
                    _myId = jscontr.GetIdByUsername(username_box.Text);
                    Hide();
                    JobSeekerMenu JSMenu = new JobSeekerMenu(_myId);
                    JSMenu.ShowDialog(this);
                    username_box.Text = "";
                    password_box.Text = "";
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
                    EmployerController empcontr = new EmployerController();
                    _myId = empcontr.GetIdByUsername(username_box.Text);
                    Hide();
                    EmployerMenu EMenu = new EmployerMenu(_myId);
                    EMenu.ShowDialog(this);
                    username_box.Text = "";
                    password_box.Text = "";
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
