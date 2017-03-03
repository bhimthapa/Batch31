using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Step 1 : Include class lib for Database connect'ion
using System.Data.SqlClient; 

namespace Batch31.Data
{
    //Class
    public class DataAccess
    {
        //Method
        public List<Book> GetBooks()
        {
            List<Book> lstBooks = new List<Book>();
            //Step 2 : Configure Sql server and database
            SqlConnection conn = new SqlConnection("Data Source=BISHAL-PC\\SQLEXPRESS;Initial Catalog=Batch31;Integrated Security=True");
            //Step 3 : get the data from table
            SqlCommand cmd = new SqlCommand("Select * from Book", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            //Read all the records from 
            while(rd.Read())
            {
                lstBooks.Add(new Book()
                {
                    Id = rd.GetInt32(0),
                    BookName = rd.GetString(1),
                    WriterName = rd.GetString(2),
                    Price = rd.GetInt32(3)
                });

            }
            return lstBooks;


        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public int Price { get; set; }
    }
}
