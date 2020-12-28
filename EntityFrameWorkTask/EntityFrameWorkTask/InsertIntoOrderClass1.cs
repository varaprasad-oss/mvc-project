using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkTask
{
    class InsertIntoOrderClass1
    {
        public void Excute()
        {
            try
            {
                using (var context = new ContextClass1())
                {
                    var order = new Order();

                    Console.Write("Enter OrderName:");
                    order.OrderName = Console.ReadLine();
                    Console.Write("Enter  Orderprice : ");
                    order.OrderPrice = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Product id:");
                    order.ProductId = Convert.ToInt32(Console.ReadLine());
                    context.Orders.Add(order);
                    context.SaveChanges();
                    Console.WriteLine("Orders record inserted successfully.");
                }
            }
            catch
            {
                Console.WriteLine("oops somerthing went wrong");
            }


        }
        
    }
}
