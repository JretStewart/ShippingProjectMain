using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ShippingProject
{

    class Serializer
    {
        /// <summary>
        /// Create an encoded package.
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public static string SerializeNow(Package log)
        {
            // Create a memory stream.
            MemoryStream myStream = new MemoryStream();

            // Create a format object.
            BinaryFormatter myFormat = new BinaryFormatter();

            // Serialize the family member object.
            myFormat.Serialize(myStream, log);

            // Convert the serialized object into a string.
            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            // close the stream.
            myStream.Close();

            // Put the serialized value into the correct object property.
            return serializedValue;

        }// End of Method.

        /// <summary>
        /// Deserialize the family member object.
        /// </summary>
        /// <param name="encodedData"></param>
        public static Package DeSerialization(string serLog)
        {
            // Create a family memebr object.
            Package newPackage;

            // Create an generic object to hold the family object.
            object genPack;

            // Create a new memory stream and send it the encoded data.
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(serLog));

            // Create a formater object.
            BinaryFormatter myFormat = new BinaryFormatter();

            // Set the deserialized value to the genereic object
            genPack = myFormat.Deserialize(myStream);

            // Conver the generic object  to a Familymember object.
            if (genPack.GetType().Name == "Package")
            {
                // Set  generic object to family object.
                newPackage = (Package)genPack;
            }
            else
            {
                newPackage = new Package();
            }

            // Close the stream
            myStream.Close();

            return newPackage;
        }// End of Method.
    }// end of Class.
}// End of Solution.
