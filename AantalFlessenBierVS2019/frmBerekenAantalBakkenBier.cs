using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AantalFlessenBierVS2019
{
    public partial class frmAantalBakkenBier : Form
    {

        //module variabelen
        int iAantalFlessenBier = 0;
        int iAantalBakkenBier = 0;
        int iRestAantalFlessenBier = 0;
        int iAantalSixPacks = 0;

        public frmAantalBakkenBier()
        {
            InitializeComponent();
        }

        private void btnBerekenAantalBakkenBier_Click(object sender, EventArgs e)
        {
            try
            {
                iAantalFlessenBier = Convert.ToInt32(txtAantalFlessenBier.Text);

                //check of aantal flessen bier kleiner of gelijk is dan 0
                if (iAantalFlessenBier <= 0)
                {
                    MessageBox.Show("Gelieve een groter aantal in te geven.", "Aantal Flessen Bier",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    berekenAantalBakkenBier(iAantalFlessenBier);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gelieve een getal in te geven aub.", "Aantal Flessen Bier", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                btnBerekenAantalBakkenBier.Enabled = false;
            }
        }

        private void berekenAantalBakkenBier(int iAantalFlessenBierInput)
        {
            btnBerekenAantalBakkenBier.Enabled = false;
            
            if (iAantalFlessenBierInput > 0) 
            {
                //1 check aantal bakken bier
                if ((iAantalFlessenBierInput / 24) > 0)
                {
                    iAantalBakkenBier = iAantalFlessenBierInput / 24;
                    lblOutputAantalBakkenBier.Text = iAantalBakkenBier.ToString();
                }
                else 
                {
                    lblOutputAantalBakkenBier.Text = "0";
                }

                iRestAantalFlessenBier = (iAantalFlessenBierInput % 24);

                //2 check aantal 6 packs
                if ((iRestAantalFlessenBier / 6) > 0)
                {
                    iAantalSixPacks = iRestAantalFlessenBier / 6;
                    lblOutputAantalSixPacks.Text = iAantalSixPacks.ToString();
                }
                else 
                {
                    lblOutputAantalSixPacks.Text = "0";
                }

                iRestAantalFlessenBier = (iRestAantalFlessenBier % 6);
                lblOutputRestFlessenBier.Text = iRestAantalFlessenBier.ToString();
            }


        }

        private void txtAantalFlessenBier_TextChanged(object sender, EventArgs e)
        {
            lblOutputAantalBakkenBier.Text = "";
            lblOutputRestFlessenBier.Text = "";
            lblOutputAantalSixPacks.Text = "";
            btnBerekenAantalBakkenBier.Enabled = true;
        }

        private void frmAantalBakkenBier_Load(object sender, EventArgs e)
        {
            lblOutputAantalBakkenBier.Text = "";
            lblOutputRestFlessenBier.Text = "";
            lblOutputAantalSixPacks.Text = "";
        }



    }
}
