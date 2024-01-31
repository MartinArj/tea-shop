using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop
{
   public class order
    {
       order_repositary or = new order_repositary();

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
        private float _subtotal;

        public float Subtotal
        {
            get { return _subtotal; }
           
        }
        public float unitPrice(string pname)
        {
            float Up = 0;
            foreach (var item in product_repositary.productList)
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
        public order(product product,int quatity)
        {
            this._quantity= quatity;
            this._subtotal = unitPrice(product.Pname) * quatity;
            this._prod = product;
        }
        public product prodct_tetail(string prod)
        {
            product t=new product();
            foreach (product item in product_repositary.productList)
            {

                if (prod == item.Pname)
                {
                    t = item;
                    break;
                }

            }
            return t;

        }
      

    }
}
