using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            var fileName = Path.Combine(directory.FullName, "data.txt"); //Path.Combine will add / if / missing 
            var file = new FileInfo(fileName);

            if (file.Exists)
            {
                //var reader = new streamreader(file.fullname);
                //try
                //{
                //    console.setin(reader);
                //    console.writeline(console.readline());
                //}
                //finally
                //{
                //    reader.close();
                //}

                //simple way 
                using (var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());  
                }//calls dispose method which calls the close method 
            }

        }
    }
}
