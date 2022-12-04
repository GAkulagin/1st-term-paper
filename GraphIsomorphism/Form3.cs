using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphIsomorphism
{
    public partial class ExtendedInfoForm : Form
    {
        public ExtendedInfoForm()
        {
            InitializeComponent();
        }

        private Graph Deserialize()
        {
            Graph graph = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                ShowFileName(fileName);
                FileStream stream = new FileStream(fileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                graph = (Graph)formatter.Deserialize(stream);
                stream.Close();
            }

            return graph;
        }

        private void ShowInvariants(Graph graph)
        {
            ShowMatrix(graph.ConnectMatrix);
            ShowFirstVector(graph.FirstDegList);
            ShowSecondVector(graph.SecondDegList);

            nodesLabel.Text = graph.Nodes.ToString();
            edgesLabel.Text = graph.Edges.ToString();
            wienerLabel.Text = graph.WienerIndex.ToString();
            randicLabel.Text = Math.Round(graph.RandicIndex, 4, MidpointRounding.AwayFromZero).ToString();
            determinantLabel.Text = graph.Determinant.ToString();
            DensityLabel.Text = Math.Round(graph.Density, 4, MidpointRounding.AwayFromZero).ToString();
            ComponentsLabel.Text = graph.Components.ToString();
            CycleNuberLabel.Text = graph.CyclomaticNumber.ToString();
        }
        private void ShowMatrix(int[,] matrix)
        {
            matrixTextBox.Text = "№  ";                            // 2 spaces
            for (int i = 1; i <= matrix.GetLength(0); i++)
            {
                if (i < 10) matrixTextBox.Text += i + "    ";      // 4 spaces
                else matrixTextBox.Text += i + "   ";              // 3 spaces
            }
            matrixTextBox.Text += "\r\n";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < 9) matrixTextBox.Text += i + 1 + "     "; // 5 spaces
                else matrixTextBox.Text += i + 1 + "   ";         // 3 spaces

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < 9) matrixTextBox.Text += matrix[i, j] + "    ";   // 4 spaces
                    else matrixTextBox.Text += matrix[i, j] + "     ";        // 5 spaces

                }
                matrixTextBox.Text += "\r\n";
            }
        }
        private void ShowFirstVector(int[] array)
        {
            firstVectorTextBox.Clear();

            for (int i = 0; i < array.Length; i++)
                firstVectorTextBox.Text += array[i] + "  ";
        }
        private void ShowSecondVector(int[][] array)
        {
            secondVectorTextBox.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                secondVectorTextBox.Text += array[i].Length + " ";
                if (array[i].Length == 0)
                    secondVectorTextBox.Text += "\r\n";
                else
                {
                    secondVectorTextBox.Text += "{";
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (j == array[i].Length - 1)
                            secondVectorTextBox.Text += array[i][j] + "}\r\n";
                        else secondVectorTextBox.Text += array[i][j] + ", ";
                    }
                }
            }
        }
        private void ShowFileName(string fileName)
        {
            string[] array = fileName.Split('\\');
            FileNameLabel.Text = "Сейчас открыт: " + array[array.Length - 1];
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            Graph graph = Deserialize();
            if(graph != null)
                ShowInvariants(graph);
        }
    }
}
