using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswortVerwalterApp.Models;
using SQLite;

namespace PasswortVerwalterApp.Services
{
    public static class EintragService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyData.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Eintrag>();
        }
        public static async Task AddEintrag(string konto, string email, string benutzername, string passwort)
        {
            await Init();
            Eintrag eintrag = new Eintrag()
            {
                Konto = konto,
                EMail = email,
                Benutzername = benutzername,
                Passwort = passwort

            };
            await db.InsertAsync(eintrag);
        }
        public static async Task<IEnumerable<Eintrag>> GetEintraege()
        {
            await Init();
            var eintraege = await db.Table<Eintrag>().ToListAsync();
            return eintraege;
        }
        public static async Task DeleteEintrag(Eintrag eintrag)
        {
            await Init();
            
            await db.DeleteAsync(eintrag);
            return;
        }
    }
}
