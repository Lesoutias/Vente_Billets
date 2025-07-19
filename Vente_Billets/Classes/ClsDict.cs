using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Vente_Billets.Classes
{
    class ClsDict
    {
        static ClsDict instance = null;

        public static ClsDict Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClsDict();
                return instance;
            }
        }

        SqlConnection con = null;
        

        public void OpenConnection()
        {
            con = new SqlConnection(ClsConnexion.waybd);
            con.Open();
        }
    }
}
