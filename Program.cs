using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MetricCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\perla\Desktop\INTEC Files\Tendencias txt Practica Final Lab.txt";

            Result app = CalculateConvertions("jaja c mamo");
            int a = 1;

        }
        public static Result CalculateConvertions(string path)
        {
            Result app = new Result();

            if (!File.Exists(path))
            {
                Console.WriteLine("archivo no encontrado.");

                app.State = States.InvalidPath;
                return app;
            }

            string[] lines = File.ReadAllLines(path);

            List<MetricCalculator> MetricTranslations = new List<MetricCalculator>();
            List<string> IPO = new List<string>();
            foreach (var line in lines)
            {
                MetricTranslations.Add(new MetricCalculator(line));
            }

            foreach (var mT in MetricTranslations)
            {
                mT.CalculateResult();
                IPO.Add(mT.ToString());
            }

            File.WriteAllLines(path, IPO.ToArray());
            app.State = States.Done;
            return app;
        }

    }
    public class Result
    {
        public States State { get; set; }
    }
    public enum States
    {
        Done,
        InvalidPath
    }
}
