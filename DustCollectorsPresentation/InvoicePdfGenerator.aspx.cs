/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;
 using System.Web;
 using iTextSharp.text;
 using iTextSharp.text.pdf;
 using System.Web.UI.WebControls;

namespace DustCollectorsPresentation
{

public static class InvoicePdfGenerator
    {
        public static void Generate(HttpResponse response, InvoiceDTO invoice, UserDTO user, List<InvoiceItemDTO> items)
        {
            response.ContentType = "application/pdf";
            response.AddHeader("content-disposition", $"attachment;filename=Invoice_{invoice.InvoiceID}.pdf");
            response.Cache.SetCacheability(HttpCacheability.NoCache);

            using (var ms = new System.IO.MemoryStream())
            {
                var doc = new Document();
                PdfWriter.GetInstance(doc, ms);
                doc.Open();

                // Header
                doc.Add(new Paragraph("INVOICE"));
                doc.Add(new Paragraph($"Invoice ID: {invoice.InvoiceID}"));
                doc.Add(new Paragraph($"Date: {invoice.InvoiceDate:dd/MM/yyyy}"));
                doc.Add(new Paragraph($"Status: {invoice.Status}"));
                doc.Add(new Paragraph(" "));

                // User details
                doc.Add(new Paragraph("Customer Details:"));
                doc.Add(new Paragraph($"{user.FullName}"));
                doc.Add(new Paragraph($"{user.Email}"));
                doc.Add(new Paragraph($"{user.Address}"));
                doc.Add(new Paragraph(" "));

                // Items
                if (items != null && items.Count > 0)
                {
                    var table = new PdfPTable(3);
                    table.AddCell("Product");
                    table.AddCell("Quantity");
                    table.AddCell("Price");

                    foreach (var item in items)
                    {
                        table.AddCell(item.ProductName);
                        table.AddCell(item.Quantity.ToString());
                        table.AddCell("R " + item.TotalPrice.ToString("F2"));
                    }

                    doc.Add(table);
                }

                // Totals
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Subtotal: R {invoice.Subtotal:F2}"));
                doc.Add(new Paragraph($"VAT: R {invoice.VAT:F2}"));
                doc.Add(new Paragraph($"Delivery Fee: R {invoice.DeliveryFee:F2}"));
                doc.Add(new Paragraph($"Grand Total: R {invoice.TotalAmount:F2}"));

                doc.Close();

                response.BinaryWrite(ms.ToArray());
                response.End();
            }
        }
    }
}
}*/