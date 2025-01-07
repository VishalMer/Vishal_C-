using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA
{
     class book
    {
        
            double price;
            string colour;
            int pages;

            public void getData()
            {
                price = 50;
                colour = "red";
                pages = 100;
            }

           public void showData()
            {
                Console.WriteLine("Price of the book is : " + price);
                Console.WriteLine("Pages of the book is : " + pages);
                Console.WriteLine("Colour of the book is : " + colour);
            }
        }
        class book1
    {
        public static void Main(string[] args)
        {
            book book1 = new book();
            book1.getData();
            book1.showData();

        }
    }
    
}
