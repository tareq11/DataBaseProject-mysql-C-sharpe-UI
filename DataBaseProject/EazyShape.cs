using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class EazyShape : Form
    {
        public EazyShape()
        {
            InitializeComponent();
        }

        private void ALLClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            ALLClient all = new ALLClient();
            all.ShowDialog();
        }

        private void SearchClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchClient search = new SearchClient();
            search.Show();
        }

        private void btnQ1Q2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQ1_Q2 f = new FQ1_Q2();
            f.Show();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PerfectGarden_Load(object sender, EventArgs e)
        {

        }

        private void gardenPerfect_Click(object sender, EventArgs e)
        {

        }
    }
}
