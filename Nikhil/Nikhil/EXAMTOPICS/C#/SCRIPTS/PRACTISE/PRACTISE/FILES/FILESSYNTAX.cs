using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PRACTISE.FILES
{
    public class FILESSYNTAX
    {
        public void NormalFiles()
        {
            Console.WriteLine("Enter the FileName");
            var FileName = Console.ReadLine();
            Console.WriteLine("Enter your Content");
            var Content = Console.ReadLine();
            var Loaction = Path.Combine(Environment.CurrentDirectory, FileName);
            File.WriteAllText(Loaction, Content);
            //File.AppendAllText(Loaction, Content);
            //File.AppendText(Loaction);

            var Read = File.ReadAllText(FileName);
            Console.WriteLine(Read);
        }


        public void FilesUsing()
        {
            Console.WriteLine("Enter the FileName");
            var FileName = Console.ReadLine();
            Console.WriteLine("Enter your Content");
            var Content = Console.ReadLine();
            var Loaction = Path.Combine(Environment.CurrentDirectory, FileName);

            using (FileStream fs = File.Create(Loaction))
            {
                using (TextWriter writer = new  StreamWriter(fs))
                {
                    writer.Write(Content);
                    writer.Close();
                }
                using (TextReader reader = File.OpenText(Loaction))
                {
                    Console.WriteLine(reader.ReadToEnd());
                    reader.Close();
                }fs.Close();
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
