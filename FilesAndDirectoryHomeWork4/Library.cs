using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FilesAndDirectoryHomeWork4
{
    public class Library
    {
        //Q3*********************************
        public int Id { get; set; }
        public string Name { get; set; }
        public string Element { get; set; }
        public string Weapon { get; set; }
        public short NumberOfConstalltion { get; set; }
        public short NumberOfWishes { get; set; }
        public DateTime DatePublished { get; set; }

        static List<Library> libraries = new List<Library>();

        static Library()
        {
            libraries.Add(new Library { Id = 1, Name = "Huo Tao", Element = "Pyro", Weapon = "Staff of Homa", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 2, Name = "Yaomiya", Element = "Pyro", Weapon = "Rust", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 3, Name = "Baal", Element = "Electro", Weapon = "Engulfing", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 4, Name = "Diluc", Element = "Pyro", Weapon = "GravesStone", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 5, Name = "Mona", Element = "Hydo", Weapon = "Widstidth", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 6, Name = "Venti", Element = "Anemo", Weapon = "Stringless", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 7, Name = "Ayaka", Element = "Cryo", Weapon = "JadeCutter Blade", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 8, Name = "Qiqi", Element = "Cryo", Weapon = "Secrifical Sword", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });

            libraries.Add(new Library { Id = 9, Name = "Zhongli", Element = "Geo", Weapon = "Primodial Jade Spear", NumberOfConstalltion = 6, DatePublished = new DateTime(2021, 03, 11) });
        }




        public string ToJSON()
        {
            string str;
            str = string.Format("{0},{1},{2},{3},{4},{5},{6}", Id, Name, Element, Weapon, NumberOfConstalltion, NumberOfWishes, DatePublished);
            return str;
        }
        public static void chars()
        {
            var c = "";
            foreach (var Char in Library.libraries)
            {
                c += JsonSerializer.Serialize(Library.libraries);

            }
            File.WriteAllText(@"C:\Users\Or Ganon\source\repos\FilesAndDirectoryHomeWork4\FilesAndDirectoryHomeWork4\json1.json", c);
        }
        public string ToCSV()
        {
            string str;
            str = string.Format("{0},{1},{2},{3},{4},{5},{6}", Id, Name, Element, Weapon, NumberOfConstalltion, NumberOfWishes, DatePublished);
            return str;
        }

        public static void SaveAndCSV()
        {
            var s = "";
            foreach (var item in libraries)
            {
                s += item.ToCSV() + Environment.NewLine;
            }
            File.WriteAllText(@"D:\Games\Chars.CSV",s);

            
        }
        public static void ReadAndCSV()
        {
            
           var ListOfLines = File.ReadAllLines(@"D:\Games\Chars.CSV").ToList();
           


        }
        public string TofixedLength()
        {
          //Q4


            string str;
            str = string.Format("Id{0:2},Name{1:4}, Element{2:6}", Id, Name, Element);
            return str;
            //Q4


        }
        public static string TofixedLength2()
        {
            var f = "";
            foreach (var item in libraries)
            {
                f += item.TofixedLength() + Environment.NewLine;
            }
            return f;


        }

    }
}
