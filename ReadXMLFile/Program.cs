using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/******************************* START OF READING FILE 1 ***********************************/");

            /************************* EXAMPLE FOR READING FILE 1 *****************************************/
            string path = @"\RECORDEDYIELDPERRECIPELOGP01_20200115060323.xml"; //path to file

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode NodeLineIdent = doc.GetElementsByTagName("LineIdent")[0];
            string LineIdent = NodeLineIdent.InnerText;

            XmlNode NodePeriodIdent = doc.GetElementsByTagName("PeriodIdent")[0];
            string PeriodIdent = NodePeriodIdent.InnerText;
            XmlNode NodeStartDate = doc.GetElementsByTagName("StartDate")[0];
            string StartDate = NodeStartDate.InnerText;
            XmlNode NodeEndDate = doc.GetElementsByTagName("EndDate")[0];
            string EndDate = NodeEndDate.InnerText;



            Console.WriteLine("LineIdent: {0}", LineIdent);
            Console.WriteLine("PeriodIdent: {0}", PeriodIdent);
            Console.WriteLine("StartDate {0}", StartDate);
            Console.WriteLine("EndDate {0}", EndDate);

            int count = 0;
            foreach (XmlNode xmlNode in doc.DocumentElement.GetElementsByTagName("RecordedScale"))
            {
                XmlNode NodeIdent = doc.GetElementsByTagName("Ident")[count];
                string Ident = NodeIdent.InnerText;
                Console.WriteLine("Ident: {0}", Ident);

                XmlNode NodeName = doc.GetElementsByTagName("Name")[count];
                string Name = NodeName.InnerText;
                Console.WriteLine("Name: {0}", Name);

                XmlNode NodeWeight = doc.GetElementsByTagName("Weight")[count];
                string Weight = NodeWeight.InnerText;
                Console.WriteLine("Weight: {0}", Weight);

                count++;
            }
            /************************************* END OF FILE 1****************************************/

            Console.WriteLine("/******************************* START OF READING FILE 2 ***********************************/");

            /******************************* START OF READING FILE 2 ***********************************/
            string path2 = @"\RECORDEDSTORAGESUMMARYGROUPBYLOGP01_20200114141911.xml"; //path to file

            XmlDocument doc2 = new XmlDocument();
            doc.Load(path2);

            int count2 = 0;
            foreach (XmlNode xmlNode in doc2.DocumentElement.GetElementsByTagName("RecordedStorageSummaryGroupByLog"))
            {

                XmlNode NodeLineIdent2 = doc2.GetElementsByTagName("LineIdent")[count];
                string LineIdent2 = NodeLineIdent2.InnerText;

                XmlNode NodeTotalFilling = doc2.GetElementsByTagName("TotalFilling")[count];
                string TotalFilling = NodeTotalFilling.InnerText;

                XmlNode NodeTotalDischarging = doc2.GetElementsByTagName("TotalDischarging")[count];
                string TotalDischarging = NodeTotalDischarging.InnerText;
                /**********************************************************/
                XmlNode NodeIdent = doc2.GetElementsByTagName("Ident")[count];
                string Ident = NodeIdent.InnerText;

                XmlNode NodeName = doc2.GetElementsByTagName("Name")[count];
                string Name = NodeName.InnerText;
                /**********************************************************/
                XmlNode NodePeriodIdent2 = doc2.GetElementsByTagName("PeriodIdent")[count];
                string PeriodIdent2 = NodePeriodIdent2.InnerText;

                XmlNode NodeStartDate2 = doc2.GetElementsByTagName("StartDate")[count];
                string StartDate2 = NodeStartDate2.InnerText;
                XmlNode NodeEndDate2 = doc2.GetElementsByTagName("EndDate")[count];
                string EndDate2 = NodeEndDate2.InnerText;


                Console.WriteLine("LineIdent: {0}", LineIdent2);
                Console.WriteLine("TotalFilling: {0}", TotalFilling);
                Console.WriteLine("TotalDischarging: {0}", TotalDischarging);
                Console.WriteLine("--------------Ident: {0}", Ident);
                Console.WriteLine("--------------Name: {0}", Name);
                Console.WriteLine("---------------------------PeriodIdent {0}", PeriodIdent2);
                Console.WriteLine("---------------------------StartDate {0}", StartDate2);
                Console.WriteLine("---------------------------EndDate {0}", EndDate2);
                count2++;
            }

        }
    }
}
