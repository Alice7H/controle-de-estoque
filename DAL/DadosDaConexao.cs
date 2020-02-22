using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        //public static String StringDeConexao
        //{
        //    get { return "Data Source=LAPTOP-S60FG3D3\\SQLEXPRESS;Initial Catalog=db_controledeestoque;Integrated Security=True"; }
        //}

        public static String servidor = "LAPTOP-S60FG3D3\\SQLEXPRESS";
        public static String banco = "db_controledeestoque";
        public static String usuario = "sa";
        public static String senha = "123456";
        public static String StringDeConexao
        {
            get
            {
                if (usuario == "sa")
                {
                    return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
                }
                else {
                    return "Data Source=LAPTOP-S60FG3D3\\SQLEXPRESS;Initial Catalog=db_controledeestoque;Integrated Security=True";
                }

            }
        }
    }
}
