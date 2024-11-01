using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    internal class ConexaoAluno
    {
        MySqlConnection conn;
        public void ConectarBD()
        {
            try
            {
                conn = new MySqlConnection("Persist Security Info= false; server = localhost;" + "database=bdescola;user=root;pwd=;");
                conn.Open();
            }
            catch(Exception)
            {
                throw;
            }
            
        }
        public int executarComandos(String sql)
        {
            int resultado;
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception)
            {
                resultado = 0;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return resultado;
        }
        public DataTable executarConsulta(String sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
