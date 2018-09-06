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
using System.IO;
using System.Xml.Serialization;

namespace ShippingProject
{
    
    /// <summary>
    /// Class: A main form for managaing package shipping orders.
    /// Developers: Kalin Bowden,
    /// Date: 12.12.2016.
    /// Purpose: To allow the use to ship packages using diffrent carries and methods, and to maintain and create an invoice.
    /// </summary>
    public partial class PackageForm : Form
    {
        // Creat an array list to hold 
        ArrayList packageList = new ArrayList();
        ArrayList submitted = new ArrayList();
        Package myPackage;
        ServiceReference1.WebServiceSoapClient client = new ServiceReference1.WebServiceSoapClient();
        int perc, hour, min, sec, ms = 0;

        /// <summary>
        /// Get or set the package list.
        /// </summary>
        public ArrayList PackageList
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
        /// Get or set the submitted.
        /// </summary>
        public ArrayList Submitted
        {
            get
            {
                return submitted;
            }

            set
            {
                submitted = value;
            }
        }

        public PackageForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Add a package to the lsit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        /// <summary>
        /// Remove a package from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        /// <summary>
        /// Launch the add package form and hide the main form.
        /// </summary>
        public void LaunchAddPackage()
        {
            AddPackageForm subForm = new AddPackageForm(packageList);
            this.Hide();
            subForm.ShowDialog();
            this.Show();
        }


        /// <summary>
        /// Manage the loading bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //set timer to ToString()
            //lbltimer.Text = hour + "h:" + min + "m:" + sec.ToString() + "s"; for testing
            ms++;
            perc++;
            lblPerc.Text = perc + "/100";
            bar.Increment(1);


            if(perc == 101)//change back to 101 after debugging
            {
                timer1.Stop();
                resetClock();
                bar.Visible = false;
                lblLoadBar.Visible = false;
                lblPerc.Visible = false;
                bar.Value = 0;
                perc = 0;
                LaunchAddPackage();
                packageList.Clear();
                lstInvoice.Items.Clear();
                
            }

            if (ms > 15)
            {
                sec++;
                ms = 0;
            }
            else
            {
                ms++;
            }
            if (sec > 59)
            {
                min++;
                sec = 0;
            }

            if (min > 59)
            {
                hour++;
                min = 0;
            }

        }

        /// <summary>
        /// View all the days packages.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < submitted.Count; i++)
            {
                lstInvoice.Items.Add(submitted[i]).ToString();
            }
        }

        /// <summary>
        /// Clear the invoices in the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstInvoice.Items.Clear();
        }

        /// <summary>
        /// View all the invoices.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnViewAll_Click(object sender, EventArgs e)
        {
            Package.InserLog((Package)packageList[0]);
        }

        /// <summary>
        /// Close the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Remove the selceted item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        /// <summary>
        /// Submitted packages to be shipped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Submit();
        }

        
        /// <summary>
        /// Add the package to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        /// <summary>
        /// Submit the packages to be shipped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }
        
        /// <summary>
        /// Reset timer
        /// </summary>
        public void resetClock()
        {
            hour = 0;
            min = 0;
            sec = 0;
            ms = 0;
        }

        /// <summary>
        /// Check for proper input.
        /// </summary>
        public void CheckInput()
        {
            // Checking shipping details.
            if (cmbBxCompany.Text == "Choose Shipper")
            {
                DisplayFieldError();
                lblShipAst.Visible = true;
            }
            else
            {
                lblShipAst.Visible = false;
            }
        }

        /// <summary>
        /// Display an error if there is a missing field.
        /// </summary>
        public void DisplayFieldError()
        {
            MessageBox.Show("All fields must be filled to ship a package.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Retrive packages from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retrieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PullPackageList();
        }

        /// <summary>
        /// Add the package to the list.
        /// </summary>
        public void Add()
        {
            // Method level variales.
            TextBox[] boxArray = { txtWeight, txtSenderZip, txtRecipAddress, txtRecipCity, txtRecipName, txtRecipState, txtRecipZip, txtSenderAddress, txtSenderCity, txtSenderName, txtSenderState };
            Label[] labelArray = { lblWeightAst, lblSendZipAst, lblRecAddAst, lblRecCityAst, lblRecNameAst, lblRecStateAst, lblRecZipAst, lblSendAddAst, lblSendCityAst, lblSendNameAst, lblSendStateAst };
            bool cont = true;
            
            //
            for(int i = 0; i < boxArray.Length; i++)
            {
                if(boxArray[i].Text == "")
                {
                    labelArray[i].Visible = true;
                    cont = false;
                }
                else
                {
                    labelArray[i].Visible = false;
                }
            }

            if(cont == false)
            {
                MessageBox.Show("The fields with astericks need to be filled to continue", "Field Required", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    //
                    
                    CheckInput();

                    if (radStanderd.Checked)
                    {

                        //MessageBox.Show("Standard Selected", "Works", MessageBoxButtons.OK);

                        // Create shipping object.
                        myPackage = new Package();

                        // Set sender information.
                        myPackage.SenderName = txtSenderName.Text;
                        myPackage.SenderAddress = txtSenderAddress.Text;
                        myPackage.SenderCity = txtSenderCity.Text;
                        myPackage.SenderState = txtSenderState.Text;
                        myPackage.SenderZipCode = int.Parse(txtSenderZip.Text);

                        // Set recipiant information.
                        myPackage.RecipientName = txtRecipName.Text;
                        myPackage.RecipientAddress = txtRecipAddress.Text;
                        myPackage.RecipientCity = txtRecipCity.Text;
                        myPackage.RecipientState = txtRecipState.Text;
                        myPackage.RecipientZipCode = int.Parse(txtRecipZip.Text);

                        // Calculate cost.
                        myPackage.Weight = decimal.Parse(txtWeight.Text);
                        myPackage.CostPerOunce = myPackage.CalculateCost();

                        // Add the shipping comapny.
                        if (cmbBxCompany.Text == "UPS")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }
                        else if (cmbBxCompany.Text == "FEDEX")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }
                        else if (cmbBxCompany.Text == "USPS")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }

                    }
                    else if (radTwoDay.Checked)
                    {

                        // Create shipping object.
                        Package myPackage = new TwoDayPackage();

                        // Set sender information.
                        myPackage.SenderName = txtSenderName.Text;
                        myPackage.SenderAddress = txtSenderAddress.Text;
                        myPackage.SenderCity = txtSenderCity.Text;
                        myPackage.SenderState = txtSenderState.Text;
                        myPackage.SenderZipCode = int.Parse(txtSenderZip.Text);

                        // Set recipiant information.
                        myPackage.RecipientName = txtRecipName.Text;
                        myPackage.RecipientAddress = txtRecipAddress.Text;
                        myPackage.RecipientCity = txtRecipCity.Text;
                        myPackage.RecipientState = txtRecipState.Text;
                        myPackage.RecipientZipCode = int.Parse(txtRecipZip.Text);

                        // Calculate cost.
                        myPackage.Weight = decimal.Parse(txtWeight.Text);
                        myPackage.CostPerOunce = myPackage.CalculateCost();

                        //
                        // Set the shipping comapany.
                        if (cmbBxCompany.Text == "UPS")
                        {
                            // 
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }
                        else if (cmbBxCompany.Text == "FEDEX")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }
                        else if (cmbBxCompany.Text == "USPS")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }

                    }
                    else if (radOvernight.Checked)
                    {

                        // Create shipping object.
                        Package myPackage = new OvernightPackage();

                        // Set sender information.
                        myPackage.SenderName = txtSenderName.Text;
                        myPackage.SenderAddress = txtSenderAddress.Text;
                        myPackage.SenderCity = txtSenderCity.Text;
                        myPackage.SenderState = txtSenderState.Text;
                        myPackage.SenderZipCode = int.Parse(txtSenderZip.Text);


                        // Set recipiant information.
                        myPackage.RecipientName = txtRecipName.Text;
                        myPackage.RecipientAddress = txtRecipAddress.Text;
                        myPackage.RecipientCity = txtRecipCity.Text;
                        myPackage.RecipientState = txtRecipState.Text;
                        myPackage.RecipientZipCode = int.Parse(txtRecipZip.Text);

                        // Calculate cost.
                        myPackage.Weight = decimal.Parse(txtWeight.Text);
                        myPackage.CostPerOunce = myPackage.CalculateCost();

                        //
                        if (cmbBxCompany.Text == "UPS")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }
                        else if (cmbBxCompany.Text == "FEDEX")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }
                        else if (cmbBxCompany.Text == "USPS")
                        {
                            myPackage.ShippingCompany = cmbBxCompany.Text;
                            lstInvoice.Items.Add(myPackage.ToString());
                            PackageList.Add(myPackage);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please select a delivery type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (FormatException exc)
                {
                    MessageBox.Show("No Weight Entered. Please Enter a Weight and Try Again." + "\n\n" + exc, "Error", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Remove the package from the list
        /// </summary>
        public void Remove()
        {
            try
            {
                packageList.RemoveAt(lstInvoice.SelectedIndex);
                lstInvoice.Items.Remove(lstInvoice.SelectedItem);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Select an Item to Remove", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// submit the packages to be shippend.
        /// </summary>
        public void Submit()
        {
            Package.InserLog((Package)packageList[0]);

            for (int i = 0; i < packageList.Count; i++)
            {
                submitted.Add(packageList[i]);
            }

            // Display the laoding bar.
            bar.Visible = true;
            lblLoadBar.Visible = true;
            lblPerc.Visible = true;
            bar.BringToFront();
            lblLoadBar.BringToFront();
            lblPerc.BringToFront();
            

            timer1.Start();
            //SaveXML.SaveData(Submitted, "TodaysInvoices.xml");
        }

        /// <summary>
        /// Pull the package lsit fro mthe database.
        /// </summary>
        public void PullPackageList()
        {
            // Method level variables.
            string[] serArray = Package.CreatePackageList();

            // Cycle throught and add the packages.
            for (int index = 0; index < serArray.Length; index++)
            {
                // Deserialize.
                if (serArray[index] != "" && serArray != null)
                {
                    Package newPackage = Package.DeserializePackage(serArray[index]);
                    MessageBox.Show(newPackage.ToString());
                }
            }
        }
    }// End of Class.
}// End of Solution.
