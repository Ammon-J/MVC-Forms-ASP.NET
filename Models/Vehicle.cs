using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    /// <summary>
    /// Represents a vehicle
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// The company that manufactured the vehicle
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Name of the vehicle
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The year the vehicle was made
        /// </summary>
        public DateTime Year {get; set; }

        /// <summary>
        /// The price of the vehicle
        /// </summary>
        public  double Price { get; set; }

        /// <summary>
        /// Gasoline or diesel
        /// </summary>
        public string FuelType { get; set; }

        /// <summary>
        /// Truck, car, or motorcycle 
        /// </summary>
        public string BodyType { get; set; }

        /// <summary>
        /// Gas mileage
        /// </summary>
        public double GasMileage { get; set; }

    }
}
