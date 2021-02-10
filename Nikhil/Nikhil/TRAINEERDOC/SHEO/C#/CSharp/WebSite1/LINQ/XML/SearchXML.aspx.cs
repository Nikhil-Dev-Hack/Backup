using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class XML_ReadXML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SearchXMLFile(object sender, EventArgs e)
    {
        string fileName = Server.MapPath( "~/LINQ/XML/" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xml");
        XDocument doc = XDocument.Load(fileName);

        //var customers = from cust in doc.Descendants("Customer")
        //                where cust.Attribute("FirstName").Value.Contains("Jay")
        //                select cust;

        var customers = from cust in doc.Descendants("Customer")
                        where cust.Attribute("FirstName").Value.Contains("Jay")
                        select new
                        {
                            FirstName = (string)cust.Attribute("FirstName"),
                            LastName = (string)cust.Attribute("LastName"),
                            Age = (string)cust.Attribute("Age"),
                        };

        foreach (var c in customers)
        {
            Response.Write(c.FirstName + " " + c.LastName + " : " + c.Age + "<br />");
        }

        #region Sample XMl
//        <?xml version="1.0" encoding="utf-8"?>
//<Customers>
//    <Customer FirstName="Ram" LastName="Dev" Age="45">
//        <AutoId>1</AutoId>    
//    </Customer>
//    <Customer FirstName="Jay" LastName="Shankarji" Age="30">
//        <AutoId>2</AutoId>
//    </Customer>
//    <Customer FirstName="Jayesh" LastName="Makhi" Age="25">
//        <AutoId>3</AutoId>
//    </Customer>
//    <Customer FirstName="Ramesh" LastName="Lakhani" Age="30">
//        <AutoId>4</AutoId>
//    </Customer>
//</Customers>
        #endregion 

        //var custms = from cust in doc.Descendants("Customer")
        //             where cust.Element("AutoId").Value.Equals("1")
        //             select cust;
        
        GridView gv = new GridView();
        gv.DataSource = customers;
        gv.DataBind();

        this.Page.Form.Controls.Add(gv);

    }
}