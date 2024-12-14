using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL.Operations
{
    public class CurrOperations
    {
        private static CurrOperations instance = null;

        public static CurrOperations GetInstance()
        {
            if (instance == null)
                instance = new CurrOperations();
            return instance;
        }
        public XmlDocument GetCurr()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xml = new XmlDocument();
            xml.Load(url);

            return xml;
        }
    }
}
