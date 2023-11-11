using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabariApplication
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        public static string Utilisateur;
        public static string TabSelect;
        private void FrmHome_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void FrmHome_Shown(object sender, EventArgs e)
        {

            switch (TabSelect)
            {
                case "0": tabControl2.SelectedIndex = 0; break;
                case "1": tabControl2.SelectedIndex = 1; break;
                case "2": tabControl2.SelectedIndex = 2; break;
            }
            LblUser.Text = Utilisateur;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (this.Opacity < 100)
            //{
            //    this.Opacity+=1;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClient frmClient = new FrmClient();
            PnlPlan.Controls.Clear();
            frmClient.TopLevel = false;
            frmClient.AutoScroll = true;
            PnlPlan.Controls.Add(frmClient);
            frmClient.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFournisseur frmFournisseur = new FrmFournisseur();
            PnlPlan.Controls.Clear();
            frmFournisseur.TopLevel = false;
            frmFournisseur.AutoScroll = true;
            PnlPlan.Controls.Add(frmFournisseur);
            frmFournisseur.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProduit frmProduit = new FrmProduit();
            PnlPlan.Controls.Clear();
            frmProduit.TopLevel = false;
            frmProduit.AutoScroll = true;
            PnlPlan.Controls.Add(frmProduit);
            frmProduit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCategorie frmCategorie = new FrmCategorie();
            PnlPlan.Controls.Clear();
            frmCategorie.TopLevel = false;
            frmCategorie.AutoScroll = true;
            PnlPlan.Controls.Add(frmCategorie);
            frmCategorie.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
