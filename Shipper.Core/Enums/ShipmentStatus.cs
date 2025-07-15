namespace Shipper.Core.Enums
{
    public enum ShipmentStatus
    {
        InPreparation,
        /// <summary>
        /// Order processing. Courier is about to pick up the package.
        /// </summary>
        Processed,
        /// <summary>
        /// Shipment is in delivery. Courier goes with it.
        /// </summary>
        InDelivery,
        /// <summary>
        /// Package is lost. What even happened here?
        /// </summary>
        Lost,
        /// <summary>
        /// Package got delayed - bad weather conditions or other bad things happened.
        /// </summary>
        Delayed,

        /// <summary>
        /// Shipment is delivered to the client.
        /// </summary>
        Delivered,

        /// <summary>
        /// Looks like we won't deliver it at all. 
        /// </summary>
        Cancelled,

    }
}
