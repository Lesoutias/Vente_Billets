using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vente_Billets.Classes
{
    class ClsClients
    {
        int id;
        string noms;
        string adresse;
        string contact;
        string genre;
        int age;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Age { get => age; set => age = value; }


    }
}
