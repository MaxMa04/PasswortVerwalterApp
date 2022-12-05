using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PasswortVerwalterApp.Models
{
    [Table("Einträge")]
    public class Eintrag
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Konto { get; set; }
        public string EMail { get; set; }
        public string Benutzername { get; set; }
        public string Passwort { get; set; }
    }
}
