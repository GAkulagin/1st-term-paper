using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace GraphIsomorphism
{
    public partial class ResearchForm : Form
    {
        Graph patternGraph = null;
        static int researchNumber = 0;

        public ResearchForm()
        {
            InitializeComponent();

            StatsTextBox.Text = String.Format("{0,2}     {1,-22}{2,9}{3,22}{4,24}\r\n \r\n", "№", "Инвариант", "Проверено", "Ожидаемо изоморфны", "Среднее время (мс)");
        }

        private static void SortJaggedArray(int[][] array)
        {
            int[] lengthArray = new int[array.GetLength(0)];

            for (int i = 0; i < lengthArray.Length; i++)
            {
                lengthArray[i] = array[i].Length;

                Array.Sort(array[i]); ;
            }

            Array.Sort(lengthArray, array);
        }
        private static bool CompareArrays(int[] array1, int[] array2)
        {
            bool result = true;

            if (array1.Length != array2.Length)
                result = false;
            else
                for (int i = 0; i < array2.Length; i++)
                    if (array1[i] != array2[i])
                    {
                        result = false;
                        break;
                    }

            return result;
        }
        private static bool CompareJaggedArrays(int[][] array1, int[][] array2)
        {
            bool result = true;

            if (array1.GetLength(0) != array2.GetLength(0))
                result = false;
            else
                for (int i = 0; i < array2.GetLength(0); i++)
                    if (!CompareArrays(array1[i], array2[i]))
                    {
                        result = false;
                        break;
                    }

            return result;
        }

        private void StatsOutput(string invariant, int expIsomorphCount, double time, int checkedAmount)
        {
            if (invariant == "Упорядоченный вектор степеней первого порядка")
                invariant = "Вектор первого порядка";
            if (invariant == "Упорядоченный вектор степеней второго порядка")
                invariant = "Вектор второго порядка";
            if (invariant == "Число компонент связности")
                invariant = "Компоненты связности";
            if (invariant == "Определитель матрицы смежности")
                invariant = "Определитель";

            StatsTextBox.Text += String.Format("{0,2}     {1,-22}{2,9}{3,22}{4,24}\r\n", researchNumber, invariant, checkedAmount, expIsomorphCount, Math.Round(time, 5, MidpointRounding.AwayFromZero));
        }

        private Graph Deserialise(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Graph g = (Graph)formatter.Deserialize(stream);
            stream.Close();

            return g;
        }
        private void GetPatternGraph()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] array = openFileDialog.FileName.Split('\\');
                FileNameLabel.Text = array[array.Length - 1];
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                patternGraph = (Graph)formatter.Deserialize(stream);
                stream.Close();

                BeginBtn.Enabled = true;
            }
        }
        private List<string> GetFilesList()
        {
            DirectoryInfo directory = new DirectoryInfo(FileTasks.SavePath);
            List<string> list = new List<string>();
            Regex pattern = new Regex(@"graph_\d+.bin");

            foreach(FileInfo file in directory.GetFiles())
            {
                if (file.Name != FileNameLabel.Text && pattern.IsMatch(file.Name))
                    list.Add(file.FullName);
            }

            return list;
        }
        private void GetInvariant(CheckBox checkBox, List<string> filesList)
        {
            if (checkBox.Checked)
            {
                int counter = filesList.Count;
                int expIsomorphCount = 0;  // счетчик графов, для которых ожидаем изоморфизм с графом-шаблоном
                string invariant = checkBox.Text;
                double timeSum = 0.0;

                for (int i = 0; i < counter; i++)
                {
                    Graph graph = Deserialise(filesList[i]);

                    switch (checkBox.Text)
                    {
                        case "Индекс Винера":
                            {
                                if (graph.WienerIndex == patternGraph.WienerIndex)
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[3].TotalMilliseconds;

                                break;
                            }
                        case "Индекс Рандича":
                            {
                                if (graph.RandicIndex == patternGraph.RandicIndex)
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[2].TotalMilliseconds;

                                break;
                            }
                        case "Число компонент связности":
                            {
                                if (graph.Components == patternGraph.Components)
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[6].TotalMilliseconds;

                                break;
                            }
                        case "Плотность графа":
                            {
                                if (graph.Density == patternGraph.Density)
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[5].TotalMilliseconds;

                                break;
                            }
                        case "Упорядоченный вектор степеней первого порядка":
                            {
                                Stopwatch watch = new Stopwatch();

                                watch = Stopwatch.StartNew();
                                Array.Sort(graph.FirstDegList);
                                Array.Sort(patternGraph.FirstDegList);
                                watch.Stop();
                                TimeSpan time = watch.Elapsed;

                                if (CompareArrays(graph.FirstDegList, patternGraph.FirstDegList))
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[0].TotalMilliseconds + time.TotalMilliseconds;

                                break;
                            }
                        case "Упорядоченный вектор степеней второго порядка":
                            {
                                Stopwatch watch = new Stopwatch();

                                watch = Stopwatch.StartNew();
                                SortJaggedArray(graph.SecondDegList);
                                SortJaggedArray(patternGraph.SecondDegList);
                                watch.Stop();
                                TimeSpan time = watch.Elapsed;

                                if (CompareJaggedArrays(graph.SecondDegList, patternGraph.SecondDegList))
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[1].TotalMilliseconds + time.TotalMilliseconds;

                                break;
                            }
                        case "Определитель матрицы смежности":
                            {
                                if (graph.Determinant == patternGraph.Determinant)
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[4].TotalMilliseconds;

                                break;
                            }
                        case "Цикломатическое число":
                            {
                                if (graph.CyclomaticNumber == patternGraph.CyclomaticNumber)
                                    expIsomorphCount++;

                                timeSum += graph.TimeArray[7].TotalMilliseconds;

                                break;
                            }
                    }
                }

                timeSum /= counter;
                researchNumber++;
                StatsOutput(invariant, expIsomorphCount, timeSum, counter);
            }
        }

        private void ShowMatrix(int[,] matrix)
        {
            MatrixTextBox.Text = "№  ";                            // 2 spaces
            for (int i = 1; i <= matrix.GetLength(0); i++)
            {
                if (i < 10) MatrixTextBox.Text += i + "  ";      // 4 spaces
                else MatrixTextBox.Text += i + " ";              // 3 spaces
            }
            MatrixTextBox.Text += "\r\n";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < 9) MatrixTextBox.Text += i + 1 + "  "; // 4 spaces
                else MatrixTextBox.Text += i + 1 + " ";         // 3 spaces

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < 9) MatrixTextBox.Text += matrix[i, j] + "  ";   // 4 spaces
                    else MatrixTextBox.Text += matrix[i, j] + "   ";        // 5 spaces
                }
                MatrixTextBox.Text += "\r\n";
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            GetPatternGraph();

            if(patternGraph != null)
                ShowMatrix(patternGraph.ConnectMatrix);
        }
        private void BeginBtn_Click(object sender, EventArgs e)
        {
            List<string> filesList = GetFilesList();

            GetInvariant(WienerIndexCheckBox, filesList);
            GetInvariant(RandicIndexCheckBox, filesList);
            GetInvariant(ComponentsCheckBox, filesList);
            GetInvariant(DensityCheckBox, filesList);
            GetInvariant(FirstVectorCheckBox, filesList);
            GetInvariant(SecondVectorCheckBox, filesList);
            GetInvariant(DeterminantCheckBox, filesList);
            GetInvariant(CyclomaticNumberCheckBox, filesList);
        }
        private void SaveStatsBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName + ".txt";
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine(StatsTextBox.Text);
                writer.Close();
            }
        }
        private void CheckAllBtn_Click(object sender, EventArgs e)
        {
            WienerIndexCheckBox.Checked = true;
            RandicIndexCheckBox.Checked = true;
            ComponentsCheckBox.Checked = true;
            DensityCheckBox.Checked = true;
            FirstVectorCheckBox.Checked = true;
            SecondVectorCheckBox.Checked = true;
            DeterminantCheckBox.Checked = true;
            CyclomaticNumberCheckBox.Checked = true;
        }
        private void UncheckAllBtn_Click(object sender, EventArgs e)
        {
            WienerIndexCheckBox.Checked = false;
            RandicIndexCheckBox.Checked = false;
            ComponentsCheckBox.Checked = false;
            DensityCheckBox.Checked = false;
            FirstVectorCheckBox.Checked = false;
            SecondVectorCheckBox.Checked = false;
            DeterminantCheckBox.Checked = false;
            CyclomaticNumberCheckBox.Checked = false;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            StatsTextBox.Clear();
            StatsTextBox.Text = String.Format("{0,2}     {1,-22}{2,9}{3,22}{4,24}\r\n \r\n", "№", "Инвариант", "Проверено", "Ожидаемо изоморфны", "Среднее время (мс)");
        }
    }
}
