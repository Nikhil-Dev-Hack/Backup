using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using Syncfusion.Pdf.Grid;
using DevDevil.Models;
using System.Data;

namespace DevDevil.Controllers
{
    public class PdfGeneratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CreateDocument()
        {

            PdfDocument doc = new PdfDocument();
            //Add a page to the document.
            PdfPage page = doc.Pages.Add();
            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;
            PdfGrid pdfGrid = new PdfGrid();
            FileStream imageStream = new FileStream("logo.png", FileMode.Open, FileAccess.Read);
            PdfBitmap image = new PdfBitmap(imageStream);
            //Draw the image
            graphics.DrawImage(image, 0, 0);
            DataSet data = new DataSet();
            List<Order> orders = new List<Order>();
            //foreach (DataTable table in data.Tables)
            //{
            //    foreach (Datarow row in table.Rows)
            //    {
            //        Order order = new Order()
            //        {
            //            OrderId = int.Parse(row["OrderId"].ToString()),
            //            FirstName = row["FirstName"].ToString(),
            //            LastName = row["LastName"].ToString(),
            //            AddressLine1 = row["AddressLine1"].ToString(),
            //            ZipCode = row["ZipCode"].ToString(),
            //            PhoneNumber = row["PhoneNumber"].ToString(),
            //            OrderPlaced = DateTime.Parse(row["OrderDetails"].ToString()),
            //            OrderTotal = decimal.Parse(row["OrderTotal"].ToString())
            //        };
            //        orders.Add(order);
            //    }
                
            //}

            //IEnumerable<Object> datatable = orders;
            //pdfGrid.DataSource = datatable;
            //pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));
            //Save the PDF document to stream
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            //If the position is not set to '0' then the PDF will be empty.
            stream.Position = 0;
            //Close the document.
            doc.Close(true);
            //Defining the ContentType for pdf file.
            string contentType = "application/pdf";
            //Define the file name.
            string fileName = "Output.pdf";
            //Creates a FileContentResult object by using the file contents, content type, and file name.
            return File(stream, contentType, fileName);

        }
    }
}
