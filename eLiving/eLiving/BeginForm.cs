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
    public partial class BeginForm : Form
    {
        Thread th;
        int i = 100;
        bool k = true;

        public BeginForm()
        {
            InitializeComponent();
        }

        private void timerBackground_Tick(object sender, EventArgs e)
        {
            if (k == true)
            {
                if (i == 254)
                { k = false; }
                i++;
                this.BackColor = Color.FromArgb(0, 150, i);
            }
            if (k == false)
            {
                if (i == 100)
                { k = true; }
                i--;
                this.BackColor = Color.FromArgb(0, 150, i);
            }

        }

        private void btnSelectMood_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenSelectAMood);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        

        private void BtnAddANewMood_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenAddAMood);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenHistory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenSelectAMood()
        {
            Application.Run(new SelectAMood());
        }

        private void OpenAddAMood()
        {
            Application.Run(new AddAMood());
        }

        private void OpenHistory()
        {
            Application.Run(new History());
        }
    }
}
