using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal class InternationalShipment : Shipment
    {
        private string DestinationCountry { get; set; }
        private decimal CustomsFee { get; set; }

        public InternationalShipment(string trackCode, string desc, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackCode, desc, weight, deliveryFee, destination)
        {
           this.destinationCountry = destinationCountry;
            this.customsFee = customsFee;

        }

        public string destinationCountry
        {
            get { return DestinationCountry; }
            set
            {
                if (value != null && value.Length != 0)
                    DestinationCountry = value;
                else
                    Console.WriteLine("Invalid Value");
            }
        }

        public decimal customsFee
        {
            get { return CustomsFee; }
            set
            {
                if(value >= 0)
                {
                    CustomsFee = value;
                }
            }
        }

        public override decimal EstimatedCost 
        {
            get
            {
                return base.DelieveryFee + (base.Weight * 5) + customsFee;
            }
            set
            {
                base.estimatedCost = value;
            }
        }

        public override void PrintShipment()
        {
            
            Console.WriteLine("International Shipment");
            base.PrintShipment();
            Console.WriteLine("Estimated Cost:" + EstimatedCost);
            Console.WriteLine("Destination Country:" + destinationCountry);
            Console.WriteLine("Customs Fee:" + customsFee);
        }

        public virtual void GenerateCustomsReport()
        {

        }
    }
}
