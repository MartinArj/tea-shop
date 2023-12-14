using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tea_shop
{
     
    class Program
    {
       public static int bill_no = 1;

       static void Main(string[] args)
       {
           bool next_bill = true;
          
               products ap = new products();

               int c = 1;
               Console.WriteLine("_______________________________");
               Console.WriteLine("p.no"+"   | name         |price");
               Console.WriteLine("_______________________________");
               foreach (var it in ap.productList)
               {
                   Console.Write(c++ + ".     |" + it.Pname  );
                   for (int i = 0; i < 14-it.Pname.Length; i++)
                   {
                       Console.Write(" ");
                   }
                   Console.Write("|"+it.Price+"\n");
               }
               while (next_bill)
               {
               Console.Write("Enter product number :");
               int op1 = int.Parse(Console.ReadLine());
               Console.Write("Enter quantity       :");
               int qt1 =Math.Abs( int.Parse(Console.ReadLine()));
             
               int n = op1;
               order o = new order();
               while (n != 0)
               {

                   plist prod = (plist)n;
                   string s = prod.ToString();

                   o.add_order(new order(o.prodct_tetail(s, ap), qt1, ap));
                   Console.Write("do you want order more product if yes product number,no enter 0 to exit:");
                   int op2 = int.Parse(Console.ReadLine());
                   if (op2 == 0) { break; }
                   Console.Write("Enter quantity:");
                   int qt2 = Math.Abs(int.Parse(Console.ReadLine()));
                
                   n = op2;
                  
                   qt1 = qt2;

               }
               bill p = new bill(o, bill_no++);
               Console.WriteLine("______________________________________________________");
               Console.WriteLine("          J.T.M TEA SHOP                   |bill no:" + p.Billno + " |");
               Console.WriteLine("___________________________________________|__________|");
               
               Console.WriteLine("o.no       |name      |price    |Qt        |sub       |");

               Console.WriteLine("___________|__________|_________|__________|__________|");
               p.bill_list.Add(p);
               int np = 1;
             
               foreach (var item in o.orderlist)
               {
                   Console.Write(np++ + ".         |" + item.Prod.Pname );
                   for (int i = 0; i <9-item.Prod.Pname.Length ; i++)
                   {
                       Console.Write(" ");
                   }
                   Console.Write(" |"+ item.Prod.Price + "       |" + item.Quantity + "         |" + item.Subtotal+"         |\n");
               }
               Console.WriteLine("___________|__________|_________|__________|__________|");
               Console.WriteLine("          THANK YOU                       |amount=" + p.Amount+"|");
               Console.WriteLine("_______________________________________________________");
               Console.WriteLine("another customer here:if yes enter 1 else enter 0");
               Int16 a = Int16.Parse(Console.ReadLine());
               if (a == 0)
               {
                   next_bill = false;
               }
           }
       }
    }
    enum plist { tea=1,cofee=2,milk=3,snacks=4,bicuits=5,vada=6,bill_list=7}
}
