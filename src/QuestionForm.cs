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
    public partial class QuestionForm : Form
    {
        private string personID = null;
        public QuestionForm(string id = null)
        {
            InitializeComponent();
            personID = id;

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            int[] arrDate = new int[2];
            arrDate[0] = arrDate[1] = -1;
            int[] arrHeight = new int[2];
            arrHeight[0] = arrHeight[1] = -1;
            string gender = null;
            if (comboBox_Date.Text == "0 - 2")
            {
                arrDate[0] = 0; arrDate[1] = 2;
            }
            else if (comboBox_Date.Text == "2 - 6")
            {
                arrDate[0] = 2; arrDate[1] = 6;
            }
            else if (comboBox_Date.Text == "6 +")
            {
                arrDate[0] = 6; arrDate[1] = 6;
            }

            if (comboBox_Height.Text == "0 - 30")
            {
                arrHeight[0] = 0; arrHeight[1] = 30;
            }
            else if (comboBox_Height.Text == "30 +")
            {
                arrHeight[0] = 30; arrHeight[1] = 30;
            }

            if (comboBox_Gender.Text == "Male")
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

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


            if (arrDate[0] == -1 || arrHeight[0] == -1 || comboBox_Gender.Text == "" || breed == "" || character == "")
                MessageBox.Show("Fill in the missing cells");
            else
            {
                Form f = new ChooseDogForm(personID, arrDate, arrHeight, gender, breed, character);
                f.Show();
            }
        }
    }
}
