using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ShippingProject
{
    /// <summary>
    /// Class: a for printing Invoices and package labels.
    /// Developer: Kalin Bowden.
    /// Date: 12.12.2016.
    /// </summary>
    public partial class AddPackageForm : Form
    {
        // Class level varaibles.
        ArrayList packageList;
        decimal totalCost = 0m;
        const decimal TAX = .076m;
        decimal finalTotal = 0m;
        string lables;
        int printType;

        /// <summary>
        /// Set the class level objects when the form loads.
        /// </summary>
        /// <param name="inArray"></param>
        public AddPackageForm(ArrayList inArray)
        {
            InitializeComponent();
            packageList = new ArrayList();
            packageList = inArray;

            SetInvoice();
        }

        /// <summary>
        /// Get or set the pakage list array list.
        /// </summary>
        public ArrayList Packagelist
        {
            get
            {
                return packageList;
            }

            set
            {
                packageList = value;
            }
        }

        /// <summary>
        /// TODO: Determine if this event needs removed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TODO.  
        }

        /// <summary>
        /// Set the invice up to contain all the information of the users packages.
        /// </summary>
        public void SetInvoice()
        {
            // Method level varaibels.
            string temp = "";

            // For each package in the array list: Add it to the invoice
            for (int index = 0; index < packageList.Count; index++)
            {
                txtInvoice.Text += ReturnPackage((Package)packageList[index], index + 1);

            }

            // Set the tax, subtotal, and total cost to the invoice.
            finalTotal = totalCost + Math.Round(TAX * totalCost,2);
            txtInvoice.Text += "\r\ncost: $" + Math.Round(totalCost,2);
            txtInvoice.Text +="\r\nTAX: " + Math.Round(TAX*100,1) + "%";
            txtInvoice.Text += "\r\nTotal Cost: $" + Math.Round(finalTotal,2);
            temp += txtInvoice.Text;
        }

        /// <summary>
        /// Set a single package to a formated string.
        /// NOTE: keeps a tally of the total of all packages that are created by htis method.
        /// </summary>
        /// <param name="thisPackage"></param>
        /// <returns></returns>
        public string ReturnPackage(Package thisPackage, int index)
        {
            // Method level varaible
            string temp = "Item: "+index+"\tWeight: "+thisPackage.Weight+"\tCost: $";

            // Format the string.
            temp += thisPackage.CalculateCost() + "\r\n";

            // Tally total cost.
            totalCost += thisPackage.CalculateCost();

            // Return the formatted string.
            return temp;
        }

        /// <summary>
        /// When this eve nt fires it will print the invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            // TODO.
            printType = 0;
            printDialog1.Document = printDocument1;

            // IF the user clicks OK print the invoice.
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        /// <summary>
        /// When this event fires it will print the select file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Determine if the user wanted to print an invoice or lables.
            if (printType == 0)
            {
                e.Graphics.DrawString(txtInvoice.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 75, 50);
            }
            else if (printType == 1)
            {
                e.Graphics.DrawString(lables, new Font("Lucida Console", 12, FontStyle.Bold), Brushes.Black, 75, 50);
            }
            
        }

        /// <summary>
        /// When this event fires print the users lables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Event level varialbe.
            printType = 1;

            // Add all of the users lables to the string.
            for (int index = 0; index < packageList.Count; index++)
            {
                lables += CreateLable((Package)packageList[index]);
            }

            // TODO
            printDialog1.Document = printDocument1;

            // If the user clicks OK printthe labels.
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        /// <summary>
        /// Format the label to be printed.
        /// </summary>
        /// <param name="myPackage"></param>
        /// <returns></returns>
        public string CreateLable(Package myPackage)
        {
            // Method levle varaible.
            string temp = "";


            // Format hte label
            temp = string.Format ( "" +
                "*****************************************************\r\n" +
                "                                                     \r\n" +
                " From: {0,-90}*\r\n" +
                " Street: {1,-82}*\r\n" +
                " City: {2,-20}State: {3,-5}Zip: {4,-15}\r\n" +
                "-----------------------------------------------------\r\n", myPackage.SenderName, myPackage.SenderAddress,myPackage.SenderCity, myPackage.SenderState, myPackage.SenderZipCode );
            temp += string.Format("" +
                "                                                    \r\n" +
                " To: {0,-98}\r\n" +
                " Street: {1,-82}\r\n" +
                " City: {2,-20}State: {3,-5}Zip: {4,-15}\r\n" +
                "****************************************************\r\n", myPackage.RecipientName, myPackage.RecipientAddress, myPackage.RecipientCity, myPackage.RecipientState, myPackage.RecipientZipCode);

            // TODO: Romove after testing.
            MessageBox.Show(temp);

            // Return the formted label string.
            return temp;
        }

        /// <summary>
        /// When this event fires it will cancel the the inoive and bring the user back to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }// End of Class.
}// End of solution.
