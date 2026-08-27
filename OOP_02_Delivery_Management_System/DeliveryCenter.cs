using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        private string CenterName { get; set; }
        

        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        public string centerName
        {
            get { return CenterName; }
             set
            {
                if(value != null && value.Length != 0)
                {
                    CenterName = value;
                }
                else
                {
                    Console.WriteLine("Invalid Value");
                }
            }
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
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("The shipment was added successfully.");
                    Console.WriteLine();
                    return true;
                }
            }
            Console.WriteLine("The delivery center is full");
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {

            Shipment shipment = this[trackingCode];
            if (shipment == null)
                return false;
            int index = Array.IndexOf(shipments, shipment);
            if (index == -1)
                return false;
            shipments[index] = null; 
            return true;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Delivery Center: {CenterName}");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i]!= null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine("----------------------------------------------------");
                }
                
            }
        }
    }
}
