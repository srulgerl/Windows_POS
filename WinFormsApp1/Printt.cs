using posLibrary;
using System.Drawing.Printing;

namespace WinFormsApp1
{
    public class MyPrint
    {
        private List<Order> _ordersToPrint;
        private User user;
        private decimal paidAmount;
        private long transactionId;
        public MyPrint(List<Order> orders, User user, long transactionId, decimal paidAmount)
        {
            _ordersToPrint = orders;
            this.user = user;
            this.transactionId = transactionId;
            this.paidAmount = paidAmount;
        }

        public void PrintReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.PrinterSettings = printDialog.PrinterSettings;
                    printDocument.Print();
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font regularFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeight = regularFont.GetHeight();
            float x = 50;
            float y = 50;
            float pageWidth = e.PageBounds.Width - 100;

            // --- Header ---
            g.DrawString("Иргэнд очих баримт", titleFont, Brushes.Black, x, y);
            y += lineHeight + 5;
            g.DrawLine(Pens.Black, x, y, x + pageWidth, y);
            y += 5;

            g.DrawString($"Огноо: {DateTime.Now:yyyy/MM/dd HH:mm:ss}", regularFont, Brushes.Black, x, y);
            y += lineHeight + 2;

            g.DrawString($"Кассчин: {user.userName}", regularFont, Brushes.Black, x, y);
            y += lineHeight + 2;

            g.DrawString($"Баримтын дугаар: {transactionId}", regularFont, Brushes.Black, x, y);
            y += lineHeight;


            // --- Divider Line ---
            g.DrawLine(Pens.Black, x, y, x + pageWidth, y);
            y += 10;

            // --- Column Headers ---
            float col1 = x;       // ID
            float col2 = x + 50;  // Product
            float col3 = x + 250; // Quantity
            float col4 = x + 300; // Price
            float col5 = x + 400; // Total

            g.DrawString("ID", boldFont, Brushes.Black, col1, y);
            g.DrawString("Бараа", boldFont, Brushes.Black, col2, y);
            g.DrawString("Тоо", boldFont, Brushes.Black, col3, y);
            g.DrawString("Нэгж үнэ", boldFont, Brushes.Black, col4, y);
            g.DrawString("Дүн", boldFont, Brushes.Black, col5, y);
            y += lineHeight + 5;

            // --- Order Details ---
            foreach (var order in _ordersToPrint)
            {
                string productName = order.ProductName.Length > 20
                    ? order.ProductName.Substring(0, 17) + "..."
                    : order.ProductName;

                g.DrawString(order.ProductId.ToString(), regularFont, Brushes.Black, col1, y);
                g.DrawString(productName, regularFont, Brushes.Black, col2, y);
                g.DrawString(order.Quantity.ToString(), regularFont, Brushes.Black, col3, y);
                g.DrawString("$"+order.UnitPrice.ToString("F2"), regularFont, Brushes.Black, col4, y);
                g.DrawString("$" + order.TotalPrice.ToString("F2"), regularFont, Brushes.Black, col5, y);
                y += lineHeight;
            }

            y += 5;
            g.DrawLine(Pens.Black, x, y, x + pageWidth, y);

            y += 10;

            decimal subtotal = _ordersToPrint.Sum(o => o.TotalPrice);
            decimal change = paidAmount - subtotal;

            g.DrawString($"Нийт дүн: ${subtotal:F2}", boldFont, Brushes.Black, col5, y);
            y += lineHeight;
            g.DrawString($"Төлсөн: ${paidAmount:F2}", regularFont, Brushes.Black, col5, y);
            y += lineHeight;
            g.DrawString($"Хариулт: ${change:F2}", regularFont, Brushes.Black, col5, y);

            regularFont.Dispose();
            boldFont.Dispose();
            titleFont.Dispose();
        }
    }
}
