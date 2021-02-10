using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Xml_dSEt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string xmlFile = Server.MapPath("~/Xml/MyData.xml");
        DataSet dSet = new DataSet();
        dSet.ReadXml(xmlFile);

        DataTable table = dSet.Tables[0];
        DataView view = new DataView(table);
        view.RowFilter = "CategoryId > 2";

        string writePath = Server.MapPath("~/Xml/MyDataWRite.xml");
        table.WriteXml(writePath);

        GridView1.DataSource = view;
        GridView1.DataBind();

    }
}