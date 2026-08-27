using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination {  get; set; }
        public virtual decimal EstimatedCost { get; set; }


        public Shipment(string trackCode)
        {
            this.TrackingCode = trackCode;
            this.Description = "Unknown";
            this.Weight = 1;
            this.DelieveryFee = 50;

        }

        public Shipment(string trackCode, string desc, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.TrackingCode = trackCode;
            this.Description = desc;
            this.Weight = weight;
            this.DelieveryFee = deliveryFee;
            this.Destination = destination;
        }
        public string TrackingCode{ 
            get{ return trackingCode; }
            private set
            {
                if (value != null && value.Length != 0)
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
                if (value != null && value.Length != 0)
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
                if (value > 0)
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
                if (value > 0)
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
            get { return DelieveryFee + (Weight * 5); }
            set { estimatedCost = value; }
        }

        public decimal UpdateDelieveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                this.DelieveryFee = newFee;
            }
            return DelieveryFee;
        }

        

        public virtual void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine("Tracking Code:" + TrackingCode);
            Console.WriteLine("Description:" + Description);
            Console.WriteLine("Weight:" + Weight);
            Console.WriteLine("Delievery Fee:" + DelieveryFee);
            Console.WriteLine("Destination:" + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost:" + estimatedCost);
        }

    }
}
