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
    public partial class ChooseDogForm : Form
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
		public ChooseDogForm(string id, int[] arrD, int[] arrH, string gender, string breed, string character)
        {
            InitializeComponent();
			if (id != null)
				owner = ownerModel.get(id);
			var dogsD = dogModel.getList();
			int counter = 0;
			foreach (var dog in dogsD.Values)
			{
				if (dog.OwnerID == null || dog.OwnerID == "")
				{
					var date = dog.DateOfBirth.Split('-');
					int age = DateTime.Now.Year - int.Parse(date[0]);
					int height = int.Parse(dog.Height);
					if ((arrD[0] != arrD[1] && arrD[0] < age && age < arrD[1]) || (arrD[0] == arrD[1] && arrD[0] < age)
						&& (arrH[0] != arrH[1] && arrH[0] < height && height < arrH[1]) || (arrH[0] == arrH[1] && arrH[0] < height)) 
					{
						if (dog.Gender == gender && dog.Breed == breed && dog.Character == character)
						{
							counter++;
							dogs.Add(dog);
						}
					}
				}
			}
			if (counter > 0)
			{
				UpdateDataGridViewListDog();
				label_No_Dogs_Available.Visible = false;
				button_Ok.Enabled = true;
			}
			else
			{

				label_No_Dogs_Available.Visible = false;
				button_Ok.Enabled = false;
			}
		}

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
			string dogIndex = null;
			if ((dogIndex = dataGridView_ListDog.Rows[dataGridView_ListDog.CurrentCell.RowIndex].Cells[0].Value.ToString()) != "")
			{
				//owner.AddDogID(dogIndex);
				dogModel.get(dogIndex).OwnerID = owner.ID;

				//Meeting//
				var meetings = new MeetingModel().getList();
				//אז יציג הודעה שיש לך מפגש לכל זה
				foreach (var m in meetings.Values)
				{
					//אם יש פגישה לאותו כלב ועם אותו לקוח אז טעות
					if (m.DogID == dogIndex && m.OwnerID == owner.ID && m.Adopter == "Yet")
					{
						MessageBox.Show("You have meeting for this dog");
						return;
					}
				}
				Form form = new AUMeetingForm("Add", owner.ID, dogIndex);
				Close();
				form.Show();
				
			}
			else
			{
				dogIndex = null;
			}
		}
    }
}
