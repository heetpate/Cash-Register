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

        double phonePrice;
        double vrPrice;
        double laptopPrice;

        double subtotal;
        double taxRate = 0.13;
        double total;
        double totalAmount;

        double tendered;
        double change;

        double phoneTotal;
        double vrTotal;
        double laptopTotal;





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
                phoneTotal = Convert.ToDouble(phoneInput.Text);
                vrTotal = Convert.ToDouble(vrInput.Text);
                laptopTotal = Convert.ToDouble(laptopInput.Text);

                subtotal = (phone * phoneTotal) + (vr * vrTotal) + (laptop * laptopTotal);
                subTotalOutput.Text = subtotal.ToString("C");

                totalAmount = (subtotal * taxRate);
                taxOutput.Text = totalAmount.ToString("C");

                total = (subtotal + totalAmount);
                totalOutput.Text = total.ToString("C");

              


           

                calculateChange.Enabled = true;
                printReceiptButton.Enabled = true;
                reOrder.Enabled = true;


            }
            catch
            {
                subTotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                subTotalOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";


            }

        }

        private void tenderedInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiptPrinter_Click(object sender, EventArgs e)
        {
           




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

            subtotal = 0;
            taxRate = 0;
            total = 0;
            //phoneTotal = 0;
            //vrTotal = 0;
            //laptopTotal = 0;
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            receiptPrinter.Text += $"Tech Shop Inc";
            receiptPrinter.Text += $"\n\n Feb 22, 2024";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\nOrder Number: 24";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\nPhone x{phonePrice}  @ {phone.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\nVR x{vrPrice}   @ {vr.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\nLaptop x{laptopPrice}   @         {laptop.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Sub Total:                     {subtotal.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Tax Amount:                    {taxRate.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Total:                         {total.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Tendered:                      {tendered.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Change:                        {change.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Have a Nice Day:)";

        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
            }

            catch
            {
                printReceiptButton.Enabled = false;
            }

            change = tendered - total;
            changeOutput.Text = $"{change.ToString("C")}";

            if (tendered < total)

            {
                changeOutput.Text = $"{tendered} is not enough";
                
                printReceiptButton.Enabled = false;
            }

            else if (tendered > total)
            {
                changeOutput.Text = $"{change.ToString("C")}";


                printReceiptButton.Enabled = true;

            }
        }
    }
}
