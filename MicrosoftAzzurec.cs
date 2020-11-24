using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oktobar2015
{
    public partial class MicrosoftAzzurec : Form
    {

        private float tarifa_protok=0.17f;
        private float tarifa_brSajtova = 14.5f;
        private float tarifa_brVM = 111.6f;

        public MicrosoftAzzurec()
        {
            InitializeComponent();
            enableTrackBars();
            trackBarProtok.SetRange(0,2000);
            trackBarBrojVM.SetRange(0,20);
            trackBarBrojSajtova.SetRange(0,20);
            racunaj();
        }

        private void trackBarProtok_Scroll(object sender, EventArgs e)
        {
            textBoxProtok.Text = trackBarProtok.Value.ToString()+" GB";
            racunaj();
        }

        private void groupBoxTip_Enter(object sender, EventArgs e)
        {
            enableTrackBars();
            racunaj();
        }

        private void enableTrackBars()
        {
            if (radioButtonBesplatan.Checked)
            {
                trackBarProtok.Enabled = true;
                trackBarBrojSajtova.Enabled = false;
                trackBarBrojSajtova.Value = 0;
                textBoxBrojSajtova.Clear();
                trackBarBrojVM.Enabled = false;
                trackBarBrojVM.Value = 0;
                textBoxBrojVM.Clear();
            }
            if (radioButtonDijeljen.Checked)
            {
                trackBarProtok.Enabled = true;
                trackBarBrojSajtova.Enabled = true;
                trackBarBrojVM.Enabled = false;
                trackBarBrojVM.Value = 0;
                textBoxBrojVM.Clear();
            }
            if (radioButtonStandardan.Checked)
            {
                trackBarBrojVM.Enabled = true;
                trackBarProtok.Enabled = true;
                trackBarBrojSajtova.Enabled = false;
                trackBarBrojSajtova.Value = 0;
                textBoxBrojSajtova.Clear();
            }
        }

        private void trackBarBrojSajtova_Scroll(object sender, EventArgs e)
        {
            textBoxBrojSajtova.Text = trackBarBrojSajtova.Value.ToString()+" sajtova";
            racunaj();
        }

        private void trackBarBrojVM_Scroll(object sender, EventArgs e)
        {
            textBoxBrojVM.Text = trackBarBrojVM.Value.ToString()+" VM";
            racunaj();
        }

        private void racunaj()
        {
            try
            {
                Izracunaj();
            }
            catch (Exception)
            {

        
            }
            finally
            {
                labelOkvirnaCijena.Text = "Okvirna cijena:             " + (trackBarProtok.Value * tarifa_protok + trackBarBrojVM.Value * tarifa_brVM + trackBarBrojSajtova.Value * tarifa_brSajtova).ToString("0.00") + "KM";
            }
            
        }

        int Izracunaj() { int z = 0, x = 1 / z; return x; }


    }
}
