using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class cashRegister : Form
    {
        double phone = 1259.00;
        double VR = 3200.00;
        double laptop = 1600.00;
        public cashRegister()
        {
            InitializeComponent();
        }

        private void cashRegister_Load(object sender, EventArgs e)
        {

        }

        private void tenderedLabel_Click(object sender, EventArgs e)
        {

        }

        private void caculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                phone = Convert.ToInt32(slicesInput.Text);

                subtotal = slicesPrice * numOfSlices;
                double taxAmount = subtotal * taxRate;
                double totalPrice = subtotal + taxAmount;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"${taxAmount.ToString(".00")}";
                totalPriceOutput.Text = $"${totalPrice.ToString(".00")}";
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                subtotalOutput.Text = "ERROR";
                totalPriceOutput.Text = "ERROR";


            }

        }
        }
    }
}
