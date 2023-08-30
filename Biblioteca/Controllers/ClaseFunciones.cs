using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Biblioteca.Controllers
{
    public class ClaseFunciones
    {

        public static string cadena = "Server=(local)\\SQLExpress;Database=BD_Biblioteca;User Id=ADSO2501875;Password=12345;";
        public static string exception = "";

        public static string Func_Traer_Usuario(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cnn = new SqlConnection(cadena);
                SqlDataAdapter adp = new SqlDataAdapter("PA_ConsultaUsuario", cnn);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@nomuser", name);
                adp.Fill(dt);
                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception e)
            {
                exception = e.Message;
                return exception;
            }
        }

    }
}
