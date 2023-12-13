using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop
{
   public class order
    {
       public List<order> orderlist = new List<order>();
        private product _prod;

        public product Prod
        {
            get { return _prod; }
        }
        private int _quantity;
     
        public int Quantity
        {
          get { return _quantity; }
          set { _quantity = value; }
}
        private int _subtotal;

        public int Subtotal
        {
            get { return _subtotal; }
           
        }
        public int unitPrice(string pname,products ap)
        {
            int Up = 0;
            foreach (var item in ap.productList)
            {
               
                if (pname == item.Pname)
                {
                    Up= item.Price;
                    break;
                }
                
            }
            return Up;
        }
        public order()
        { 
        }
        public order(product product,int quatity,products ap)
        {
            this._quantity= quatity;
            this._subtotal = unitPrice(product.Pname,ap) * quatity;
            this._prod = product;
        }
        public product prodct_tetail(string prod,products op)
        {
            product t=new product();
            foreach (product item in op.productList)
            {

                if (prod == item.Pname)
                {
                    t = item;
                    break;
                }

            }
            return t;

        }
        public void add_order(order temp)
        {
            orderlist.Add(temp);
        }

    }
}
