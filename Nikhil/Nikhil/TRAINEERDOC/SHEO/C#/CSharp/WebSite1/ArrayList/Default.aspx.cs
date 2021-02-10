using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

public partial class ArrayList_Default : System.Web.UI.Page
{

    /// <summary>
    ///  basic collection
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        var myclassEnumerator = new Myclass().GetEnumerator();

        ArrayList alist = new ArrayList();
        alist.Add(1);
        alist.Add("two");
        alist.Add(DateTime.Now);

        
        // 
        List<string> list = new List<string>();
        list.Add("fasdf");

    }

    public class Myclass : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class MyClass1 : IEnumerator
    {
        public object Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}