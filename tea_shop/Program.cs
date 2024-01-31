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
           order_repositary or = new order_repositary();
               product_repositary ap = new product_repositary();
               Console.WriteLine("1.add product");
               Console.WriteLine("2.update product");
               Console.WriteLine("3.delete product");
               Console.WriteLine("4.make bill");
               int ch = int.Parse(Console.ReadLine());
               while (true)
               {
                   if (ch == 1)
                   {
                       Console.WriteLine("enter product name:");
                       string name = Console.ReadLine();
                       Console.WriteLine("enter product price point after end of dht with f:");
                       float price = float.Parse(Console.ReadLine());
                       ap.addproduct(name, price);
                       
                       Console.WriteLine("do you want add more product yes enter 1  no 5 ");
                       ch = int.Parse(Console.ReadLine());
                       continue;
                   }
                   if (ch == 2)
                   {
                       Console.WriteLine("enter id=");
                       int id = int.Parse(Console.ReadLine());
                       ap.update(id);
                   }
                   if (ch == 3)
                   {
                       Console.WriteLine("enter id=");
                       int id = int.Parse(Console.ReadLine());
                       ap.delete(id);
                   }
                   break;

                   
               }

               int c = 1;
               Console.WriteLine("_______________________________");
               Console.WriteLine("p.no"+"   | name         |price");
               Console.WriteLine("_______________________________");
               foreach (var it in product_repositary.productList)
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
               if (ap.available(op1)==false)
               {
                   Console.Write("invaild OR not available OR check product no.\n enter product number:");
                   op1 = int.Parse(Console.ReadLine());
               }
               Console.Write("Enter quantity       :");
               int qt1 =Math.Abs( int.Parse(Console.ReadLine()));
             
               int n = op1;
               order o = new order();
               while (n != 0)
               {

                  
                   string s = product_repositary.prod_dic[n];

                   or.add_order(new order(o.prodct_tetail(s), qt1));
                   Console.Write("do you want order more product if yes product number,no enter 0 to exit:");
                   int op2 = int.Parse(Console.ReadLine());
                   if (op2 == 0) { break; }
                   Console.Write("Enter quantity:");
                   int qt2 = Math.Abs(int.Parse(Console.ReadLine()));
                
                   n = op2;
                  
                   qt1 = qt2;

               }
               string billdate = DateTime.Today.ToString("dd/MM/yyyy");
               bill p = new bill(or,billdate);
            
               Console.WriteLine("______________________________________________________");
               Console.WriteLine("          J.T.M TEA SHOP   date:"+billdate+" |bill no:" + p.Billno + " |");
               Console.WriteLine("___________________________________________|__________|");
               
               Console.WriteLine("o.no       |name      |price    |Qt        |sub       |");

               Console.WriteLine("___________|__________|_________|__________|__________|");
               bill_repositary.bill_list.Add(p);
               p.loadbill();
               or.order_completed();
               int np = 1;
             
               foreach (var item in or.orderlist)
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
    enum plist 
    { 
        tea=1,cofee=2,milk=3,snacks=4,bicuits=5,vada=6,bill_list=7
    }
}
