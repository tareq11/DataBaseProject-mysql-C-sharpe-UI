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
    public partial class FQ12 : Form
    {
        int num;
        public FQ12()
        {
            InitializeComponent();
           this.Size = new Size(958, 217);
        }
        private void FQAB_Load(object sender, EventArgs e)
        {
            groupBox1.Show();
            btnQ1.Show();
            btnQ2.Show();
            groupBox2.Hide();
            btnQ1A.Hide();
            btnQ1B.Hide();
           

        }
        private void btnQ1_Click(object sender, EventArgs e)
        {
            num = 1;
            btnQ1A.Show();
            btnQ1B.Show(); this.Size = new Size(958, 516);
            groupBox1.Hide();
            btnQ1.Hide();
            btnQ2.Hide();
            groupBox2.Show();
            btnQ1A.Show();
            btnQ1B.Show();
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            num = 2;
            this.Size = new Size(958, 516);
            groupBox1.Hide();
            btnQ1.Hide();
            btnQ2.Hide();
            groupBox2.Show();
            btnQ1A.Show();
            btnQ1B.Show();
        }

      

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Size = new Size(958, 217);
            groupBox1.Show();
            btnQ1.Show();
            btnQ2.Show();
            groupBox2.Hide();
            btnQ1A.Hide();
            btnQ1B.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnQ1A_Click(object sender, EventArgs e)
        {

        }

        private void dgQA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

       

       

       
    }
}
