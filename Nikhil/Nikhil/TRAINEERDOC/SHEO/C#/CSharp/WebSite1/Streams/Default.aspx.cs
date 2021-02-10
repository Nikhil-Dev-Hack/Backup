using System;
using System.IO;

public partial class Streams_Default : System.Web.UI.Page
{
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    //Create a text file using Stream

    //}
    //FileStream fs = null;
    //TextWriter writer = null;


    /// <summary>
    /// Creates the A text file.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// 

    //protected void CreateATextFile(object sender, EventArgs e)
    //{
    //    Console.WriteLine("enter file name");
    //    var fname= Console.ReadLine();
    //    //string path = Server.MapPath("~/Streams/file1.txt");
    //    //File.WriteAllText(path, "datafadfafadfadfadsf fad sf asd fad sf ads f asd f ads fasdf");
    //    //File.AppendAllText(path, "FDSAFASDFADSFAFAFA FADFADFAFAFADFA");

    //    var path = Path.Combine(@"\\192.168.50.220\Freshers2020 - Trainees\C#\CSharp", fname);
    //    FileStream fs = null;
    //    TextWriter writer = null;
    //    try
    //    {
    //        fs = File.Create(path);
    //        writer = new StreamWriter(fs);
    //        for (int i = 0; i < 100; i++)
    //        {
    //            writer.WriteLine("Some data " + i);
    //        }
    //    }
    //    finally
    //    {
    //        writer.Close();
    //        writer.Dispose();
    //        fs.Close();
    //        fs.Dispose();
    //    }


//        using (FileStream fs = File.Create(path))
//{
//    using (TextWriter writer = new StreamWriter(fs))
//    {
//        for (int i = 0; i < 100; i++)
//        {
//            writer.WriteLine("Some data " + i);
//        }
//        writer.Close();
//    }
//    fs.Close();
//}

//path = Server.MapPath("~/Streams/myfile2.txt");
//using (StreamWriter writer = new StreamWriter(path, true, System.Text.Encoding.UTF8, 65536))
//{
//    writer.Write("Complete content of the file.");
//    writer.Close();
//}
//    }

    /// <summary>
    /// Reads the A text file.
    /// </summary>
    /// <param name = "sender" > The sender.</param>
    /// <param name = "e" > The < see cref="System.EventArgs"/> instance containing the event data.</param>
    //protected void ReadATextFile(object sender, EventArgs e)
    //{
    //    string path = Server.MapPath("~/Streams/file1.txt");
    //    //Response.Write(File.ReadAllText(path));

    //    using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.ReadWrite))
    //    {
    //        using (TextReader reader = new StreamReader(fs))
    //        {
    //            while (true)
    //            {
    //                string thisLine = reader.ReadLine();
    //                if (thisLine == null)
    //                {
    //                    break;
    //                }
    //                lblMessage.Text += thisLine + "<br />";
    //            }

    //        }

    //    }

    //    path = Server.MapPath("~/Streams/myfile2.txt");
    //    string fileContent = string.Empty;
    //    using (StreamReader reader = new StreamReader(path))
    //    {
    //        fileContent = reader.ReadToEnd();
    //    }
    }
}