using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace ShippingProject
{
    /// <summary>
    /// Class: A class for handling xml serilizaion.
    /// </summary>
    class SaveXML
    {
        /// <summary>
        /// set the SaveData method with two arguments
        /// </summary>
        /// <param name="submit"></param>
        /// <param name="fileName"></param>
        public static void SaveData(ArrayList submit, string fileName)
        {
            Package[] submitted = ConvertToArray(submit);
            XmlSerializer save = new XmlSerializer(submitted.GetType());
            TextWriter writer = new StreamWriter(fileName);
            save.Serialize(writer, submitted);
            writer.Close();
        }
        /// <summary>
        /// convert the submitted arraylist from PackageForm to a new object array of Package
        /// </summary>
        /// <param name="submit"></param>
        /// <returns></returns>
        public static Package[] ConvertToArray(ArrayList submit)
        {
            Package[] submitted = new Package[submit.Count];
            submit.CopyTo(submitted);
            return submitted;
        }
    }// End of Class.
}// End of Solution.
