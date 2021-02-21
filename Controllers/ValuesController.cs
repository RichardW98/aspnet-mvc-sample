using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Collections;

namespace Sample.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public string Getdb() {
            //try
            //{
            //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //    builder.DataSource = "<your_server>.database.windows.net";
            //    builder.UserID = "<your_username>";
            //    builder.Password = "<your_password>";
            //    builder.InitialCatalog = "<your_database>";

            //    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            //    {
            //        Console.WriteLine("\nQuery data example:");
            //        Console.WriteLine("=========================================\n");

            //        String sql = "SELECT name, collation_name FROM sys.databases";

            //        using (SqlCommand command = new SqlCommand(sql, connection))
            //        {
            //            connection.Open();
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //Console.ReadLine();
            string resp = "";
            foreach (DictionaryEntry variable in Environment.GetEnvironmentVariables())
                resp += variable.Key + ": " + variable.Value + ", ";
            return resp;
        }
    }
}
