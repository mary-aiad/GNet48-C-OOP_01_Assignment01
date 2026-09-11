using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_02_Delivery_Management_System
{
    internal class StandardShipment: Shipment
    {
        public StandardShipment(string trackCode, string desc, decimal weight, decimal deliveryFee, DeliveryAddress destination) :base(trackCode, desc, weight, deliveryFee, destination)
        {
            
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            base.PrintShipment();
            Console.WriteLine("Estimated Cost:" + estimatedCost);

        }
    }
}
