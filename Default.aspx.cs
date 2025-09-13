using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable dt =new DataTable();
           dbConnectionTest.ConnectionTest cnn = new dbConnectionTest.ConnectionTest();
            //string sqlinsert = "insert into ULKE(UlkeAd) values ('BELÇİKA')";
            //var cmdinsert = cnn.CreateCommand(sqlinsert, CommandType.Text);
            //dt = cnn.EXECUTE_NONQUERY(cmdinsert);
            //cnn.Commit();

            try
            {
                string sqlinsert = "insert into ULKE(UlkeAd) values ('BELÇİKA')";
                var cmdinsert = cnn.CreateCommand(sqlinsert, CommandType.Text);
                dt = cnn.EXECUTE_NONQUERY(cmdinsert);
                cnn.Commit();
            }
            catch (Exception ex)
            {
                cnn.Rollback();
                throw;
            }
            string sql = "select * from ULKE";
            var cmd =  cnn.CreateCommand(sql, CommandType.Text);
            dt = cnn.EXECUTE(cmd);

            string sqlCount = "SELECT COUNT(*) FROM ULKE";
            var cmdCount = cnn.CreateCommand(sqlCount, CommandType.Text);  
            object result = cnn.ExecuteScalar(cmdCount);
            

        }
    }
}