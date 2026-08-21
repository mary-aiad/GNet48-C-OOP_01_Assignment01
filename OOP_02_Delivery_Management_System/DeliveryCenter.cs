using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal struct DeliveryCenter
    {
        private Shipment[] shipments;
        

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                else
                {
                    return default(Shipment);
                }
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return default(Shipment);
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("The shipment was added successfully.");
                    return true;
                }
            }
            Console.WriteLine("The delivery center is full");
            return false;
        }
    
    }
}
