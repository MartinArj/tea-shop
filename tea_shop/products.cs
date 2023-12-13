using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop
{
   public class products
    {
       public  List<product> productList = new List<product>();
       public products()
       {
           productList.Add(new product("tea", 10));
           productList.Add(new product("cofee", 15));
           productList.Add(new product("milk", 10));
           productList.Add(new product("snacks", 5));
           productList.Add(new product("bicuits", 10));
           productList.Add(new product("vada", 10));
       }
    }
}
