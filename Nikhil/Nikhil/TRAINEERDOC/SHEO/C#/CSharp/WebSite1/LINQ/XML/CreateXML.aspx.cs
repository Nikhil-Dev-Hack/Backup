using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


public partial class XML_CreateXML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CreateXMLFile(object sender, EventArgs e)
    {
        XDocument doc = new XDocument();

        XElement root = new XElement("Customers");
        
        // add first customer
        XElement child = new XElement("Customer");
        XAttribute attr = new XAttribute("FirstName", "Ram");
        child.Add(attr);

        attr = new XAttribute("LastName", "Dev");
        child.Add(attr);

        attr = new XAttribute("Age", 45);
        child.Add(attr);

        root.Add(child);

        // add seccond customer
        child = new XElement("Customer");
        attr = new XAttribute("FirstName", "Jay");
        child.Add(attr);
        attr = new XAttribute("LastName", "Shankarji");
        child.Add(attr);
        attr = new XAttribute("Age", 30);
        child.Add(attr);
        root.Add(child);

        // add third customer
        child = new XElement("Customer");
        attr = new XAttribute("FirstName", "Jayesh");
        child.Add(attr);
        attr = new XAttribute("LastName", "Makhi");
        child.Add(attr);
        attr = new XAttribute("Age", 25);
        child.Add(attr);
        root.Add(child);

        // add forth customer
        child = new XElement("Customer");
        attr = new XAttribute("FirstName", "Ramesh");
        child.Add(attr);
        attr = new XAttribute("LastName", "Lakhani");
        child.Add(attr);
        attr = new XAttribute("Age", 30);
        child.Add(attr);
        root.Add(child);

        doc.Add(root);

        string fileName = Server.MapPath( "~/LINQ/XML/" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xml");
        doc.Save(fileName);

        lblMessage.Text = "XML file written successfully !";
    }
    
}