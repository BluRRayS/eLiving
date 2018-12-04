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
    public partial class AddAMood : Form
    {
        public AddAMood()
        {
            InitializeComponent();
        }
        Thread th;
        
        private void dropDownMenuPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenSelectAMood);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenBeginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenBeginForm()
        {
            Application.Run(new BeginForm());
        }
        private void OpenSelectAMood()
        {
            Application.Run(new BeginForm());
        }
        private void SetColorPreview()
        {
            RGBPreview.BackColor = Color.FromArgb(Convert.ToInt32(lblRedValue.Text), Convert.ToInt32(lblGreenValue.Text), Convert.ToInt32(lblBlueValue.Text));
        }


        private void TrackBarRed_ValueChanged(object sender, EventArgs e)
        {
            lblRedValue.Text = Convert.ToString(TrackBarRed.Value);
            SetColorPreview();
        }

        private void TrackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            lblGreenValue.Text = Convert.ToString(TrackBarGreen.Value);
            SetColorPreview();
        }

        private void TrackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            lblBlueValue.Text = Convert.ToString(TrackBarBlue.Value);
            SetColorPreview();
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DropDownMenuScents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
