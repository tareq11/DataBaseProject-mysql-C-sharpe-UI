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
    public partial class SearchClient : Form
    {
       DataTable table;
       command sqlCmd;
        public SearchClient()
        {
            InitializeComponent();
            this.Size = new Size(600, 213);
            btnSearchClient.Enabled = false;
            txtID.Text = "";
          
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
        }
        public void btnSearchClient_Click(object sender, EventArgs e)
        {
            
            back.Enabled = false;
            txtID.Enabled = false;
           table = new DataTable();
            btnWW.Enabled = false;
            btnWW.Enabled = false;
            btnSearchClient.Enabled = false;
            this.Size = new Size(600, 490);
            string strClient = "select count(SerialNum) as numOfMembership, CustomerId, FirstName+' '+ SurName AS fullname,Address,count(interestedClientNum) as NumOfRecommendedCustomer from tblCustomer inner join tblActualMembership on tblCustomer.CustomerId=tblActualMembership.memberID inner join tblPotentialCustomer on tblCustomer.CustomerId=tblPotentialCustomer.RecommendedByCustomerId where tblcustomer.CustomerId=" + Convert.ToInt64(txtID.Text) + "group by CustomerId,FirstName,SurName,Address,RecommendedByCustomerId;";
            sqlCmd = new command(strClient);
            dgsearch.DataSource = sqlCmd.datatable();
            
            if (dgsearch.Rows.Count <2) MessageBox.Show("Customer is not found");
            
          
          
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            txtID.Enabled = true;
            txtID.Text = "";
            btnWW.Enabled = true;
            back.Enabled = true;
            btnSearchClient.Enabled = false;
            this.Size = new Size(600, 213);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            long intID;
            bool boolIntID = long.TryParse(txtID.Text, out intID);   
            if (Convert.ToString(txtID.Text) != "" && boolIntID && txtID.TextLength==9) btnSearchClient.Enabled = true;

        }

        private void btnWW_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            MessageBox.Show("Please Insert Number from 9 Digits!!");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EazyShape per = new EazyShape();
            per.Show();
        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
