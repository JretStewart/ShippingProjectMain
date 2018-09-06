using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject
{

    /// <summary>
    /// Class: A serializable class that creates overnight package objects,
    /// Developer: Kalin Bowden.
    /// Date: 12.12.2016.
    /// </summary>
    [Serializable]
    public class OvernightPackage : Package
    {
        // Class level variables
        [NonSerialized]
        private decimal additionalFeePerOunce;

        /// <summary>
        /// defalut constructor.
        /// </summary>
        public OvernightPackage()
        {
            this.additionalFeePerOunce = 2.10m;
        }

        /// <summary>
        /// Get or set the addition fee.
        /// </summary>
        public decimal AdditionalFeePerOunce
        {
            get
            {
                return additionalFeePerOunce;
            }

            set
            {
                additionalFeePerOunce = value;
            }
        }

        /// <summary>
        /// Calculate the cost of hte overnight package.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateCost()
        {

            return Client.CalculateCostOvernight(Weight, CostPerOunce, additionalFeePerOunce);
        }
    }// End of Class.
}// End of Solution.
