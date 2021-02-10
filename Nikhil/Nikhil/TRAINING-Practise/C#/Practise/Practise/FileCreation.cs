using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practise
{
    public class FileCreation
    {
        public void FilesNormal()
        {
            Console.WriteLine("Enter the file name");
            var FileName = Console.ReadLine();
            Console.WriteLine("Enter your content");
            var Content = Console.ReadLine();
            var P = Path.Combine(Environment.CurrentDirectory, FileName);
            File.WriteAllText(P, Content);

            var r = File.ReadAllText(FileName);
            Console.WriteLine(r);

        }

        public void FilesUsing()
        {

            Console.WriteLine("Enter the file name");
            var FileName = Console.ReadLine();
            Console.WriteLine("Enter your content");
            var Content = Console.ReadLine();
            var P = Path.Combine(Environment.CurrentDirectory, FileName);

            using (FileStream fs = File.Create(P))
            {
                using (TextWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine(Content);
                    
                }
            }
        }

        public void UsingFinally()
        {
            Console.WriteLine("Enter the file name");
            var FileName = Console.ReadLine();
            
            var P = Path.Combine(Environment.CurrentDirectory, FileName);

            FileStream fs = null;
            TextWriter writer = null;
            try
            {
                fs = File.Create(P);
                writer = new StreamWriter(fs);
                Console.WriteLine("Enter your content");
                var Content = Console.ReadLine();
                writer.WriteLine(Content);
            }
            finally
            {
                writer.Close();
                writer.Dispose();
                fs.Close();
                fs.Dispose();
            }
        }

    }
}
