using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NasadukJA.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V4.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];

                        if ((c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё')
                        {
                            strLine += "#";
                        }
                        else
                        {
                            strLine += c;
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }

            }

            return pathSaveFile;
        }
    }
}


        

        