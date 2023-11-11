using System;
using System.Collections;
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
    public partial class FrmWaitingList : Form
    {
        public FrmWaitingList()
        {
            InitializeComponent();
        }

        Queue<ClsWeight> Entree = new Queue<ClsWeight>();
        List<ClsWeight> Chaine = new List<ClsWeight>();

        void fillData()
        {
            

            if (Entree.Count > 0)
            {
                Chaine.Add(Entree.Peek());
                Entree.Dequeue();
               
            }

        }

        void GetData()
        {
            fillData();
            List<ClsWeight> Chaine2 = Chaine; 
            dataGridView1.DataSource = Chaine2;
        }
        private void FrmWaitingList_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ClsWeight clsWeight = new ClsWeight
            {
                Chauffeur = "AMIN",
                Matricule = "1234",
                Client = "SAMI",
                Depot = "Baraka",
                Mlivraison = "Expedition",
                WeightOne = 98765,
                WeightSeconde = 12342342
            
            };

            Entree.Enqueue(clsWeight);

            ClsWeight c = new ClsWeight
            {
                Chauffeur = "SALIM",
                Matricule = "5678",
                Client = "SAID",
                Depot = "Baraka",
                Mlivraison = "Expedition",
                WeightOne = 23456,
                WeightSeconde = 12342342

            };

            Entree.Enqueue(c);

            ClsWeight d = new ClsWeight
            {
                Chauffeur = "Khalil",
                Matricule = "019092232",
                Client = "Ali",
                Depot = "Baraka",
                Mlivraison = "Expedition",
                WeightOne = 10983,
                WeightSeconde = 12342342

            };

            Entree.Enqueue(d);





           


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            

            //MessageBox.Show(Chaine.Count().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
    }

