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
    public partial class FQ1_Q2 : Form
    {
         command sqlCmd;
        string strSQL;
        public FQ1_Q2()
        {
            InitializeComponent();
        }
        private void FQ1_Q2_Load(object sender, EventArgs e)
        {
            btnEnd1.Visible = false;
            dgQ1.Visible = false;
            btnEnd2.Visible = false;
            dgQ2.Visible = false;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EazyShape per = new EazyShape();
            per.Show();
        }

       private void btnQ1_Click(object sender, EventArgs e)
        {
          //  btnQAB.Enabled = false;
            btnQ2.Visible = false;
            btnQ1.Enabled = false;
            back.Enabled = false;
            btnEnd1.Visible = true;
            dgQ1.Visible = true;
            //string strSQLQ21;
            strSQL = "select distinct CustomerId, FirstName+' '+ SurName AS fullname  from tblMemberCustomer inner join tblCustomer on tblMemberCustomer.memberID = tblCustomer.CustomerId left outer join tblEnteringToClub on tblMemberCustomer.memberID = tblEnteringToClub.memberID where tblEnteringToClub.memberID IS NULL;";
            //    sqlCmd = new command(strSQLQ21);
            //strSQL21 = "SELECT DISTINCT Q.clientId, Q.clientName, Q.siteId,  E.lastName + ' '+ E.firstName AS headTeamName FROM viewQ21 Q INNER JOIN  visits V ON V.clientId=Q.clientId AND V.siteId=Q.siteId INNER JOIN teams T ON T.teamID=V.teamId INNER JOIN Employee E ON E.empID=T.headTeam ORDER BY Q.clientName, Q.siteID DESC";
            sqlCmd = new command(strSQL);
            dgQ1.DataSource = sqlCmd.datatable();
        
        }
       private void btnQ2_Click(object sender, EventArgs e)
       {
         //  btnQAB.Enabled = false;
           btnQ2.Enabled = false;
           btnQ1.Visible = false;
           back.Enabled = false;
           btnEnd2.Visible = true;
           dgQ2.Visible = true;
           strSQL = "select CustomerId, FirstName, SurName, PhoneNum,CellPhone from tblMemberCustomer inner join tblCustomer on tblMemberCustomer.memberID = tblCustomer.CustomerId  left outer join tblEnteringToClub on tblMemberCustomer.memberID = tblEnteringToClub.memberID  where (DateDiff(m, EnteringDate ,getdate() ))< 4 and  tblMemberCustomer.memberID in  (SELECT memberID from tblEnteringToClub  group by memberID having count(memberID) >=1) UNION select CustomerId, FirstName,SurName,PhoneNum,CellPhone from tblPotentialCustomer inner join tblCustomer on tblPotentialCustomer.interestedClientNum = tblCustomer.CustomerId where Status = 1 and tblPotentialCustomer.RecommendedByCustomerId  in ( select RecommendedByCustomerId  from tblPotentialCustomer  group by RecommendedByCustomerId   having count(RecommendedByCustomerId) >=2); ";
           sqlCmd = new command(strSQL);
           dgQ2.DataSource = sqlCmd.datatable();
       }

        private void btnEnd1_Click(object sender, EventArgs e)
        {
          //  btnQAB.Enabled = true;
            btnQ1.Enabled = true;
            btnQ2.Visible = true;
            back.Enabled = true;
            btnEnd1.Visible = false;
            dgQ1.Visible = false;
        }

        private void btnEnd2_Click(object sender, EventArgs e)
        {
          //  btnQAB.Enabled = true;
            btnQ1.Visible = true;
            btnQ2.Enabled = true;
            back.Enabled = true;
            btnEnd2.Visible = false;
            dgQ2.Visible = false;
        }

        private void btnQAB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQ12 f = new FQ12();
            f.Show();
        }

        private void dgQ2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
      
       

       
    }
}
