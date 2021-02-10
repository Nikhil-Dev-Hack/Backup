using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace ADONET
{
    public class DataTableDemo
    {

        public void FillDataTable()
        {
            DataTable dTable = new DataTable("Dynamically_Generated");

            // create columns for the DataTable

            DataColumn auto = new DataColumn("AutoID", typeof(int));
            dTable.Columns.Add(auto);

            // create another column

            DataColumn name = new DataColumn("Name", typeof(string));
            dTable.Columns.Add(name);

            // create one more column
            DataColumn address = new DataColumn("Address", typeof(string));
            dTable.Columns.Add(address);

            DataRow row = null;

            for (int i = 0; i < 5; i++)
            {

                row = dTable.NewRow();
                row["AutoID"] = i + 1;
                row["Name"] = i + " - Ram";
                row["Address"] = "Ram Nagar, India - " + i;
                dTable.Rows.Add(row);
            }

            DataRow[] rows1 = dTable.Select(" AutoID > 3", "AutoID ASC");

            DataTable newDataTable = dTable.Clone();

            foreach (DataRow thisRow in rows1)
            {
                // add values into the datatable

                newDataTable.Rows.Add(thisRow.ItemArray);
            }


            // print the data
            for (var i = 0; i < newDataTable.Rows.Count; i++)
            {
                DataRow thisRow = dTable.Rows[i];
                Console.WriteLine(thisRow["AutoId"] + " " + thisRow["Name"] + " " + thisRow["Address"]);
            }

            Console.WriteLine("==================================");

            foreach(DataRow thisRow in dTable.Rows)
            {
                Console.WriteLine(thisRow["AutoId"] + " " + thisRow["Name"] + " " + thisRow["Address"]);
            }

        }

    }
}
