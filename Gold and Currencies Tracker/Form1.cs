using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Gold_and_Currencies_Tracker
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        BL.Comparer _comparer= new BL.Comparer();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void panel_metal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> goldData = _comparer.GetRate("XAU", "USD");
            //List<string> silverData = _comparer.GetRate("XAG", "USD");
            List<string> goldEgypt = _comparer.GetRate("XAU", "EGP");
            List<string> saudiR = _comparer.GetRate("SAR", "EGP");
            List<string> dollarData = _comparer.GetRate("USD", "EGP");
            List<string> euroData = _comparer.GetRate("EUR", "EGP");
            //List<string> poundData = _comparer.GetRate("GBP", "EGP");
            //List<string> emirateData = _comparer.GetRate("AED", "EGP");
            //List<string> kuwaitiData = _comparer.GetRate("KWD", "EGP");
            //txtbx_goldOunce.Text = goldData[0].ToString();
            txtbx_goldOunce.Text = (decimal.Round(Convert.ToDecimal(goldData[0]), 3, MidpointRounding.AwayFromZero)).ToString();
            //txtbx_GoldGram.Text = (Convert.ToDecimal(goldData[0]) / (decimal)31.1034768).ToString();
            txtbx_GoldGram.Text = (decimal.Round(Convert.ToDecimal(goldData[0]) / (decimal)31.1034768, 3, MidpointRounding.AwayFromZero)).ToString();
            //txtbx_GoldGramEgypt.Text = ((Convert.ToDecimal(goldData[0]) / (decimal)31.10) * Convert.ToDecimal(dollarData[0])).ToString();
            txtbx_GoldGramEgypt.Text = (decimal.Round(Convert.ToDecimal(goldEgypt[0]) / (decimal)31.1034768, 3, MidpointRounding.AwayFromZero)).ToString();
            txtbx_SaudiAsk.Text = (decimal.Round(Convert.ToDecimal(saudiR[4]), 3, MidpointRounding.AwayFromZero)).ToString();
            txtbx_SaudiBid.Text = (decimal.Round(Convert.ToDecimal(saudiR[3]), 3, MidpointRounding.AwayFromZero)).ToString();
            txtbx_USDask.Text = (decimal.Round(Convert.ToDecimal(dollarData[4]), 3, MidpointRounding.AwayFromZero)).ToString();
            txtbx_USDbid.Text = (decimal.Round(Convert.ToDecimal(dollarData[3]), 3, MidpointRounding.AwayFromZero)).ToString();
            txtbx_EuroAsk.Text = (decimal.Round(Convert.ToDecimal(euroData[4]), 3, MidpointRounding.AwayFromZero)).ToString();
            txtbx_EuroBid.Text = (decimal.Round(Convert.ToDecimal(euroData[3]), 3, MidpointRounding.AwayFromZero)).ToString();
            lbl_lastUpdateData.Text = euroData[1].ToString();
        }
    }
}
