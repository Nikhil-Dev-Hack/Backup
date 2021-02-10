using System;
using System.IO;

namespace C_Sharp__5
{
    public class FileCreationAndReading
    {
        public void Execute()
        {

            Console.WriteLine("enter file name:");
            var filename = Console.ReadLine();
            Console.WriteLine("enter content here:");
            var content = Console.ReadLine();
            var path = Path.Combine(Environment.CurrentDirectory, filename);
            ////File.AppendAllText(path, content);
            //////File.AppendAllText(path, content);
            ////Console.WriteLine("file is created:");
            ////var r = File.ReadAllText(path);
            ////Console.WriteLine(r);
            using (FileStream fs = File.Create(path))
            {
                using (TextWriter writer = new StreamWriter(fs))
                {
                    //FileRead(content, path);
                    writer.Close();
                }
                fs.Close();
            }
        }

        //private static void FileRead(string content, string path)
        //{
        //    //File.AppendAllText(path, content);
            
        //    //Console.WriteLine("file is created:");
        //    //var r = File.ReadAllText(path);
        //    //Console.WriteLine(r);
        //}
    }
}
