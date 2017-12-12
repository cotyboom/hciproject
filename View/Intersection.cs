using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alice_in_SpringLand.View
{
    public partial class Intersection : Form
    {
        public Intersection()
        {
            InitializeComponent();
        }

        private void panelFlowers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFruits_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.buton_fructe);
            player.Play();
        }

        private void panelFlowers_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.buton_flori);
            player.Play();
        }

        private void panelTraditions_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.buton_traditii);
            player.Play();
        }

        private void panelActivities_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.buton_activitati);
            player.Play();
        }
    }
}
