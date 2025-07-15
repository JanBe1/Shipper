using Shipper.Core.Enums;
using System.Text;

namespace Shipper.Core.Model
{
    public class Parcel
    {
        public int ParcelId { get; set; }
        public string TrackingNumber { get; set; }
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        /// <summary>
        /// Returns LWH dimensions of a package.
        /// </summary>
        public string Dimensions
        {
            get
            {
                return $" {Length} x {Width} x {Height}";
            }
        }

        /// <summary>
        /// Content of a package - description 255 chars long.
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Estimated value of a package.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Is package fragile or not.
        /// </summary>
        public bool Fragile { get; set; }
        public ShipmentStatus Status { get; set; }
        /// <summary>
        /// Address on which package is delivered.
        /// </summary>
        public Address DeliveryAddress { get; set; }
        /// <summary>
        /// Address by whom package is sent.
        /// </summary>
        public Address SenderAddress { get; set; }
    }
}
