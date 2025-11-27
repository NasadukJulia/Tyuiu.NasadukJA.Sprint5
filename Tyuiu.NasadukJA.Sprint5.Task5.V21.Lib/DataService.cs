using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NasadukJA.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            int maxEven = int.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();

                string[] parts = text.Split(' ');

                foreach (string p in parts)
                {
                    double value = double.Parse(p, System.Globalization.CultureInfo.InvariantCulture);

                    if (value % 1 == 0)
                    {
                        int n = (int)value;

                        if (n % 2 == 0)
                        {
                            if (n > maxEven)
                                maxEven = n;
                        }
                    }
                }
            }

            double fact = 1;

            for (int i = 1; i <= maxEven; i++)
                fact *= i;

            return fact;
        }
    }
}
