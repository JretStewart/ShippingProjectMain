using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ShippingProject
{
    class DailyLogSerializer
    {
        public string SerializeDailyLog(object myobject)
        {
            // Create a memory stream.
            MemoryStream myStream = new MemoryStream();

            // Create a formatter object.
            BinaryFormatter myFormat = new BinaryFormatter();

            // Serilize the Daily log.
            myFormat.Serialize(myStream, myobject);

            // Conver the serilized log into a string.
            string serializedValue = (Convert.ToBase64String(myStream.ToArray()));

            // Return the string representaion of the serilized log.
            return serializedValue;

        }

        public static Package DeSerializeDailyLog(string serLog)
        {
            // Create apackage object.
            Package newPackage;

            // Create a generic object to hold the package object.
            object genObj;

            // Create a memory stream and send it the incoming log.
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(serLog));

            // Create a formate object.
            BinaryFormatter myFormat = new BinaryFormatter();

            // Set the Deserialized log into the genric object.
            genObj = myFormat.Deserialize(myStream);

            // Cast the object to a package object.
            if (genObj.GetType().Name == "Package")
            {
                newPackage = (Package)genObj;
            }
            else
            {
                newPackage = new Package();
            }

        }
    }
}
