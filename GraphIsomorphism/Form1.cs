using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace GraphIsomorphism
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Serialize(Graph graph)
        {
            string path = FileTasks.GetFileName();
            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, graph);
            stream.Close();
        }

        private void createGraphBtn_Click(object sender, EventArgs e)
        {
            ProgressBar.Visible = true;
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = (int)graphsNUD.Value;
            ProgressBar.Step = 1;

            for (int i = 0; i < graphsNUD.Value; i++)
            {              
                if (nodesInputNUD.Value == 0 && edgesInputNUD.Value == 0)
                {
                    Graph graph = new Graph();
                    Serialize(graph);
                }
                else if (nodesInputNUD.Value != 0 && edgesInputNUD.Value == 0)
                {
                    Graph graph = new Graph((int)nodesInputNUD.Value);
                    Serialize(graph);
                }
                else if (nodesInputNUD.Value != 0 && edgesInputNUD.Value != 0)
                {
                    Graph graph = new Graph((int)nodesInputNUD.Value, (int)edgesInputNUD.Value);
                    Serialize(graph);
                }

                Thread.Sleep(1000);  // во избежание генерации одинаковых объектов
                ProgressBar.PerformStep();
            }
            ProgressBar.Visible = false;
            GraphsCreatedLabel.Text = "Создание завершено";
        }
        private void moreInfoBtn_Click(object sender, EventArgs e)
        {
            ExtendedInfoForm form  = new ExtendedInfoForm();
            form.Show();
        }

        private void nodesInputNUD_ValueChanged(object sender, EventArgs e)
        {
            edgesInputNUD.Maximum = nodesInputNUD.Value * (nodesInputNUD.Value - 1) / 2;
            edgesLimitLabel.Text = "Не более " + edgesInputNUD.Maximum + " ребер";
        }

        private void OpenResearchFormBtn_Click(object sender, EventArgs e)
        {
            ResearchForm form = new ResearchForm();
            form.Show();
        }
    }
}
