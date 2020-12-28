using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkTask
{
    class InsertRecordIntoProductsClass1
    {
        public void Insert()
        {
            
            try
            {
                using(var context=new ContextClass1())
                {
                    var product = new Product
                    {
                        ProductName = "Laptop",
                        ProductPrice = 30000

                    };
                    context.Productss.Add(product);
                    context.SaveChanges();
                    Console.WriteLine("Record inserted sucessfully ");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Record  is not  inserted suessfully");
            }

        }
    }
}
