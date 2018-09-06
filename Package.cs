using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingProject.ServiceReference1;

namespace ShippingProject
{/// <summary>
/// Project: Shipping Project
/// Date Created: 11/21/2016
/// Authors: Kalin Bowden, Kenneth Bee, Jarret Stewart
/// </summary>
    [Serializable]
    public class Package : IPayable
    {
        // Class level variables.
        private string recipientState;
        private int senderZipCode;
        private int recipientZipCode;
        private decimal costPerOunce = 0.25m;
        private string senderName;
        private string senderAddress;
        private string senderCity;
        private string senderState;
        private string recipientName;
        private string recipientAddress;
        private string recipientCity;
        private decimal weight;
        private string shippingCompany;
        [NonSerialized]
        ServiceReference1.WebServiceSoapClient client = new ServiceReference1.WebServiceSoapClient();
        
        /// <summary>
        /// Default Constructor: No arg.
        /// </summary>
        public Package()
        {

        }

        /// <summary>
        /// Get or set the senders name.
        /// </summary>
        public string SenderName
        {
            get
            {
                return senderName;
            }

            set
            {
                senderName = value;
            }
        }

        /// <summary>
        /// Get or set the senders address.
        /// </summary>
        public string SenderAddress
        {
            get
            {
                return senderAddress;
            }

            set
            {
                senderAddress = value;
            }
        }

        /// <summary>
        /// Get or set the senders City.
        /// </summary>
        public string SenderCity
        {
            get
            {
                return senderCity;
            }

            set
            {
                senderCity = value;
            }
        }

        /// <summary>
        /// Get or set the senders state.
        /// </summary>
        public string SenderState
        {
            get
            {
                return senderState;
            }

            set
            {
                senderState = value;
            }
        }

        /// <summary>
        /// Get or set the recipients Name.
        /// </summary>
        public string RecipientName
        {
            get
            {
                return recipientName;
            }

            set
            {
                recipientName = value;
            }
        }

        /// <summary>
        /// Get or set the recipent address.
        /// </summary>
        public string RecipientAddress
        {
            get
            {
                return recipientAddress;
            }

            set
            {
                recipientAddress = value;
            }
        }

        /// <summary>
        /// get or set the recipient city.
        /// </summary>
        public string RecipientCity
        {
            get
            {
                return recipientCity;
            }

            set
            {
                recipientCity = value;
            }
        }

        /// <summary>
        /// Get or set the recipient state.
        /// </summary>
        public string RecipientState
        {
            get
            {
                return RecipientState1;
            }

            set
            {
                RecipientState1 = value;
            }
        }

        /// <summary>
        /// Get or set recipient state.
        /// </summary>
        public string RecipientState1
        {
            get
            {
                return recipientState;
            }

            set
            {
                recipientState = value;
            }
        }

        /// <summary>
        /// Get or seet the weight.
        /// </summary>
        public decimal Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        /// <summary>
        /// Get or set hte cost per ounce.
        /// </summary>
        public decimal CostPerOunce
        {
            get
            {
                return costPerOunce;
            }

            set
            {
                costPerOunce = value;
            }
        }

        /// <summary>
        /// get or set the sender zipcode.
        /// </summary>
        public int SenderZipCode
        {
            get
            {
                return senderZipCode;
            }

            set
            {
                senderZipCode = value;
            }
        }

        /// <summary>
        /// Get or set the recipeint Zip code.
        /// </summary>
        public int RecipientZipCode
        {
            get
            {
                return recipientZipCode;
            }

            set
            {
                recipientZipCode = value;
            }
        }

        /// <summary>
        /// Get or set the shipping comapny.
        /// </summary>
        public string ShippingCompany
        {
            get
            {
                return shippingCompany;
            }

            set
            {
                shippingCompany = value;
            }
        }

        
        /// <summary>
        /// Get or set the web client.
        /// </summary>
        public WebServiceSoapClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        /// <summary>
        /// Calculate the cost using the webservice.
        /// </summary>
        /// <returns></returns>
        public virtual decimal CalculateCost()
        {
            ServiceReference1.WebServiceSoapClient client = new ServiceReference1.WebServiceSoapClient();
             return client.CalculateCost(this.weight, this.costPerOunce);
        }

        /// <summary>
        /// Overloaded tostring returns formated class data.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (shippingCompany + "\t" + senderName + "\t" + SenderAddress + "\t" + senderCity + "\t" + SenderState + "\t" + senderZipCode + "\t" + recipientName + "\t" + recipientAddress + "\t" + recipientCity + "\t" + RecipientState + "\t" + recipientZipCode + "\t" + weight + "\t" + "$" + CalculateCost().ToString());
        }

        /// <summary>
        /// Insert a package into the database.
        /// </summary>
        /// <param name="newLog"></param>
        public static void InserLog(Package newLog)
        {
            
            DataAdapter.Insert(Serializer.SerializeNow(newLog));
        }

        /// <summary>
        /// Create a package list string array.
        /// </summary>
        /// <returns></returns>
        public static string[] CreatePackageList()
        {
            return DataAdapter.Pull();
        }

        /// <summary>
        /// Deserialize and return a new package.
        /// </summary>
        /// <param name="serPackage"></param>
        /// <returns></returns>
        public static Package DeserializePackage(string serPackage)
        {
            return Serializer.DeSerialization(serPackage);
        }
    }// end of Class.
}// End of Solution.
