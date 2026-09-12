using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackCode, string desc, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackCode, desc, weight, deliveryFee, destination)
        {
        }
    }
}
