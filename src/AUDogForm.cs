using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DogForLife
{
    public partial class AUDogForm : Form
    {
        private DogModel dogModel = new DogModel();
        private string function = null;
        public AUDogForm(string func = null,string dogID = null)
        {
            InitializeComponent();
            function = func;
			label_Title.Text = func + "Dog";

			if (func == "Update")
            {// מכניס את  כל פרטי הכלב הרצוי לתאים
				var d = dogModel.get(dogID);
				
				bunifuTextbox_Chip._TextBox.Enabled = false;
				bunifuTextbox_Chip._TextBox.Text = d.ID;
				bunifuTextbox_Name._TextBox.Text = d.Name;
				dateTimePicker_Date.Text = d.DateOfBirth;
				bunifuTextbox_Height._TextBox.Text = d.Height;
				bunifuTextbox_Weight._TextBox.Text = d.Weight;
				bunifuTextbox_Color._TextBox.Text = d.Color;
				comboBox_Gender.Text = d.Gender;
				string breed = d.Breed;
				string character = d.Character;

				//Breed
				if (breed == radioButton_Bulldog.Text)
					radioButton_Bulldog.Checked = true;
				else if (breed == radioButton_Poodle.Text)
					radioButton_Poodle.Checked = true;
				else if (breed == radioButton_Beagle.Text)
					radioButton_Beagle.Checked = true;
				else if (breed == radioButton_Rottweiler.Text)
					radioButton_Rottweiler.Checked = true;
				else if (breed == radioButton_Dachshund.Text)
					radioButton_Dachshund.Checked = true;
				else if (breed == radioButton_Mix.Text)
					radioButton_Mix.Checked = true;

				//Character
				if (character == radioButton_Calm.Text)
					radioButton_Calm.Checked = true;
				else if (breed == radioButton_Furious.Text)
					radioButton_Furious.Checked = true;
				else if (breed == radioButton_Funny.Text)
					radioButton_Funny.Checked = true;
				else if (breed == radioButton_Friendly.Text)
					radioButton_Friendly.Checked = true;
			}
			//אחרת לא צריך להכניס כלום
        }

        private void bunifuFlatButton_Ok_Click(object sender, EventArgs e)
        {
			string chip = bunifuTextbox_Chip._TextBox.Text;
			string name = bunifuTextbox_Name._TextBox.Text;
			string dob = dateTimePicker_Date.Text;
			string height = bunifuTextbox_Height._TextBox.Text;
			string weight = bunifuTextbox_Weight._TextBox.Text;
			string color = bunifuTextbox_Color._TextBox.Text;
			string gender = comboBox_Gender.Text;

			//Breed
			string breed = "";
			if (radioButton_Bulldog.Checked)
				breed = "Bulldog";
			else if (radioButton_Poodle.Checked)
				breed = "Poodle";
			else if (radioButton_Beagle.Checked)
				breed = "Beagle";
			else if (radioButton_Rottweiler.Checked)
				breed = "Rottweiler";
			else if (radioButton_Dachshund.Checked)
				breed = "Dachshund";
			else if (radioButton_Mix.Checked)
				breed = "Mix";

			//Character
			string character = "";
			if (radioButton_Calm.Checked)
				character = "Calm";
			else if (radioButton_Furious.Checked)
				character = "Furious";
			else if (radioButton_Funny.Checked)
				character = "Funny";
			else if (radioButton_Friendly.Checked)
				character = "Friendly";

			Dog dog1 = dogModel.get(chip);

			if ((function == "Add") && dog1 != null)
			{
				MessageBox.Show("The dog with this id is exist");
				return;
			}

			try {
				int.Parse(height);
				int.Parse(weight);
			}
            catch (Exception)
            {
				MessageBox.Show("Height and weight fields must be a numbers");
				return;
			}

			if(chip == "" || name == "" || height == "" || weight == "" || color == "" && gender == "" || breed == "" || character == "")
            {
				MessageBox.Show("Please fill in all the fields");
				return;
			}
			Dog dog = new Dog(chip,name,dob,gender,"",height,weight,color,breed,character);
			if (function == "Add")
				dogModel.add(dog);
			else dogModel.update(dog);



			this.Hide();
		}

        private void bunifuFlatButton_Cancel_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
