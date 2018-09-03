using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject
{
    class Class1
    {
        //dgSite.Rows.Clear();
        //dgSite.Refresh();

        //  dgotherSite.Rows.Clear();
        //dgotherSite.Refresh();
        //   MessageBox.Show("ID");
        // List<oneSite> list = new List<oneSite>();
        //  SQLCommand sqlCmd = new SQLCommand(strSite);
        /*  list = sqlCmd.readData(strSite,ID);
          foreach (oneSite onesite in list)
          {
              if(n==1) this.dgSite.Rows.Add(onesite.siteID, onesite.clientId, onesite.siteAddress, onesite.startDate, onesite.day);
              if (n == 2 ) this.dgotherSite.Rows.Add(onesite.siteID, onesite.clientId, onesite.siteAddress, onesite.startDate,Convert.ToInt16(onesite.day));

            
          }  */
        /* public void open()
       {
           if (sqlconnection.State != ConnectionState.Open) sqlconnection.Open();
       }
       public void close()
       {
           if (sqlconnection.State == ConnectionState.Open) sqlconnection.Close();
       }*/
        // listBox1.Items.Add(list[0].clientId);



        /*   SQLCommand sqlCmd = new SQLCommand(strSite);
           int k = 0,i=0;
           List<string> list = new List<string>();
           list = sqlCmd.readData(strSite,ID);
           string[] arr = new string[5];

           foreach(string strList in list)
           {
               arr = strList.Split(',');
               while (k< n)
               {
                   dgSite.Rows[i].Cells[k].Value = arr[k];
                   k++;
                   if (n == 1) this.dgSite.Rows.Add();
                   if (n == 2) this.dgotherSite.Rows.Add(onesite.siteID, onesite.clientId, onesite.siteAddress, onesite.startDate, Convert.ToInt16(onesite.day));
               }
               k = 0;
               i++;
           }*/

        /*    SQLCommand s = new SQLCommand(strSql);
               DataTable table = s.datatable();
       
               for (int i = 0; i < table.Rows.Count; i++)
               {

                   if (Convert.ToInt32(table.Rows[i][1]) == id)
                   {
                       oneSite one=new oneSite(Convert.ToInt32(table.Rows[i][0]),
                       Convert.ToInt32(table.Rows[i][1]),
                       Convert.ToString(table.Rows[i][2]),
                       Convert.ToString(table.Rows[i][3]),
                       Convert.ToDouble(table.Rows[i][4]));
                       list.Add(one);
                   }
               }
                
               table.Clear();
               return list;
            

           
              int i=0;
              cmd = new SqlCommand(strSql+"where permanentSite.clientId="+id, sqlconnection);   
              sqlconnection.Open();
              using (dr = cmd.ExecuteReader())
              {
                  while (dr.Read())
                  {
                      if (Convert.ToInt64(dr[1].ToString()) == id)
                      {
                          list[i] = dr[i].ToString();
                          i++;
                          while (i < n)
                          {
                              list[i] = list[i] + ',' + dr[i].ToString();
                              i++;
                          }
                          i = 0;
                      }
                  }
              }
              dr.Close();
              sqlconnection.Close();
              return list;*/

        /* string con = @"Data Source=RANEEN-BSAIS\RANEEN;Initial Catalog=PerfectGarden;Integrated Security=True";
       SqlConnection sqlconnection;
       sqlconnection = new SqlConnection(con);
        SqlDataReader dr;
       SqlCommand cmd;
       int i = 0;
       cmd = new SqlCommand("select * from Clients", sqlconnection);
       sqlconnection.Open();
       dr = cmd.ExecuteReader();
       while (dr.Read())
       {
           listBox1.Items.Add(dr[0] + dr[1].ToString());
               
       }
       dr.Close();
       sqlconnection.Close();*/
    }
}
