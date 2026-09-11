using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OOP_02_Delivery_Management_System
{
    internal class ExpressShipment: Shipment
    {
        private decimal extraFee { get; set; }

        public ExpressShipment(string trackCode, string desc, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackCode, desc, weight, deliveryFee, destination)
        {
            this.ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get{ return extraFee; }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return base.DelieveryFee + (base.Weight * 5) + extraFee; }
            set { base.estimatedCost = value; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            base.PrintShipment();
            Console.WriteLine("Estimated Cost:" + EstimatedCost);
            Console.WriteLine("Extra Fee:" + ExtraFee);
        }
    }
}
