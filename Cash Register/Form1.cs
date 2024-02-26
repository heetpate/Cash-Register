using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace Cash_Register
{
    public partial class cashRegister : Form
    {
        double phone = 1259.00;
        double vr = 3200.00;
        double laptop = 1600.00;

        int phonePrice;
        int vrPrice;
        int laptopPrice;

        double subtotal;
        double taxRate = 0.13;
        double total;
        double totalAmount;

        double moneytendered = 0;
        double tendered;
        double change;
        
        
        
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
                phonePrice = Convert.ToInt32(phoneInput.Text);
                vrPrice = Convert.ToInt32(vrInput.Text);
                laptopPrice = Convert.ToInt32(laptopInput.Text);
              
               // subtotal = Convert.ToInt32(subTotalOutput.Text);
                //taxRate = Convert.ToInt32(taxOutput.Text);
               // total = Convert.ToInt32(totalOutput.Text);
               // tendered = Convert.ToInt32(tenderedInput.Text);


                subtotal = (phone * phonePrice) + (vr * vrPrice) + (laptop * laptopPrice);
                subTotalOutput.Text = $"{subtotal.ToString("C")}";

                totalAmount = (subtotal * taxRate);
                taxOutput.Text = $"{totalAmount.ToString("C")}";

                total = (subtotal + totalAmount);
                totalOutput.Text = $"{total.ToString("C")}";

                tendered = Convert.ToInt32(tenderedInput.Text);
               // tendered = (totalOutput - tenderedInput);


                change = (total - tendered);
                changeOutput.Text = $"{change.ToString("C")}";

                calculateChange.Enabled = true;
                printReceiptButton.Enabled = true;
                reOrder.Enabled = true; 


            }
            catch
            {
                subTotalOutput.Text = "Invalid output, try again";
                taxOutput.Text = "Invalid output, try again";
                subTotalOutput.Text = "Invalid output, try again";
                totalOutput.Text = "Invalid output, try again";


            }

        }

        private void tenderedInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void receiptPrinter_Click(object sender, EventArgs e)
        {
            receiptPrinter.Text += $"\n\n Tech Shop Inc";
            receiptPrinter.Text += $"\n\n Feb 22, 2024";
            // receiptPrinter.Text +=$"\n\n "


            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Sub Total:            {subtotal.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Tax Amount:           {taxRate.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Total:                {total.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Tendered:             {tendered.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Change:               {change.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Have a Nice Day:)";



        }

        private void reOrder_Click(object sender, EventArgs e)
        {
            vrInput.Clear();
            phoneInput.Clear();
            laptopInput.Clear();

            subTotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            
            tenderedInput.Clear();
            changeOutput.Text = "";

            //cashRegister.Text = "";

            calculateChange.Enabled = false; 
            printReceiptButton.Enabled = false;
            reOrder.Enabled = false;
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
