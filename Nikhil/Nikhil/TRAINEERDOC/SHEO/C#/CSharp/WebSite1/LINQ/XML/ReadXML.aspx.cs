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

    protected void ReadXMLFile(object sender, EventArgs e)
    {
        string fileName = Server.MapPath( "~/LINQ/XML/" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".xml");
        XDocument doc = XDocument.Load(fileName);

        var customers = from cust in doc.Descendants("Customer")
                        select cust;

        GridView gv = new GridView();
        gv.DataSource = customers;
        gv.DataBind();

        this.Page.Form.Controls.Add(gv);

    }
}