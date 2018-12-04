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
    public partial class RoomOptions : Form
    {
        Thread th;
        public RoomOptions()
        {
            InitializeComponent();
        }


        private void timerTextScrolling_Tick(object sender, EventArgs e)
        {
            lblSongName.Left++;
            if (lblSongName.Left>=200)
            {
                lblSongName.Left = -104;
            }
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLight_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxScent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timerBackgroundColor_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(83, 89, 89);
        }

        private void btnStop_Click(object sender, EventArgs e)
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
    }
}
