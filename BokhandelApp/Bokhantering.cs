using System;
using System.Linq;

namespace BokhandelApp
{
    public static class Bokhantering
    {
        public static void LäggTillBok()
        {
            using (var db = new BokhandelEntities())
            {
                Console.Write("Ange boktitel: ");
                string titel = Console.ReadLine();

                Console.Write("Ange språk: ");
                string språk = Console.ReadLine();

                Console.Write("Ange pris: ");
                decimal pris = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Ange utgivningsdatum (yyyy-mm-dd): ");
                DateTime utgivningsdatum = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Ange Författarens ID: ");
                int författarId = Convert.ToInt32(Console.ReadLine());

                var nyBok = new Böcker
                {
                    ISBN = Guid.NewGuid().ToString().Substring(0, 13),
                    Titel = titel,
                    Språk = språk,
                    Pris = pris,
                    Utgivningsdatum = utgivningsdatum,
                    FörfattarID = författarId
                };

                db.Böcker.Add(nyBok);
                db.SaveChanges();
                Console.WriteLine($"Boken \"{titel}\" har lagts till!");
            }
        }

        public static void UppdateraBok()
        {
            using (var db = new BokhandelEntities())
            {
                Console.Write("Ange ISBN för boken du vill uppdatera: ");
                string isbn = Console.ReadLine();

                var bok = db.Böcker.FirstOrDefault(b => b.ISBN == isbn);
                if (bok != null)
                {
                    Console.Write("Ange nytt pris: ");
                    bok.Pris = Convert.ToDecimal(Console.ReadLine());

                    db.SaveChanges();
                    Console.WriteLine($"Boken \"{bok.Titel}\" har uppdaterats med nytt pris!");
                }
                else
                {
                    Console.WriteLine("Bok hittades inte.");
                }
            }
        }

        public static void TaBortBok()
        {
            using (var db = new BokhandelEntities())
            {
                Console.Write("Ange ISBN för boken du vill ta bort: ");
                string isbn = Console.ReadLine();

                var bok = db.Böcker.FirstOrDefault(b => b.ISBN == isbn);
                if (bok != null)
                {
                    db.Böcker.Remove(bok);
                    db.SaveChanges();
                    Console.WriteLine($"Boken \"{bok.Titel}\" har tagits bort.");
                }
                else
                {
                    Console.WriteLine("Bok hittades inte.");
                }
            }
        }
    }
}

