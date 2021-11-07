// See https://aka.ms/new-console-template for more information


namespace FilesAndDirectoryHomeWork4
{
    class program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Q1=============================");
            var HardDrive = Directory.GetLogicalDrives();
            var topTenfiles = Directory.GetDirectories(HardDrive[0]);


            foreach (var item in topTenfiles.Take(10))
            {
                Console.WriteLine(item);
            }

            printBigestFile(@"D:\Games");




            Console.WriteLine("Q1=============================");

            Console.WriteLine("Q2=============================");
            printBigestFile(@"D:\Games");

            Console.WriteLine("Q2=============================");



            Console.WriteLine("Q3====================");
            Library.chars();

            Console.WriteLine("Q3====================");

            Console.WriteLine("Q4====================");

            Library.TofixedLength2();

            Console.WriteLine("Q4====================");





            Console.WriteLine("Q5====================");


            Library.SaveAndCSV();




            Console.WriteLine("Q5====================");




            Console.WriteLine("Q6====================");

            Library.ReadAndCSV();




            Console.WriteLine("Q6====================");




        }


        public static void printBigestFile(string item)
        {
            Console.WriteLine("Q2=============================");
            var Files = new DirectoryInfo(item);

            var result = Files.GetFiles().OrderByDescending(file => file.Length).Take(3).ToList();

            foreach (var FileInfo in result)
            {
                Console.WriteLine(FileInfo.Name + " last update " + FileInfo.LastWriteTime);
            }
            Console.WriteLine("Q2=============================");

            



        }
        //שאלה 7 מה שיותר חסכוני זה FIXEDLENGTH
        //שאלה 8 החיסרונות הם שפיקסט מגביל אותך בכמה אתה יכול לכתוב
        // שאלה 9 קובץ טקסט רגיל יכול להכיל רק אותיות ומספרים בקוד הסקי וקובץ בינרי יכול להכיל את כל התווים האפשרים
           


      



    }

}
