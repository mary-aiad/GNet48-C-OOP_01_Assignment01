using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackCode, string desc, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackCode, desc, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }

        public override sealed void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
        }
    }
}
