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
    public partial class AUProfileForm : Form
    {
        private WorkerModel workerModel = new WorkerModel();
        private OwnerModel ownerModel = new OwnerModel();
        private Worker worker = null;
        private Owner owner = null;


        private string statusUpdateSaveClick = "Update";

        public AUProfileForm(string human = null, string id = null)
        {
            InitializeComponent();
            if (human == "Worker")
            {
                worker = workerModel.get(id);

                textBox_ID.Text = worker.ID;
                textBox_Password.Text = worker.Password;
                var name = worker.Name.Split(' ');
                textBox_Firstname.Text = name[0];
                textBox_Lastname.Text = name[1];
                textBox_DateOfBirth.Text = worker.DateOfBirth;
                textBox_Address.Text = worker.Address;
                textBox_Phone.Text = worker.Phone;
                var email = worker.Email.Split('@');
                textBox_firstEmail.Text = email[0];
                comboBox_Email.Text = email[1];
                comboBox_Gender.Text = worker.Gender;
                textBox_DateOfBirth.Text = worker.DateOfBirth;
            }
            else if (human == "Owner")
            {
                owner = ownerModel.get(id);

                textBox_ID.Text = owner.ID;
                textBox_Password.Text = owner.Password;
                var name = owner.Name.Split(' ');
                textBox_Firstname.Text = name[0];
                textBox_Lastname.Text = name[1];
                textBox_DateOfBirth.Text = owner.DateOfBirth;
                textBox_Address.Text = owner.Address;
                textBox_Phone.Text = owner.Phone;
                var email = owner.Email.Split('@');
                textBox_firstEmail.Text = email[0];
                comboBox_Email.Text = email[1];
                comboBox_Gender.Text = owner.Gender;
                textBox_DateOfBirth.Text = owner.DateOfBirth;

            }
            textBox_ID.Enabled = textBox_Password.Enabled = textBox_Firstname.Enabled = 
                textBox_Lastname.Enabled = textBox_Address.Enabled = textBox_Phone.Enabled = 
                textBox_firstEmail.Enabled = comboBox_Email.Enabled = comboBox_Gender.Enabled = 
                textBox_DateOfBirth.Enabled = false;
            if (statusUpdateSaveClick == "Update")
            {
                button_UpdateSave.IdleFillColor = Color.Gold;
                button_UpdateSave.ButtonText = "Update";
            }

        }
        private void button_UpdateSave_Click(object sender, EventArgs e)
        {
            bool b = !textBox_DateOfBirth.Enabled;
            textBox_Password.Enabled = textBox_Firstname.Enabled =
                 textBox_Lastname.Enabled = textBox_Address.Enabled = textBox_Phone.Enabled =
                 textBox_firstEmail.Enabled = comboBox_Email.Enabled = comboBox_Gender.Enabled =
                 textBox_DateOfBirth.Enabled = b;
            if (statusUpdateSaveClick == "Update")
            {
                
                button_UpdateSave.IdleFillColor = Color.Green;
                button_UpdateSave.ButtonText = "Save";
                statusUpdateSaveClick = "Save";
            }
            else
            {
                statusUpdateSaveClick = "Update";
                if (worker != null)
                {
                    var w = new Worker(textBox_ID.Text, textBox_Firstname.Text + " " + textBox_Lastname.Text,
                        textBox_DateOfBirth.Text, comboBox_Gender.Text, textBox_Password.Text, textBox_Phone.Text,
                        textBox_firstEmail + "@" + comboBox_Email.Text, textBox_Address.Text, worker.Role);
                    workerModel.update(w);
                }
                else if (owner != null)
                {
                    var o = new Owner(textBox_ID.Text, textBox_Firstname.Text + " " + textBox_Lastname.Text,
                        textBox_DateOfBirth.Text, comboBox_Gender.Text, textBox_Password.Text, textBox_Phone.Text,
                        textBox_firstEmail + "@" + comboBox_Email.Text, textBox_Address.Text);
                    ownerModel.update(o);
                }
                Hide();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
