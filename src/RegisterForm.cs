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
    public partial class RegisterForm : Form
    {
		private OwnerModel ownerModel = new OwnerModel();
		private WorkerModel workerModel = new WorkerModel();
		private string person = null;
		public RegisterForm(string p = null)
        {
            InitializeComponent();
			textBox_DateOfBirth.MaxDate = DateTime.Now.AddDays(-365 * 10);
			person = p;
		}

		private void bunifuThinButton_Create_Click(object sender, EventArgs e)
		{
			label_Error_ID.Visible = false; label_Error_Password_1.Visible = false;
			label_Error_Password_2.Visible = false; label_Error_Firstname.Visible = false;
			label_Error_Lastname.Visible = false; label_Error_Date.Visible = false;
			label_Error_Email.Visible = false; label_Error_Phone.Visible = false;
			label_Error_Address.Visible = false; label_Error_Gender.Visible = false;

			bool idB = false, passB = false, firstnameB = false, lastnameB = false,
				dateB = false, emailB = false, phoneB = false, addressB = false, genderB = false;

			string id = "", pass = "", name = "", date = "", email = "", phone = "", address = "",
				gender = "";
			var owner = ownerModel.get(textBox_ID.Text);
			var worker = workerModel.get(textBox_ID.Text);
			//ID
			if (textBox_ID.Text == "" || textBox_ID.TextLength != 9 || (person != "Worker" && owner != null) || (person == "Worker" && worker != null))
			{
				//label_Error_ID.Visible = true;
				//label_Error_ID.Location = new Point(label_Error_ID.Location.X - 100, label_Error_ID.Location.Y);
				if (textBox_ID.Text == "")
					label_Error_ID.Text = "Enter your ID";
				else if (textBox_ID.TextLength != 9)
					label_Error_ID.Text = "Enter full ID (9 number)";
				else if (owner != null)
					label_Error_ID.Text = "The user with ID number exits";
				else if(worker != null)
					label_Error_ID.Text = "The user with ID number exits";
			}
			else
			{
				idB = true;
				id = textBox_ID.Text;
			}

			//password
			if (textBox_Password_1.Text == "" || textBox_Password_2.Text == "")
			{

				if (textBox_Password_1.Text == "")
				{
					label_Error_Password_1.Text = "Enter your password";
					label_Error_Password_1.Visible = true;
				}
				if (textBox_Password_2.Text == "")
				{
					label_Error_Password_2.Text = "Enter your password";
					label_Error_Password_2.Visible = true;
				}
			}
			if (textBox_Password_1.Text != textBox_Password_2.Text)
			{
				label_Error_Password_2.Text = "the passwords do not match";
				label_Error_Password_2.Visible = true;
			}
			else
			{
				passB = true;
				pass = textBox_Password_1.Text;
			}
			//firstname
			if (textBox_Firstname.Text == "")
			{
				label_Error_Firstname.Visible = true;
				label_Error_Firstname.Text = "Enter your firstname";
			}
			else firstnameB = true;

			//lastname
			if (textBox_Lastname.Text == "")
			{
				label_Error_Lastname.Visible = true;
				label_Error_Lastname.Text = "Enter your lastname";
			}
			else lastnameB = true;

			if (firstnameB && lastnameB)
				name = textBox_Firstname.Text + " " + textBox_Lastname.Text;

			//phone
			if (textBox_Phone.TextLength > 0 && textBox_Phone.TextLength < 10)
			{
				label_Error_Phone.Visible = true;
				label_Error_Phone.Text = "Enter correct your phone";
			}
			else
			{
				phoneB = true;
				phone = textBox_Phone.Text;
			}

			//Email
			if (textBox_firstEmail.Text != "" && comboBox_Email.Text == "Choose mail")
			{
				label_Error_Email.Visible = true;
				label_Error_Email.Text = "Enter correct name email";
			}
			else if (textBox_firstEmail.Text == "" && comboBox_Email.Text != "Choose mail")
			{
				label_Error_Email.Visible = true;
				label_Error_Email.Text = "Choose mail";
			}
			else
			{
				emailB = true;
				email = textBox_firstEmail.Text + "@" + comboBox_Email.Text;
			}

			//Date of birth
			date = textBox_DateOfBirth.Value.ToShortDateString();

			//Address
			address = textBox_Address.Text;

			//Gender
			if (comboBox_Gender.Text == "Choose Gender")
			{
				label_Error_Gender.Visible = true;
				label_Error_Gender.Text = "Choose your gender";
			}
			else
			{
				genderB = true;
				gender = comboBox_Gender.Text;
			}


			if(idB && passB && firstnameB && lastnameB && genderB)
            {
				this.Hide();
				if (person != "Worker")
				{
					ownerModel.add(new Owner(id, name, date, gender, pass, phone, email, address));
					WorkerOwnerForm workerOwnerForm = new WorkerOwnerForm("Owner",id);
					workerOwnerForm.ShowDialog();
				}
                else
                {
					workerModel.add(new Worker(id, name, date, gender, pass, phone, email, address, "Employee"));
				}
            }
		}

        private void bunifuThinButton_Cancel_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
