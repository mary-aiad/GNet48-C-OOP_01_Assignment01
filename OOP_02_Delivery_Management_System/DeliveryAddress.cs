using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_Delivery_Management_System
{
    internal struct DeliveryAddress
    {
        private string City {  get; set; }
        private string Street {  get; set; }
        private int BuildingNumber {  get; set; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.City = city;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
        }

        public string city
        {
            get { return City; }
            set { City =  value; }
        }

        public string street
        {
            get { return Street; }
            set { Street = value; }
        }

        public int buildingNumber
        {
            get { return BuildingNumber; }
            set { BuildingNumber = value; }
        }
        public string GetFullAddress()
        {
            string fullAddress = BuildingNumber + " " +Street+ " " +City;
            return fullAddress;
        }

    }
}
