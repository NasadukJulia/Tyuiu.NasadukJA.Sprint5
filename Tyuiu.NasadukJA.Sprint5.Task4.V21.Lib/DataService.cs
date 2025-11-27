using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NasadukJA.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, System.Globalization.CultureInfo.InvariantCulture);

            double y = x * x * x * Math.Cos(x) + 2 * x;
            y = Math.Round(y, 3);

            return y;
        }
    }
}
