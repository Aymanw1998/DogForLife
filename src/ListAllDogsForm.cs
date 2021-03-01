using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogForLife
{
    public partial class ListAllDogsForm : Form
    {
        private DogModel dogModel = new DogModel();
		private OwnerModel ownerModel = new OwnerModel();
		private Owner owner = null;
		private List<Dog> dogs = new List<Dog>();

		private bool UpdateDataGridViewListDog()
		{
			try
			{
				foreach (var dog in dogs)
				{
					dataGridView_ListDog.Rows.Add(dog.ID, dog.Name, dog.DateOfBirth, dog.Height, dog.Weight,
						dog.Color, dog.Breed, dog.Gender, dog.Character);
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public ListAllDogsForm(string id = null)
        {
            InitializeComponent();
			if (id != null)
				owner = ownerModel.get(id);
			var dogsD = dogModel.getList();
			int counter = 0;
			foreach (var dog in dogsD.Values)
			{
				if (dog.OwnerID == "")
				{
					counter++;
					dogs.Add(dog);
				}				
			}
			if (counter > 0)
			{
				UpdateDataGridViewListDog();
				label_No_Dogs_Available.Visible = false;
				button_Ok.Visible = true;
				button_Questionnaire.Visible = true;
			}
			else
			{

				label_No_Dogs_Available.Visible = true;
				button_Ok.Visible = false;
				button_Questionnaire.Visible = false;
			}
		}

        private void button_Questionnaire_Click(object sender, EventArgs e)
        {
			Form form = new QuestionForm(owner.ID);
			form.ShowDialog();
			Hide();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
			string dogIndex = null;
			if ((dogIndex = dataGridView_ListDog.Rows[dataGridView_ListDog.CurrentCell.RowIndex].Cells[0].Value.ToString()) != "")
			{
				//owner.AddDogID(dogIndex);
				//dogModel.get(dogIndex).OwnerID = owner.ID;
				var meetings = new MeetingModel().getList();
				//Meeting//
				//אז יציג הודעה שיש לך מפגש לכל זה
				foreach (var m in meetings.Values) {
					//אם יש פגישה לאותו כלב ועם אותו לקוח אז טעות
					if (m.DogID == dogIndex && m.OwnerID == owner.ID && m.Adopter == "Yet")
                    {
						MessageBox.Show("You have meeting for this dog");
						return;
                    }
                }
				Form form = new AUMeetingForm("Add",owner.ID, dogIndex);
				form.Show();
				Close();
			}
			else
			{
				dogIndex = null;
			}
		}

        private void button_Cancel_Click(object sender, EventArgs e)
        {
			Hide();
        }
    }
}
