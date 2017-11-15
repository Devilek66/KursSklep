using KursSklep.Migrations;
using KursSklep.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace KursSklep.DAL
{
    public class KursyInitializer : MigrateDatabaseToLatestVersion<KursyContext,Configuration>
    {

        public static void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() { KategoriaId = 1, NazwaKategorii= "asp", NazwaPlikuIkony = "asp.png", OpisKategorii = "opis asp net mvc" },
                new Kategoria() { KategoriaId = 2, NazwaKategorii = "java", NazwaPlikuIkony = "java.png", OpisKategorii = "opis java" },
                new Kategoria() { KategoriaId = 3, NazwaKategorii = "ruby", NazwaPlikuIkony = "ruby.png", OpisKategorii = "opis ruby" },
                new Kategoria() { KategoriaId = 4, NazwaKategorii= "php", NazwaPlikuIkony = "php.png", OpisKategorii = "opis php" },
                new Kategoria() { KategoriaId = 5, NazwaKategorii = "css", NazwaPlikuIkony = "css.png", OpisKategorii = "opis css" },
                new Kategoria() { KategoriaId = 6, NazwaKategorii = "html", NazwaPlikuIkony = "html.png", OpisKategorii = "opis html" }
            };

            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var kursy = new List<Kurs>
            {
                new Kurs(){ KursId = 1, AutorKursu = "Janek", KategoriaId = 1, OpisKursu = "opis kursu 1", TytulKursu = "Tytul kursu 1", Bestseller = true, NazwaPlikuObrazka = "kurs1.png", CenaKursu = 100, DataDodania = new DateTime(2017, 1, 18) },
                new Kurs(){ KursId = 2, AutorKursu = "Paweł", KategoriaId = 2, OpisKursu = "opis kursu 2", TytulKursu = "Tytul kursu 2", Bestseller = true, NazwaPlikuObrazka = "kurs2.png", CenaKursu = 120, DataDodania = new DateTime(2017, 2, 18) },
            };
            kursy.ForEach(k => context.Kursy.AddOrUpdate(k));
            context.SaveChanges();
        }
    }
}