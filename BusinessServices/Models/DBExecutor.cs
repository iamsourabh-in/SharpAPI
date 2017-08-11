using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BusinessServices.Models;

namespace BusinessServices.Models
{
    class DBExecutor : BusinessServices.Models.IDBExecutor
    {
        public void Execute()
        { 
           //string connectionString =  ConfigurationManager.AppSettings["WORKAHOLICdbEntities"].ToString();
            //string connectionString = "data source=IGNP-LPWDEV0004\\SQLEXPRESS;initial catalog=WORKAHOLIC;user id=sa;password=123;MultipleActiveResultSets=True;providerName='System.Data.SqlClient'";

            var db = new PetaPoco.Database("WORKAHOLICdbPeta");
           // Show all articles    

           foreach (var a in db.Query<DataModel.Employee>("SELECT * FROM employee"))
           {

               Console.WriteLine("{0} - {1}", a.CompanyId, a.Email);

           }

        }
    }
}
