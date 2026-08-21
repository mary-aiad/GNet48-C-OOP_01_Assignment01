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
            DeliveryAddress deliveryAddress = new DeliveryAddress("Giza", "Haram", 1);
            DeliveryAddress deliveryAddress1 = new DeliveryAddress();
            deliveryAddress1 = deliveryAddress;

            deliveryAddress1.buildingNumber = 2;
            Console.WriteLine(deliveryAddress.GetFullAddress());
            Console.WriteLine(deliveryAddress1.GetFullAddress());
            #endregion
        }
    }
}
