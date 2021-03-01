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
    //משותף לכל המשתמשים
    public partial class WorkerOwnerForm : Form
    {
        private OwnerModel ownerModel = new OwnerModel();
        private WorkerModel workerModel = new WorkerModel();
        private Person person;
        private int tabDogIndex = -1,tabMeetingIndex = -1, tabIndex = 0;

        private void buttons_Click(int index, string stringForm)
        {
            Form form = null;
            string nameFromKey = "", nameFromValue = "";
            switch (stringForm)
            {
                case "DogForm":
                    form = new DogForm(label_Title.Text, person.ID);
                    nameFromKey = "Dog";
                    nameFromValue = "Dog";
                    tabControl_Forms.Visible = true;
                    break;
                case "MeetingForm":
                    form = new MeetingForm(label_Title.Text, person.ID);
                    nameFromKey = "Meeting";
                    nameFromValue = "Meeting";
                    tabControl_Forms.Visible = true;
                    break;
            }

            if (index < 0)
            {
                tabControl_Forms.TabPages.Add(nameFromKey, nameFromValue);
                form.TopLevel = false;
                form.Visible = true;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                tabControl_Forms.TabPages[tabIndex].Controls.Add(form);
                tabIndex++;
                tabControl_Forms.SelectTab(nameFromKey);
            }
            else tabControl_Forms.SelectTab(nameFromKey);

            switch (nameFromKey)
            {
                case "Dog": tabDogIndex = tabIndex; break;
                case "Meeting": tabMeetingIndex = tabIndex; break;
               // case "Profile": tabProfileIndex = tabIndex; break;
               
            }
        }

        public WorkerOwnerForm(string human = "", string id = "", string role = "")
        {
            InitializeComponent();
            label_Title.Text = human;
            bunifuImageButton_AddWorker.Visible = false;
            if (human == "Worker")
            {

                person = workerModel.get(id);//אדם ולא עובד
                if (role == "Employee")
                    button_Dog.BackColor = button_Meeting.BackColor = button_Profile.BackColor = Color.Green;
                else if (role == "Management")
                {

                    bunifuImageButton_AddWorker.Visible = true;
                    button_Dog.BackColor = button_Meeting.BackColor = button_Profile.BackColor = Color.Blue;
                }
            }
            else if (human == "Owner")
            {
                person = ownerModel.get(id);
                button_Dog.BackColor = button_Meeting.BackColor = button_Profile.BackColor = Color.Orange;
            }
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {

            AUProfileForm form = new AUProfileForm(label_Title.Text, person.ID);
            form.ShowDialog();
            
        }

        private void bunifuImageButton_AddWorker_Click(object sender, EventArgs e)
        {
            Form form = new RegisterForm("Worker");
            form.ShowDialog();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Dog_Click(object sender, EventArgs e)
        {
            buttons_Click(tabDogIndex, "DogForm");
        }
        private void button_Meeting_Click(object sender, EventArgs e)
        {
            buttons_Click(tabMeetingIndex, "MeetingForm");
        }
    }
}
