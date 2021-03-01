using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogForLife
{
    public partial class LoginForm : Form
    {
        private OwnerModel ownerModel = new OwnerModel();
        private WorkerModel workerModel = new WorkerModel();
        public LoginForm()
        {
            InitializeComponent();
            bunifuTextbox_Password._TextBox.PasswordChar = '*';
        }

        private void bunifuThinButton_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuThinButton_OK_Click(object sender, EventArgs e)
        {
            string username = bunifuTextbox_User._TextBox.Text,
                password = bunifuTextbox_Password._TextBox.Text;

            if (username != "" && password != "")
            {
                var worker = workerModel.get(username);
                var owner = ownerModel.get(username);
                if (worker != null)
                {
                    if (worker.ID == username && worker.Password == password)
                    {
                        WorkerOwnerForm workerOwnerForm = new WorkerOwnerForm("Worker",username, worker.Role);
                        workerOwnerForm.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("One of the data is incorrect");
                }
                else if (owner != null)
                {
                    if (owner.ID == username && owner.Password == password)
                    {
                        WorkerOwnerForm workerOwnerForm = new WorkerOwnerForm("Owner",username);
                        workerOwnerForm.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("One of the data is incorrect");
                }
                else MessageBox.Show("The user does not exit");
            }
            else if(username == "" && password == "")
                MessageBox.Show("Enter the user's ID and password");
            else if(username == "")
                MessageBox.Show("Enter the user's ID");
            else MessageBox.Show("Enter the user's password");

        }

        private void bunifuThinButton_Register_Click(object sender, EventArgs e)
        {
            RegisterForm workerForm = new RegisterForm();
            workerForm.Show();
            this.Hide();
        }

        private void bunifuTextbox_User_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked == true)
                bunifuTextbox_Password._TextBox.PasswordChar = '\0';
            else bunifuTextbox_Password._TextBox.PasswordChar = '*';
        }
    }
}
