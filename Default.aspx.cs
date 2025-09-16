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
using TestWebApplicationBusiness;
using TestWebApplicationBusiness.IlceModels;
using TestWebApplicationBusiness.IlModels;
using TestWebApplicationBusiness.Ulke;

namespace TestWebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbConnectionTest.ConnectionTest cnn = new dbConnectionTest.ConnectionTest();
            DataTable dt = new DataTable();

            //try
            //{
            //    string sqlinsert = "insert into ULKE(UlkeAd) values ('LONDON')";
            //    var cmdinsert = cnn.CreateCommand(sqlinsert, CommandType.Text);
            //    cnn.EXECUTE_NONQUERY(cmdinsert);
            //    cnn.Commit();
            //}
            //catch (Exception ex)
            //{
            //    cnn.Rollback();
            //} buna gerek yok metod olarak yapıldı

            string sql = "select * from ULKE";
            var cmd = cnn.CreateCommand(sql, CommandType.Text);
            dt = cnn.EXECUTE(cmd); // debung üzerinedn test edıldı

            string sqlCount = "SELECT COUNT(*) FROM ULKE";
            var cmdCount = cnn.CreateCommand(sqlCount, CommandType.Text);
            cnn.ExecuteScalar(cmdCount); // debung üzerinedn test edıldı

            //string sqlAlter = @"ALTER TABLE ULKE 
            //          ADD kolonadı int  DEFAULT 1;
            //         ihtiyaca göre sekıllendir


            //var cmdAlter = cnn.CreateCommand(sql, CommandType.Text);
            //cnn.EXECUTE_NONQUERY(cmd);
            //cnn.Commit();  // yeni bir kolon eklmek istersem

            //CountryBusiness cb = new CountryBusiness();
            //ulke u1 = new ulke { ulkeadi = "TÜRKİYE" };
            //cb.AddCountry(u1);
            //ulke u2 = new ulke { ulkeid = 12, ulkeadi = "ALMANYA" };
            //cb.UpdateCountry(u2);
            //cb.DeleteCountry(14); 

            IlBusiness ib = new IlBusiness();
            il i1 = new il { ilad = "MUŞ", ulkeid = 1 };
            ib.Addil(i1);
            il i2 = new il { ilad = "VENEDİK", ilid = 3 };
            ib.UpdateIl(i2);
            ib.DeleteIl(8);

            IlceBusiness icb = new IlceBusiness();
            Ilce ilce1 = new Ilce {IlceAd= "EDREMİT",IlId=1 };
            icb.AddIlce(ilce1);
            Ilce ılce2 = new Ilce { IlceAd = "GURPİNAR", IlceId = 2 };
            icb.UpdateIlce(ılce2);
            icb.Deleteılce(9);
            // 5.AYIN 25 İ
        }
    }
}