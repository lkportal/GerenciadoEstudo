using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerenciadoEstudo.model {
    static class BDConnection {

        public static string urlConnection = "Server=DESKTOP-7KUBS2C\\SQLEXPRESS;Database=rotina_estudo;Trusted_Connection=True;";


        public static void ConectaBD() {
            SqlConnection conecta = new SqlConnection(urlConnection);
            try {
                conecta.Open();
                MessageBox.Show(conecta.State.ToString());

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DesconectaBD() {
            SqlConnection conecta = new SqlConnection(urlConnection);
            
            try {
                conecta.Close();
                MessageBox.Show(conecta.State.ToString());

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
