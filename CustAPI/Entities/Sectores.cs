using Microsoft.Extensions.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;

namespace CustAPI.Entities
{
    public class Autores
    {
        Database objDB;
        private string ConnectionString;
        private readonly IConfiguration _configuration;
        

        [Key]
        public int id_autor { get; set; }
        public string nombre_autor { get; set; }
        public System.DateTime fechaNac_autor { get; set; }
        public string ciudad_autor { get; set; }
        public string correo_autor { get; set; }
        [NotMapped]
        public string ERRORMESSAGE { get; set; }

        public Autores()
        {
            ConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["CSCUSTOM"];            
        }

        public String GETAUTORES(int userid)
        {
            DataSet d;

            objDB = new SqlDatabase(ConnectionString);

            using (DbCommand objcmd = objDB.GetStoredProcCommand("GETAUTORES"))
            {
                objDB.AddInParameter(objcmd, "@usernr", DbType.String, userid);
                try
                {
                    d = objDB.ExecuteDataSet(objcmd);
                    if (d != null)
                    {
                        return JsonConvert.SerializeObject(objDB.ExecuteDataSet(objcmd).Tables[0]).ToString();
                    }
                }
                catch (Exception ex)
                {
                    this.ERRORMESSAGE = ex.Message;
                    return JsonConvert.SerializeObject(this);
                }
            }
            return "";
        }
    }

}
