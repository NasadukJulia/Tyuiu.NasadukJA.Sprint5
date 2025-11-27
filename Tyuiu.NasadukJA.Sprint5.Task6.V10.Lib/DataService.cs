using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NasadukJA.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", " ").Replace(".", " ");

                    string[] parts = line.Split(' ');

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (parts[i].Length == 4)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
