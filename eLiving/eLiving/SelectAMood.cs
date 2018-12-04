using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace eLiving
{
    public partial class SelectAMood : Form
    {
        Data moodData = new Data();
        Thread th;
        public SelectAMood()
        {
            InitializeComponent();
            moodData.GetMoods();
            FillMoodList();
            SetColorPreview();
            
        }
        private void FillMoodList()
        {
            //Get the mood presets that have been made and add them to the list.
        }

        //Sets the color preview box to the color values of the labels.
        private void SetColorPreview()
        {
            RGBPreview.BackColor = Color.FromArgb(Convert.ToInt32(lblRedValue.Text), Convert.ToInt32(lblGreenValue.Text), Convert.ToInt32(lblBlueValue.Text));
        }

        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            lblRedValue.Text = Convert.ToString(trackBarRed.Value);
            SetColorPreview();
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            lblGreenValue.Text = Convert.ToString(trackBarGreen.Value);
            SetColorPreview();
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            lblBlueValue.Text = Convert.ToString(trackBarBlue.Value);
            SetColorPreview();
        }

        private void listBoxMoods_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Doesn't work yet --> class mood/database needs to be fixed first (moodID in database)


            /*
            dropDownMenuPlaylists.SelectedValue =
             DropDownMenuScents.SelectedValue = 
             trackBarBlue.Value =
             trackBarRed.Value =
             trackBarGreen.Value = 
            */
            //If the selected mood changes the playlist, red, green, blue, volume, and scent data should be loaded.
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {       
            this.Close();
            th = new Thread(OpenBeginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenRoomOptions);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //Send the data to the arduino and get to the live option menu.
        }

        private void OpenBeginForm()
        {
            Application.Run(new BeginForm());
        }

        private void OpenRoomOptions()
        {
            Application.Run(new RoomOptions());
        }

        private void dropDownMenuPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Occurs when the users selects a different playlist
        }

        private void DropDownMenuScents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Occurs when the users select a different scent
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            //Occurs when the users changes volume.
        }
    }
}
