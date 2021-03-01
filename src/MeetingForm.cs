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
    public partial class MeetingForm : Form
    {
		private DogModel dogModel;
		private WorkerModel workerModel;
		private OwnerModel ownerModel;
		private MeetingModel meetingModel;	private List<Meeting> meetings = new List<Meeting>();
		private string meetingIndex = null;

		private string role;
		private string personID;
		private bool UpdateDataGridViewListMeeting()
		{
			dataGridView_ListMeeting.Rows.Clear();
			Meeting_Adopter.Items.Clear();
			Meeting_Adopter.Items.Add("Yes");
			Meeting_Adopter.Items.Add("No");
			Meeting_Adopter.Items.Add("Yet");
			char[] arr = { '-', ':', ' ' };
			try
			{
				foreach (var meeting in meetings)
				{
					var date = meeting.DateOfMeeting.Split(arr);
					var time = meeting.TimeOfMeeting.Split(arr);

					int year = int.Parse(date[0]);
					int month = int.Parse(date[1]);
					int day = int.Parse(date[2]);
					int hour = int.Parse(time[0]);
					int min = int.Parse(time[1]);
					if(time[2] == "PM")
                    {
						if(12 != hour)
						hour += 12;
                    }
                    else
                    {
						if (12 == hour)
							hour = 00;

					}
					DateTime dateTime = new DateTime(year, month, day + 1);
					if (meeting.Adopter == "Yet" |DateTime.Now <= dateTime)
					{
						dataGridView_ListMeeting.Rows.Add(meeting.ID, meeting.DogID, dogModel.get(meeting.DogID).Name, meeting.WorkerID,
							workerModel.get(meeting.WorkerID).Name, meeting.OwnerID, ownerModel.get(meeting.OwnerID).Name,
							meeting.DateOfMeeting, meeting.TimeOfMeeting, meeting.Adopter);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		private void loading()
        {
			dogModel = new DogModel();
			meetingModel = new MeetingModel();
			ownerModel = new OwnerModel();
			workerModel = new WorkerModel();
			meetings.Clear();
			var meetingD = meetingModel.getList();
			int counter = 0;
			if (role == "Worker")
			{

				bunifuImageButton_Add.Visible = bunifuImageButton_Update.Visible = !false;
				label_Add.Visible = label_Update.Visible = !false;
				counter++;
				if (workerModel.get(personID).Role == "Emplyee")
				{
					Meeting_Worker_Name.Visible = false;
					Meeting_Owner_Name.Visible = true;
				}
				else
				{
					Meeting_Worker_Name.Visible = true;
					Meeting_Owner_Name.Visible = true;
				}
				foreach (var meeting in meetingD.Values)
				{
					if (meeting.WorkerID == personID && meeting.Adopter == "Yet")
					{
						counter++;
						meetings.Add(meeting);
					}
				}

			}
			else if (role == "Owner")
			{
				Meeting_Adopter.Visible = false;
				button_Save.Visible = false;
				bunifuImageButton_Add.Visible = bunifuImageButton_Update.Visible = false;
				label_Add.Visible = label_Update.Visible = false;
				counter = 0;
				Meeting_Worker_Name.Visible = true;
				Meeting_Owner_Name.Visible = false;
				foreach (var meeting in meetingD.Values)
				{
					if (meeting.OwnerID == personID && meeting.Adopter == "Yet")
					{
						counter++;
						meetings.Add(meeting);
					}
				}
			}
			if (counter > 0)
			{
				UpdateDataGridViewListMeeting();
				bunifuImageButton_Delete.Enabled = true;
			}
			else
			{
				dataGridView_ListMeeting.Rows.Clear();
				bunifuImageButton_Delete.Enabled = false;

			}
		}
		public MeetingForm(string human = "", string id = "")
        {
            InitializeComponent();
			personID = id; role = human;
			loading();
		}

        private void bunifuImageButton_Delete_Click(object sender, EventArgs e)
        {
			if ((meetingIndex = dataGridView_ListMeeting.Rows[dataGridView_ListMeeting.CurrentCell.RowIndex].Cells[0].Value.ToString()) != "")
				meetingModel.remove(meetingModel.get(meetingIndex));
			else
			{
				meetingIndex = null;
			}
			loading();
		}

        private void bunifuImageButton_Add_Click(object sender, EventArgs e)
        {
			Form form = new AUMeetingForm("Add",personID);
			form.ShowDialog();
        }

        private void MeetingForm_Load(object sender, EventArgs e)
        {
			//loading();
		}

        private void button_Save_Click(object sender, EventArgs e)
        {
			string id;
			for (int i = 0; i < dataGridView_ListMeeting.Rows.Count; i++)
			{
				if ((id = dataGridView_ListMeeting.Rows[i].Cells[0].Value.ToString()) != "")
				{

					if (dataGridView_ListMeeting.Rows[i].Cells[9].Value.ToString() != "Yet")
					{
						var meeting = meetingModel.get(id);
						meeting.Adopter = dataGridView_ListMeeting.Rows[i].Cells[9].Value.ToString();
						meetingModel.update(meeting);
						if (dataGridView_ListMeeting.Rows[i].Cells[9].Value.ToString() == "Yes")
						{
							//connection between owner to dog
							var owner = ownerModel.get(dataGridView_ListMeeting.Rows[i].Cells[5].Value.ToString());
							owner.AddDogID(dataGridView_ListMeeting.Rows[i].Cells[1].Value.ToString());
							var dog = dogModel.get(dataGridView_ListMeeting.Rows[i].Cells[1].Value.ToString());
							dog.OwnerID = owner.ID;
							ownerModel.update(owner);
							dogModel.update(dog);

							//delete all another meetings for this dog
							var meet = meetingModel.getList();
							foreach (var m in meet.Values)
							{
								if (m.ID != id && m.DogID == dog.ID)
								{
									meetingModel.remove(m);
									break;
								}
							}

						}

					}
				}
			}
			loading();
		}

		private void bunifuImageButton_Update_Click(object sender, EventArgs e)
		{
			if ((meetingIndex = dataGridView_ListMeeting.Rows[dataGridView_ListMeeting.CurrentCell.RowIndex].Cells[0].Value.ToString()) != "")
			{
				Form form = new AUMeetingForm("Update", personID,meetingIndex);
				form.ShowDialog();
			} 
		}

        private void button_Refresh_Click(object sender, EventArgs e)
        {
			loading();
        }
    }
}
