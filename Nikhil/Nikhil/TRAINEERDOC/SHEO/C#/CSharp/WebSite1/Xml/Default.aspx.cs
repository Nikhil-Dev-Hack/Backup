using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Xml_Default : System.Web.UI.Page
{
    string fileName = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        // WorkWithString();
       fileName = Server.MapPath("~/Xml/" + DateTime.Today.ToShortDateString().Replace("/", "") + ".xml");
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        //CreateXmlWriter();
        //return;
        StringBuilder sb = new StringBuilder();
        //using (StringWriter stringWriter = new StringWriter(sb))
        //{
            using (XmlTextWriter xtw = new XmlTextWriter(fileName, Encoding.Unicode))
            {
                xtw.Formatting = Formatting.Indented;
                xtw.WriteStartDocument();
                xtw.WriteStartElement("Medicine");
                xtw.WriteAttributeString("Manufacturer", "Cipla");
                xtw.WriteStartElement("Name");
                xtw.WriteString("Paracetamol");
                xtw.WriteEndElement();
                xtw.WriteStartElement("Dose");
                xtw.WriteString("2mg");
                xtw.WriteEndElement();
                xtw.WriteEndElement();
                xtw.WriteEndDocument();
            }
        // }
    }

    void CreateXmlWriter()
    {
        using (XmlWriter xtw = XmlWriter.Create(fileName))
        {
            xtw.WriteStartDocument();
            xtw.WriteStartElement("Medicine");
            xtw.WriteAttributeString("Manufacturer", "Cipla");
            xtw.WriteStartElement("Name");
            xtw.WriteString("l");
            xtw.WriteEndElement();
            xtw.WriteStartElement("Dose");
            xtw.WriteString("2mg");
            xtw.WriteEndElement();
            xtw.WriteEndElement();
            xtw.WriteEndDocument();
        }
    }

    protected void btnRead_Click(object sender, EventArgs e)
    {
        ReadUsingXmlTextReader();
        return;
        using (XmlReader reader = XmlReader.Create(fileName))
        {
            while (reader.Read())
            {
                if (reader.Name.Equals("Medicine", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (reader["Manufacturer"] != null)
                    {
                        Response.Write("Manufacturer : " + reader["Manufacturer"] + "<br />");
                    }
                }

                if (reader.Name.Equals("Name", StringComparison.CurrentCultureIgnoreCase))
                {
                    reader.Read();
                    Response.Write(reader.Value);
                }
            }
        }
    }

    private void ReadUsingXmlTextReader()
    {
        using (XmlReader reader = XmlTextReader.Create(fileName))
        {
            // follow the same pattern as above
            while (reader.Read())
            {
                if (reader.Name.Equals("Medicine", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (reader["Manufacturer"] != null)
                    {
                        Response.Write("Manufacturer : " + reader["Manufacturer"] + "<br />");
                    }
                }

                if (reader.Name.Equals("Name", StringComparison.CurrentCultureIgnoreCase))
                {
                    reader.Read();
                    Response.Write(reader.Value);
                }
            }
        }
    }

    private void WorkWithString()
    {
        string myString = string.Empty;
        for (int i = 0; i < 1000; i++)
        {
            // myString += " This is " + i + "<br />";
            myString = myString + " This is " + i + "<br />";
        }
        Response.Write(myString);

        Response.Write("<hr />");

        StringBuilder strB = new StringBuilder(1000);
        for (int i = 0; i < 1000; i++)
        {
            strB.Append(" This is " + i + "<br />");
        }

        Response.Write(strB.ToString());
    }
}