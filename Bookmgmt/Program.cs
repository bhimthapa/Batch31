using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch31.Data;

namespace Bookmgmt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accessing dataaccess tier in order to get data
            DataAccess data = new DataAccess();
            //Reading all data from Database table and pushed into c# list object
           List<Book> lstBook= data.GetBooks();
            //Real all the records from lstBook list
            foreach (var item in lstBook)
            {
                Console.Write(item.Id);
                Console.Write(item.BookName);
                Console.Write(item.WriterName);
                Console.Write(item.Price);
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
