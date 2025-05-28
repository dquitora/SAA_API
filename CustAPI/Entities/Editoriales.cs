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
    public class Editoriales
    {
        Database objDB;
        private string ConnectionString;
        private readonly IConfiguration _configuration;

        [Key]
        public int id_editorial { get; set; }
        public string nombre_editorial { get; set; }
        public string direccion_editorial { get; set; }
        public string telefono_editorial { get; set; }
        public string correo_editorial { get; set; }
        public int maxlibros_editorial { get; set; }
        [NotMapped]
        public string ERRORMESSAGE { get; set; }

        public Editoriales()
        {
            ConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["CSCUSTOM"];
        }

        public String GETEDITORIALES(int userid)
        {
            DataSet d;

            objDB = new SqlDatabase(ConnectionString);

            using (DbCommand objcmd = objDB.GetStoredProcCommand("GETEDITORIALES"))
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
