using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination {  get; set; }
        private decimal EstimatedCost { get; set; }


        public Shipment(string trackCode)
        {
            this.trackingCode = trackCode;
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

        }

        public Shipment(string trackCode, string dest, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = trackCode;  
            this.description = dest;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            this.Destination = destination;
        }
        public string TrackingCode{ 
            get{ return trackingCode; }
            private set
            {
                if (trackingCode != null && trackingCode.Length != 0)
                { 
                    trackingCode = value; 
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
        }

        public string Description
        {
            get { return description; }
            private set
            {
                if (description != null && description.Length != 0)
                {
                    description = value;
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }
            private set
            {
                if (weight > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
        }

        public decimal DelieveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (deliveryFee > 0)
                {
                    deliveryFee = value;
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
        }

        public decimal estimatedCost
        {
            get { return deliveryFee + (weight * 5); }
            set { estimatedCost = value; }
        }

        public decimal UpdateDelieveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                this.deliveryFee = newFee;
            }
            return deliveryFee;
        }

        

        public void PrintShipment()
        {
            Console.WriteLine("Tracking Code:" + trackingCode);
            Console.WriteLine("Description:" + description);
            Console.WriteLine("Weight:" + weight);
            Console.WriteLine("Delievery Fee:" + deliveryFee);
            Console.WriteLine("Destination:" + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost:" + estimatedCost);
        }

    }
}
