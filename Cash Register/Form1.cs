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
using System.Media;

///Heet Patel
///Feb 22, 2024
///Cash Register


namespace Cash_Register
{
    public partial class cashRegister : Form
    {
        //All the variables that are being used for this project cash register

        // This code indicate how much the three thing costs
        double phone = 1259.00;
        double vr = 3200.00;
        double laptop = 1600.00;

        // This variables are being converted into the inputs
        double phonePrice;
        double vrPrice;
        double laptopPrice;

        // This variables are the cost after buying 3 items
        double subtotal;
        double taxRate = 0.13;
        double total;
        double totalAmount;
        double tendered;
        double change;

        // This stores the calculation of item you bought and whats the cost it
        double phoneTotal;
        double vrTotal;
        double laptopTotal;

        // Sound player if anything goes wrong then error sound
        SoundPlayer errorSound = new SoundPlayer(Properties.Resources.error_Sound);
        SoundPlayer printSound = new SoundPlayer(Properties.Resources.print_Receipt_Sound); // Sound player for printing the receipt
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
            //try and catch if you user does something wrong
            try
            {
                phonePrice = Convert.ToDouble(phoneInput.Text);
                vrPrice = Convert.ToDouble(vrInput.Text);
                laptopPrice = Convert.ToDouble(laptopInput.Text);

                phoneTotal = phonePrice * phone;
                vrTotal = vrPrice * vr;
                laptopTotal = laptopPrice * laptop;
            }
            catch
            {
                subTotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                subTotalOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";
                errorSound.Play();
                calculateChange.Enabled = false;
                printReceiptButton.Enabled = false;
                reOrder.Enabled = false;
            }

            // the amount of total cost added
            subtotal = (phoneTotal + vrTotal + laptopTotal);
            subTotalOutput.Text = subtotal.ToString("C");

            // the total amound of subtotal and the tax
            totalAmount = (subtotal * taxRate);
            taxOutput.Text = totalAmount.ToString("C");

            // Adding all together the totalamound and subtotal
            total = (subtotal + totalAmount);
            totalOutput.Text = total.ToString("C");

            calculateChange.Enabled = true;
            printReceiptButton.Enabled = true;
            reOrder.Enabled = true;
        }

        private void tenderedInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiptPrinter_Click(object sender, EventArgs e)
        {
        }

        private void reOrder_Click(object sender, EventArgs e)
        {
            //clears everything so the user can Reorder it (no data is stored after that)
            vrInput.Clear();
            phoneInput.Clear();
            laptopInput.Clear();
            tenderedInput.Clear();
            receiptPrinter.ResetText();

            subTotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";

            calculateChange.Enabled = false;
            printReceiptButton.Enabled = false;
            reOrder.Enabled = false;

            subtotal = 0;
            taxRate = 0.13;
            total = 0;
            phoneTotal = 0;
            vrTotal = 0;
            laptopTotal = 0;
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            // The proccess after pressing the printReceipt button 
            printSound.PlayLooping();

            receiptPrinter.Text += $"Tech Shop Inc";
            receiptPrinter.Text += $"\n\n Feb 22, 2024";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Order Number: 24";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Phone    x{phonePrice}   @  {phone.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n VR       x{vrPrice}   @  {vr.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n Laptop   x{laptopPrice}   @  {laptop.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Subtotal:        {subtotal.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Tax Amount:      {taxRate.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Total:           {total.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Tendered:        {tendered.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Change:          {change.ToString("C")}";

            Thread.Sleep(500);
            Refresh();
            receiptPrinter.Text += $"\n\n Have a Nice Day:)";

            printSound.Stop();
            reOrder.Enabled = true;
        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            // try and catch for calculate change button so if the user doesn't give enough money then you can't buy the products
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                errorLabel.Text = "";
                errorSound.Stop();
            }
            catch
            {
                errorLabel.Text = "Please enter a valid amount";
                errorSound.Play();
                printReceiptButton.Enabled = false;    
            }

            change = tendered - total;
            changeOutput.Text = $"{change.ToString("C")}";

            if (tendered < total)
            {
                changeOutput.Text = $"{tendered} is not enough";
                errorSound.Play();
                printReceiptButton.Enabled = false;
            }
            else if (tendered > total)
            {
                changeOutput.Text = $"{change.ToString("C")}";
                errorSound.Stop();
                printReceiptButton.Enabled = true;
            }
        }
    }
}