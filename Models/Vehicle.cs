using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCForm.Models
{
    /// <summary>
    /// Represents a vehicle
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Name of the vehicle 
        /// </summary>
        [Required]
        public string Make { get; set; }

        /// <summary>
        /// The company that manufactured the vehicle
        /// </summary>
        [Required]
        public string Model { get; set; }

        /// <summary>
        /// The year the vehicle was made
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime Year {get; set; }

        /// <summary>
        /// The price of the vehicle
        /// </summary>
        [Required]
        public  double Price { get; set; }

        /// <summary>
        /// Gasoline or diesel
        /// </summary>
        [Required]
        [Display(Name = "Fuel Type")]
        public string FuelType { get; set; }

        /// <summary>
        /// Truck, car, or motorcycle 
        /// </summary>
        [Required]
        [Display(Name = "Body Type")]
        public string BodyType { get; set; }

        /// <summary>
        /// Gas mileage
        /// </summary>
        [Required]
        [Display(Name = "Gas Mileage")]
        public double GasMileage { get; set; }

    }
}
