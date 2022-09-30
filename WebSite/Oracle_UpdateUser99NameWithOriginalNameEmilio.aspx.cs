using System;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace WebSite
{
    public partial class Oracle_UpdateUser99NameWithOriginalNameEmilio : OraclePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sqlCmd = "update users set users.name = 'Emilio' where users.id = 99";
            sqlQuery.Text = sqlCmd; 
            
            var connStr = ConfigurationManager.ConnectionStrings["OracleLocalConnection"].ToString();
            using (OracleConnection connnection = new OracleConnection(connStr))
            {
                connnection.Open();
                var sqlCommand = new OracleCommand(sqlCmd, connnection);
                sqlCommand.ExecuteReader();
            }
        }
    }
}