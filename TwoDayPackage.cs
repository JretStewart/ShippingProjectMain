using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject
{
    /// <summary>
    /// Class: A class for creating tow day package objects.
    /// Developers: Kalin Bowden,
    /// Date: 12.12.2016.
    /// </summary>
    [Serializable]
    public class TwoDayPackage : Package
    {
        // Class level varaibles.
        [NonSerialized]
        private decimal flatFee;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TwoDayPackage()
        {
            this.flatFee = 5.5m;
        }

       /// <summary>
       /// Get or set the flat fee.
       /// </summary>
       public decimal FlatFee
        {
            get
            {
                return flatFee;
            }

            set
            {
                flatFee = value;
            }
        }

        /// <summary>
        /// The overridden method for calcualting a 2 day shipping object.
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateCost()
        {

            return Client.CalulateCost2Day(Weight, CostPerOunce, flatFee);
        }
    }// End of Class.
}// End of Solution.
