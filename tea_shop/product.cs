using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop
{
    public  class product
    {
      
       
        private string _pname;

        public string Pname
        {
            get { return _pname; }
            set { _pname = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
          
        }
        public product() { }

        public product(string name, int price)
        {
            this._pname = name;
            this._price = price;
        }
       
       
        
          
            
               
              
            
        

    }


}
