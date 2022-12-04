using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace GraphIsomorphism
{
    class FileTasks
    {
        static string savePath = "C:\\Graphs\\";

        public static string SavePath
        {
            get { return savePath; }
        }

        public static string GetFileName()
        {
            return savePath + "graph_" + Graph.objectsCounter + ".bin";
        }
        public static int GetValue()
        {
            DirectoryInfo directory = new DirectoryInfo(savePath);
            List<string> list = new List<string>();
            Regex pattern = new Regex(@"graph_\d+.bin");

            foreach (FileInfo file in directory.GetFiles())
            {
                if (pattern.IsMatch(file.Name))
                    list.Add(file.Name);
            }

            if (list.Count == 0) return 0;
            else
            {
                string[] array;
                int value = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    array = list[i].Split('_', '.');
                    int temp = int.Parse(array[1]);
                    if (temp > value)
                        value = temp;
                }

                return value;
            }
        }
    }
}
