using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop
{
    public class bill
    {

        public List<bill> bill_list = new List<bill>();
        private int _billno ;
        private order _order;

        public order Order
        {
            get { return _order; }
            set { _order = value; }
        }
        public int Billno
        {
            get { return _billno; }
            set { _billno = value; }
        }


        private int _amount = 0;

        public int Amount
        {
            get { return _amount; }

        }
        public bill()
        { 
        
        }
        public bill(order p,int billno)
        {
            int temp_am=0;
            foreach (var item in p.orderlist)
            {
                temp_am += item.Subtotal;
            }
            this._order=p;
            this._amount = temp_am;
            this._billno = billno;
        }

    }
}