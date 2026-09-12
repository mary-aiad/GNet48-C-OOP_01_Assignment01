namespace OOP_02_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question_01
            ///A- What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //Answer (A): Only the copy will be modified; the original won't change because it's a value type, so it's just a copy of the original.
            ///B- What happens when a Customer variable is copied into another variable and one variable modifies the object 
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
            //DeliveryCenter deliveryCenter = new DeliveryCenter();

            //string trackCode, description, city, street;
            //decimal weight, fee;
            //int i = 1, buildingNum;

            //do
            //{
            //    Console.WriteLine("Enter Shipment " + i + " Data");
            //    Console.Write("Tracking Code: ");
            //    trackCode = Console.ReadLine();
            //    Console.Write("Description: ");
            //    description = Console.ReadLine();
            //    Console.Write("Weight: ");
            //    weight = decimal.Parse(Console.ReadLine());
            //    Console.Write("Delivery Fee: ");
            //    fee = decimal.Parse(Console.ReadLine());
            //    Console.Write("City: ");
            //    city = Console.ReadLine();
            //    Console.Write("Street: ");
            //    street = Console.ReadLine();
            //    Console.Write("Buikding Number: ");
            //    buildingNum = int.Parse(Console.ReadLine());

            //    DeliveryAddress address = new DeliveryAddress(city, street, buildingNum);
            //    Shipment shipment = new Shipment(trackCode, description, weight, fee, address);
            //    deliveryCenter.AddShipment(shipment);
            //    i++;
            //} while (i < 2);

            //Console.Write("Enter the tracking code to search: ");
            //trackCode = Console.ReadLine();
            //Shipment shipment2 = deliveryCenter[trackCode];
            //if (shipment2.TrackingCode != null)
            //{
            //    Console.WriteLine("Shipment Found");
            //    shipment2.PrintShipment();
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found");
            //}

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

            #region Assignment02_Part2
            //DeliveryCenter deliveryCenter = new DeliveryCenter();
            //Console.Write("Enter Center Name: ");
            //string centerName = Console.ReadLine();
            //deliveryCenter.centerName = centerName;
            //string trackCode, description, city, street;
            //decimal weight, fee;
            //int i = 1, buildingNum;

            //do
            //{
            //    Console.WriteLine("Enter Shipment Type [StandardShipment, ExpressShipment, InternationalShipment]: ");
            //    string type = Console.ReadLine();
            //    Console.WriteLine("Enter Shipment " + i + " Data");
            //    Console.Write("Tracking Code: ");
            //    trackCode = Console.ReadLine();
            //    Console.Write("Description: ");
            //    description = Console.ReadLine();
            //    Console.Write("Weight: ");
            //    weight = decimal.Parse(Console.ReadLine());
            //    Console.Write("Delivery Fee: ");
            //    fee = decimal.Parse(Console.ReadLine());
            //    Console.Write("City: ");
            //    city = Console.ReadLine();
            //    Console.Write("Street: ");
            //    street = Console.ReadLine();
            //    Console.Write("Buikding Number: ");
            //    buildingNum = int.Parse(Console.ReadLine());
                
            //    DeliveryAddress address = new DeliveryAddress(city, street, buildingNum);
            //    if (type == "StandardShipment")
            //    {
            //        StandardShipment standardShipment = new StandardShipment(trackCode, description, weight, fee, address);
            //        deliveryCenter.AddShipment(standardShipment);
            //    }
            //    else if(type == "ExpressShipment")
            //    {
            //        Console.Write("Extra Fee: ");
            //        decimal extraFee = decimal.Parse(Console.ReadLine());

            //        ExpressShipment expressShipment = new ExpressShipment(trackCode, description, weight, fee, address, extraFee);
            //        deliveryCenter.AddShipment(expressShipment);
            //    }
            //    else if (type == "InternationalShipment")
            //    {
            //        Console.Write("Destination Country: ");
            //        string destinationCountry = Console.ReadLine();
            //        Console.Write("Customs Fee: ");
            //        decimal customsFee = decimal.Parse(Console.ReadLine());

            //        InternationalShipment internationalShipment = new InternationalShipment(trackCode, description, weight, fee, address, destinationCountry, customsFee);
            //        deliveryCenter.AddShipment(internationalShipment);
            //        Console.WriteLine("-------------------------------------------------------------------");
            //        Console.WriteLine("");
            //    }                
            //    i++;
            //} while (i < 4);

            //deliveryCenter.PrintAllShipments();

            ///// Search
            //Console.Write("Enter tracking code to search: ");
            //trackCode = Console.ReadLine();
            //Shipment shipmentSearch = deliveryCenter[trackCode];
            //if (shipmentSearch.TrackingCode != null)
            //{
            //    Console.WriteLine("Shipment Found");
            //    shipmentSearch.PrintShipment();
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found");
            //}
            ///// Remove
            //Console.Write("Enter tracking code to remove: ");
            //trackCode = Console.ReadLine();
            //Shipment shipmentRemove = deliveryCenter[trackCode];
            //if (shipmentRemove.TrackingCode != null)
            //{
            //    if(deliveryCenter.RemoveShipment(shipmentRemove.TrackingCode))
            //    {
            //        Console.WriteLine("Shipment Removed");
            //        deliveryCenter.PrintAllShipments();
            //    }
            //    else
            //        Console.WriteLine("Shipment not found");
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found");
            //}
            #endregion

            #region Assignment03_Part1_Q1
            ///a) What is the difference between Method Overloading and Method Overriding?
            ///b)  What is the difference between Static Binding and Dynamic Binding?
            //Answer a) overloading multiple methods with the same name but defferent type or count or order, at compile time
            //          overriding child implement the same drived method with the defferent implementation, at run time
            //Answer b) static binding early binding/ compile time binding, depends on reference type [overloading]
            //          dynamic binding late binding/ run time, depends on object it self  [overriding]
            #endregion

            #region Assignment03_Part1_Q2
            ///a)  What is the purpose of the sealed keyword when applied to a class?
            ///b)  What is the difference between a sealed class and a sealed method?
            ///c)  Can a sealed method be overridden? Why?
            //Answers
            //a) stop other clases to inheret from it, to stop the modifications on this class
            //b) sealed class can't be inherted, sealed method prevent overriding
            //c) No, because the sealed is to restricct modification of method behavior.
            #endregion

            #region Assignment03_Part2
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.Write("Enter Center Name: ");
            string centerName = Console.ReadLine();
            deliveryCenter.centerName = centerName;
            Console.Write("Enter Driver Name: ");
            string driverName = Console.ReadLine();
            deliveryCenter.driverName = driverName;
            string trackCode, description, city, street;
            decimal weight, fee;
            int i = 1, buildingNum;

            do
            {
                Console.WriteLine("Enter Shipment Type [StandardShipment, ExpressShipment, InternationalShipment]: ");
                string type = Console.ReadLine();
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
                if (type == "StandardShipment")
                {
                    StandardShipment standardShipment = new StandardShipment(trackCode, description, weight, fee, address);
                    deliveryCenter.AddShipment(standardShipment);
                }
                else if (type == "ExpressShipment")
                {
                    Console.Write("Extra Fee: ");
                    decimal extraFee = decimal.Parse(Console.ReadLine());

                    ExpressShipment expressShipment = new ExpressShipment(trackCode, description, weight, fee, address, extraFee);
                    deliveryCenter.AddShipment(expressShipment);
                }
                else if (type == "InternationalShipment")
                {
                    Console.Write("Destination Country: ");
                    string destinationCountry = Console.ReadLine();
                    Console.Write("Customs Fee: ");
                    decimal customsFee = decimal.Parse(Console.ReadLine());

                    InternationalShipment internationalShipment = new InternationalShipment(trackCode, description, weight, fee, address, destinationCountry, customsFee);
                    deliveryCenter.AddShipment(internationalShipment);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                i++;
            } while (i < 2);

            deliveryCenter.PrintAllShipments();

            //Printing Using DeliveryHelper...
            Shipment[] shipments = deliveryCenter.Shipments;
            foreach (var shipment in shipments)
            {
                if (shipment != null)
                    DeliveryHelper.PrintShipmentDetails(shipment);
                else
                    break;
            }

            //Updatewight
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Original standard weight: {shipments[0].Weight} KG");
            shipments[0].UpdateWeight(5);
            Console.WriteLine($"Updated Weight: {shipments[0].Weight} KG");
            shipments[0].UpdateWeight(5, 5);
            Console.WriteLine($"Updated Weight After Packing 5 KG: {shipments[0].Weight} KG");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("");

            shipments[0].PrintShipment();
            #endregion
        }
    }
}
