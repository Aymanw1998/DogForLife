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

    public partial class AUMeetingForm : Form
    {
        private WorkerModel workerModel = new WorkerModel();
        private MeetingModel meetingModel = new MeetingModel();
        private OwnerModel ownerModel = new OwnerModel();
        private DogModel dogModel = new DogModel();
        private string workerId = null;
        private string function = null;
        public AUMeetingForm(string func = null, string personID = null, string meetingID = null)
        {
            InitializeComponent();
            function = func;
            label_Title.Text = func + " Meeting";
            workerId = personID;
            var worker = workerModel.get(personID);
            var owner = ownerModel.get(personID);
            var meeting = meetingModel.get(meetingID);
            
            var dogs = dogModel.getList();
            var owners = ownerModel.getList();
            foreach(var w in workerModel.getList().Values)
            {
                
                comboBox_Worker.Items.Add(w.ID + " " + w.Name);
            }
            foreach (var dog in dogs.Values)
            {
                comboBox_DogChip.Items.Add(dog.ID + " " + dog.Name);
            }
            foreach (var o in owners.Values)
            {
                comboBox_OwnerID.Items.Add(o.ID + " " + o.Name);
            }
            if (worker != null)
            {
                comboBox_Worker.Text = worker.ID + " " + worker.Name;
                comboBox_Worker.Enabled = false;
                if (function == "Update")
                {
                    bunifuTextbox_ID._TextBox.Text = meeting.ID;
                    bunifuTextbox_ID.Enabled = false;
                    comboBox_DogChip.Text = meeting.DogID + " " + dogs[meeting.DogID].Name;
                    comboBox_DogChip.Enabled = false;
                    comboBox_OwnerID.Text = meeting.OwnerID + " " + owners[meeting.OwnerID].Name;
                    comboBox_OwnerID.Enabled = false;
                    dateTimePicker_Date.Value.ToString(meeting.DateOfMeeting);
                    dateTimePicker_Time.Text = meeting.TimeOfMeeting;
                }
                else
                {
                    int counter = 1;
                    bool bl = true;
                    while (bl)
                    {
                        if (dogModel.get(counter.ToString()) == null)
                            bl = false;
                        else counter++;
                    }
                    bunifuTextbox_ID._TextBox.Text = counter.ToString();
                    bunifuTextbox_ID._TextBox.Enabled = false;
                }
            }
            else
            {
                int counter = 1;
                bool bl = true;
                while (bl)
                {
                    if (meetingModel.get(counter.ToString()) == null)
                        bl = false;
                    else counter++;
                }
                bunifuTextbox_ID._TextBox.Text = counter.ToString();
                bunifuTextbox_ID._TextBox.Enabled = false;
                var dogID = meetingID;
                comboBox_DogChip.Text = dogID + " " + dogs[dogID].Name;
                comboBox_OwnerID.Text = owner.ID + " " + owner.Name;
                comboBox_DogChip.Enabled = false;
                comboBox_OwnerID.Enabled = false;
            }
        }

        private void bunifuFlatButton_Ok_Click(object sender, EventArgs e)
        {

            var dogStr = comboBox_DogChip.Text.Split(' ');
            var owner = comboBox_OwnerID.Text.Split(' ');
            var w = comboBox_Worker.Text.Split(' ');
            bool ok = false;
            var error = meetingModel.get(bunifuTextbox_ID._TextBox.Text);
            if (error != null) {
                MessageBox.Show("There is a meeting with this ID");
                bunifuTextbox_ID.Focus();
                return; 
            }
            if (bunifuTextbox_ID._TextBox.Text != "" && comboBox_DogChip.Text != "" && comboBox_OwnerID.Text != "")
            {
                if ((DateTime.Now.Year < dateTimePicker_Date.Value.Year) ||
                    (DateTime.Now.Year == dateTimePicker_Date.Value.Year && DateTime.Now.Month < dateTimePicker_Date.Value.Month) ||
                    (DateTime.Now.Year == dateTimePicker_Date.Value.Year && DateTime.Now.Month == dateTimePicker_Date.Value.Month && DateTime.Now.Day < dateTimePicker_Date.Value.Day))
                { ok = true; }
                if (ok)
                {
                    Meeting meeting = new Meeting(bunifuTextbox_ID._TextBox.Text, dogStr[0], owner[0], w[0], dateTimePicker_Date.Text, dateTimePicker_Time.Text);
                    var dog = dogModel.get(dogStr[0]);
                    if (function == "Update")
                    {
                        meetingModel.update(meeting);
                        dogModel.update(dog);
                    }
                    else if (function == "Add")
                    {
                        meetingModel.add(meeting);
                        dogModel.update(dog);
                    }
                    
                    Hide();
                }
                else
                {
                    MessageBox.Show("Give a reasonable date and time");
                }
            }
            else
            {
                MessageBox.Show("Fill in the missing cells");
            }

        }

        private void bunifuFlatButton_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            
        }
    }
}
