using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace tea_shop
{
    public class bill
    {

        
        private int _billno ;
        

       
        public int Billno
        {
            get { return _billno; }
            set { _billno = value; }
        }
        public string date;


        private int _amount = 0;

        public int Amount
        {
            get { return _amount; }

        }
        public bill()
        { 
        
        }
        
        public bill(order_repositary p,string billdate )
        {
            float temp_am=0;
            foreach (var item in p.orderlist)
            {
                temp_am += item.Subtotal;
            }
            
            this._amount = (int)temp_am;
            this._billno = lost_bill_no()+1;
            this.date = billdate;
        }
        public void AddBill()
        {
            bill_repositary.bill_list.Add(this);
        }
        string path = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=teashop;Integrated Security=True";
        public int lost_bill_no()
        {
            int lost_id = 0;
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select top 1 billid from bills order by billid desc;";
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lost_id = Convert.ToInt32(dr["billid"]);
                }
            }
            return lost_id;

        }
      public  void loadbill()
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO  bills values(" + this.Amount + ",'" + this.date + "')";
                cmd.ExecuteNonQuery();
            }
        }

    }
}