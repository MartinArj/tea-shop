using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace tea_shop
{
   public class order_repositary
    {
       string path = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=teashop;Integrated Security=True";
        public List<order> orderlist = new List<order>();
        public void add_order(order temp)
        {
            this.orderlist.Add(temp);
        }
        public void order_completed()
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT top 1 billid FROM bills order by billid desc;";
                SqlDataReader dr;
                 dr =cmd.ExecuteReader();
                 int billid = 0;
                 while (dr.Read())
                 {
                      billid = Convert.ToInt32(dr["billid"]);
                 }
                 dr.Close();
                foreach (var item in orderlist)
                {
                    cmd.CommandText = "INSERT INTO orders values("+billid+"," + item.Prod.Prodid + "," + item.Quantity + "," + item.Subtotal + ")";
                    cmd.ExecuteNonQuery();
                }
                
            
            
            }
        
        }
     

    }
}
