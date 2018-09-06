using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject
{
    /// <summary>
    /// Interface: Forces the caluclate cost method to be created.
    /// Developers: Kalin Bowden,
    /// Date: 12.12.016.
    /// </summary>
    interface IPayable
    {
        // Interface level varaiables.
        decimal CalculateCost();
    }
}
