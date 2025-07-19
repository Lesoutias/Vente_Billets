using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vente_Billets.Classes
{
    class ClsAgents
    {
        int id;
        string noms;
        string contact;
        string fonction;
        string username;
        string password;
        string refSalle;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Fonction { get => fonction; set => fonction = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string RefSalle { get => refSalle; set => refSalle = value; }
    }
}
