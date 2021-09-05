using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace converterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // convert Celsius temperature to Fahrenheit temperature 
        public int c2f(int c) {
            double convertedInt = ((c * 1.8) + (32));
            int nc = Convert.ToInt32(convertedInt);
            return nc;
        }
        // convert Fahrenheit temperature to Celsius temperatureint f2c(int f) {
        public int f2c(int f)
        {
            double convertedInt = ((f - 32) * 0.555555555556);
            int nc = Convert.ToInt32(convertedInt);

            return nc;

        }
        public string sort(string s)

        {
            string[] values = (s).Split(',');
            Array.Sort(values);
            return String.Join(",", values);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
