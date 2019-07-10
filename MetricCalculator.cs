using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricCalculator
{
    public class MetricCalculator
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Origin { get; set; }
        public double Result { get; set; }

        public MetricCalculator(string line)
        {
            string[] props = line.Split(',');
            this.Origin = Convert.ToDouble(props[0]);
            this.From = props[1];
            this.To = props[2];
        }

        private double ConvertToMeter(string from)
        {
            double result;
            switch (from)
            {
                case "KM":
                    result = Origin * 1000;
                    break;
                case "CM":
                    result = Origin / 100;
                    break;
                case "MM":
                    result = Origin / 1000;
                    break;
                case "M":
                    result = Origin;
                    break;
                default:
                    throw new NotImplementedException();

            }
            return result;
        }
        private double ConvertFromMeter(string to, double Origin)
        {
            double result;
            switch (to)
            {
                case "KM":
                    result = Origin / 1000;
                    break;
                case "CM":
                    result = Origin * 100;
                    break;
                case "MM":
                    result = Origin * 1000;
                    break;
                case "M":
                    result = Origin;
                    break;
                default:
                    throw new NotImplementedException();

            }
            return result;
        }

        public void CalculateResult()
        {
            double meters = ConvertToMeter(From);
            Result = ConvertFromMeter(To, meters);


        }


        public override string ToString()
        {
            string ret = String.Join(",", Origin, From, To, Result);
            return ret;
        }
    }
}

