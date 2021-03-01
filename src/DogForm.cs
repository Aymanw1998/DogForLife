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
    public partial class DogForm : Form
    {

		private bool UpdateDataGridViewListDog()
		{
            dataGridView_ListDog.Rows.Clear();

            try
			{
				foreach (var dog in dogs)
				{
                    dataGridView_ListDog.Rows.Add(dog.ID,dog.Name,dog.DateOfBirth, dog.Height, dog.Weight,
						dog.Color, dog.Breed,dog.Gender, dog.Character);
				}
				return true;
			}
			catch (Exception) {
				return false;
			}
		}

        private void loading()
        {
            ownerModel = new OwnerModel();
            dogModel = new DogModel();
            dogs = new List<Dog>();
            var dogsD = dogModel.getList();
            int counter = 0;
            if (role == "Worker")
            {
                counter = 0;
                label_Adoption.Visible = false;
                button_Adoption.Visible = false;
                label_Update.Visible = true;
                button_Update.Visible = true;
                label_Add.Visible = true;
                button_Add.Visible = true;
                foreach (var dog in dogsD.Values)
                {
                    if (dog.OwnerID == null || dog.OwnerID == "")
                    {
                        counter++;
                        dogs.Add(dog);
                    }
                }
            }
            else if (role == "Owner")
            {
                
                counter = 0;
                label_Adoption.Visible = true;
                button_Adoption.Visible = true;
                label_Update.Visible = false;
                button_Update.Visible = false;
                label_Add.Visible = false;
                button_Add.Visible = false;
                foreach (var dog in dogsD.Values)
                {
                    if (dog.OwnerID == ownerID)
                    {
                        counter++;
                        dogs.Add(dog);
                    }
                }
            }
            if (counter > 0)
            {
                UpdateDataGridViewListDog();
                button_Delete.Enabled = true;
            }
            else
            {
                button_Delete.Enabled = false;

            }
        }
		private DogModel dogModel;
        private OwnerModel ownerModel;
        private List<Dog> dogs = new List<Dog>();
        private string dogIndex = null;

        private string ownerID = null;

        private string role;
        public DogForm(string human = "", string id = "")
        {
            InitializeComponent();
            role = human; ownerID = id;
            loading();   
        }

		private void button_Add_Click(object sender, EventArgs e)
        {
            AUDogForm aUDogForm = new AUDogForm("Add");
            aUDogForm.ShowDialog();

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if ((dogIndex = dataGridView_ListDog.Rows[dataGridView_ListDog.CurrentCell.RowIndex].Cells[0].Value.ToString()) != "")
            {
                AUDogForm aUDogForm = new AUDogForm("Update", dogIndex);
                aUDogForm.ShowDialog();
            }
            else
            {
                dogIndex = null;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if ((dogIndex = dataGridView_ListDog.Rows[dataGridView_ListDog.CurrentCell.RowIndex].Cells[0].Value.ToString()) != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want delete this dog with ID : " + dogIndex, "Delete",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) 
                { 
                    if(role == "Worker")
                    dogModel.remove(dogModel.get(dogIndex));
                    else
                    {
                        var d = dogModel.get(dogIndex);
                        d.OwnerID = "";
                        dogModel.update(d);
                        var owner = ownerModel.get(ownerID);
                        owner.deleteDogID(dogIndex);
                        ownerModel.update(owner);
                    }
                }
            } 
            else
            {
                dogIndex = null;
            }
            loading();
        }

        private void button_Adoption_Click(object sender, EventArgs e)
        {
            Form form = new ListAllDogsForm(ownerID);
            form.Show();
        }

        private void DogForm_Load(object sender, EventArgs e)
        {
           loading();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            loading();
        }
    }
}
