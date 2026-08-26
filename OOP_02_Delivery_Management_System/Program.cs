using System.Security.Cryptography;
using System.Threading.Channels;

namespace OOP_02_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
             {
                #region Question_01
            ///A- What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //Answer (A): Only the copy will be modified; the original won't change because it's a value type, so it's just a copy of the original.
            ///B- What happens when a Customer variable is copied into another variable and one variable modifies the object.
            //Answer (B): the object will be modified because the class is a reference type so the 2 variables with the same referance.
            #endregion

                #region Question_02
            ///a) Identify at least three problems with this design from an encapsulation perspective.
            ///b) How can private fields and public properties improve this design?
            //Answer (A): 1- Without set & get access the fields directly, 2- the fields are public, 3- No validations over the values
            //Answer (B): when using private istead public proerties, this will control the data using setters and getters
            //and will allow the validations.
            #endregion

                #region Part02_Question01
            /// Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that
            ///the original did not change.
            //DeliveryAddress deliveryAddress = new DeliveryAddress("Giza", "Haram", 1);
            //DeliveryAddress deliveryAddress1 = new DeliveryAddress();
            //deliveryAddress1 = deliveryAddress;

            //deliveryAddress1.buildingNumber = 2;
            //Console.WriteLine(deliveryAddress.GetFullAddress());
            //Console.WriteLine(deliveryAddress1.GetFullAddress());
            #endregion

                #region Part02_Question02
            DeliveryCenter deliveryCenter = new DeliveryCenter();

            string trackCode, description, city, street;
            decimal weight, fee;
            int i = 1, buildingNum;

            do
            {
                Console.WriteLine("Enter Shipment " + i + " Data");
                Console.Write("Tracking Code: ");
                trackCode = Console.ReadLine();
                Console.Write("Description: ");
                description = Console.ReadLine();
                Console.Write("Weight: ");
                weight = decimal.Parse(Console.ReadLine());
                Console.Write("Delivery Fee: ");
                fee = decimal.Parse(Console.ReadLine());
                Console.Write("City: ");
                city = Console.ReadLine();
                Console.Write("Street: ");
                street = Console.ReadLine();
                Console.Write("Buikding Number: ");
                buildingNum = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city, street, buildingNum);
                Shipment shipment = new Shipment(trackCode, description, weight, fee, address);
                deliveryCenter.AddShipment(shipment);
                i++;
            } while (i < 2);

            Console.Write("Enter the tracking code to search: ");
            trackCode = Console.ReadLine();
            Shipment shipment2 = deliveryCenter[trackCode];
            if (shipment2.TrackingCode != null)
            {
                Console.WriteLine("Shipment Found");
                shipment2.PrintShipment();


            }
            else
            {
                Console.WriteLine("Shipment not found");
            #endregion


                #region Assignment02_Part1_Question01
                /// a) What is the difference between a class and a struct?
                /// b) Why are classes more suitable than structs for large applications?
                // Answer a) Struct is a value type, Class is reference type
                //          Struct use small data and not support the inhertance but the class support it.
                // Answer  b) Because class support oop princeple, inhertance, polymorphism and more flexable for multiple objects.

                #endregion

                #region Assignment02_Part1_Question02
                /// a) Which class is the parent class?
                /// b) Which class is the child class?
                /// c) What members are inherited by ExpressShipment?
                /// d) Why is inheritance better than duplicating the same code in multiple classes?
                //Answer
                // a) Shipment Class
                // b) ExpressShipment
                // C) TrackingCode
                // d) inhertance better because it less code dupplication, easier maintance, reusability and easier to extend with out any duplication. 
                #endregion
            }
        }
    }
}
