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
        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _prodid;

        public int Prodid
        {
            get { return _prodid; }
           
        }
        
        public product() { }

        public product(string name, float price,int pid)
        {
            this._pname = name;
            this._price = price;
            this._prodid = pid;
        }
       
       
        
          
            
               
              
            
        

    }


}
