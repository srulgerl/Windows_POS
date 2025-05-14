using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos;
using posLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp1
{
    public partial class OrderItem : UserControl
    {
        public CartItem item;

        public event EventHandler QuantityChanged;

        public OrderItem()
        {
            InitializeComponent();
        }

        public OrderItem(CartItem item)
        {
            InitializeComponent();
            SetCartItems(item);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            item.DecreaseQuantity();
            if (item.Quantity == 0)
            {
                this.Parent.Controls.Remove(this);
            }
            else
            {
                QtyLbl.Text = item.Quantity.ToString();
                totalLbl.Text = "$" + item.TotalPrice.ToString("F2");

            }
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            item.IncreaseQuantity();
            QtyLbl.Text = item.Quantity.ToString();
            totalLbl.Text = "$" + item.TotalPrice.ToString("F2");
            QuantityChanged?.Invoke(this, EventArgs.Empty);

        }

        public void SetCartItems(CartItem cartItem)
        {
            item = cartItem;
            productNameLbl.Text = cartItem.Product.ProductName;
            QtyLbl.Text = item.Quantity.ToString();
            unitPriceLbl.Text = "$" + item.Product.ProductPrice.ToString("F2");
            discountLbl.Text = item.Product.ProductDiscount.ToString();
            totalLbl.Text = "$" + item.TotalPrice.ToString("F2");

        }

      
    }
}
