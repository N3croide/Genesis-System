using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace Proyectointe
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static OracleConnection conexion;
        public static OracleCommand comando;
        public static OracleDataReader lector;
        public static string[] CalificacionP = new string[3];
        public static string[] CalificacionS = new string[3];
        public static string[] CriterioP = new string[3];
        public static string[] CriterioS = new string[3];
        public static InterfazAdmin InterfazAd = new InterfazAdmin();
        public static string cedula = "";
        [STAThread]
        public static void Main()
        { 
            
            string databaseOracle = @"(DESCRIPTION = " +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = XE))); " +
            "User Id =proint; Password =proint";
            conexion = new OracleConnection($"Data Source={databaseOracle}");
            conexion.Open();
            comando = conexion.CreateCommand();
            Application.EnableVisualStyles();
            Application.Run(InterfazAd);
        }
    }

    
}
