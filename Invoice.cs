using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject
{
    /// <summary>
    /// Class: Allows the creaton of an invoice object.
    /// Developer: Kalin Bowden,
    /// Date: 12.12.2016.
    /// </summary>
    class Invoice : Package
    {
        // Class level variables.
        private decimal totalCost;
        private decimal tax;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Invoice()
        {

        }

        /// <summary>
        /// Get or set the tax.
        /// </summary>
        public decimal Tax
        {
            get
            {
                return tax;
            }

            set
            {
                tax = value;
            }
        }

        /// <summary>
        /// Get or set the total cost.
        /// </summary>
        public decimal TotalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                totalCost = value;
            }
        }

        
        /// <summary>
        /// Calculate the cost of shipping the package.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateCost()
        {
            return base.CalculateCost();
        }

        /// <summary>
        /// Calculate the tax of shipping the packages.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTax()
        {
            Tax = CalculateCost() + (CalculateCost() * Tax);
            return Tax;
        }

        /// <summary>
        /// Calculate the total cost of shipping the packages.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTotal()
        {
            TotalCost = CalculateCost() + CalculateTax();
            return TotalCost;
        }
    }// End of Class.
}// End of Solution.
