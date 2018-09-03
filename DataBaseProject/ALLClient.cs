using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient; 


namespace DataBaseProject
{
    public partial class ALLClient : Form
    {
        public Int64 CustomerId;
        public string strSQL;
        public string strSQL1;


        public ALLClient()
        {
            InitializeComponent();
            this.Size = new Size(866, 257);
        }
        private void ALLClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.tblActualMembership' table. You can move, or remove it, as needed.
            this.tblActualMembershipTableAdapter.Fill(this.dataSet2.tblActualMembership);
            // TODO: This line of code loads data into the 'dataSet1.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.dataSet1.tblCustomer);
            
            strSQL = "select * from tblCustomer";
           command sqlCmd = new command(strSQL);
          dgClients.DataSource = sqlCmd.datatable();       
        }
       
       private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EazyShape per = new EazyShape();
            per.Show();
        }
        private void dgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgClients.Columns[e.ColumnIndex].Name == "NumOfMem")
            {
              DataGridViewRow row = dgClients.Rows[e.RowIndex];
            CustomerId = Convert.ToInt64(row.Cells[0].Value.ToString());
            strSQL1 = "select* from tblActualMembership where tblActualMembership.memberID=" + Convert.ToInt64(CustomerId) ;
            command sqlCmd1 = new command(strSQL1);
            dgMem.DataSource = sqlCmd1.datatable(); 
                  
            }
        }
      

        private void tbsitesC_Click(object sender, EventArgs e)
        {
        
        }

        private void dgMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        
    }
}

