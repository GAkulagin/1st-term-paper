using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GraphIsomorphism
{
    [Serializable]
    class Graph
    {
        int nodes;              // число вершин
        int edges;              // число ребер
        int[,] connectMatrix;   // матрица смежности
        int[] firstDegList;     // список степеней вершин первого порядка
        int[][] secondDegList;  // список степеней вершин второго порядка
        double randicIndex;     // индекс Рандича
        int wienerIndex;        // индекс Винера
        int determinant;        // определитель матрицы смежности
        double density;         // плотность графа
        int components;         // число компонент связности
        int cyclomaticNumber;   // цикломатическое число
        TimeSpan[] timeArray;    // массив времени выполнения алгоритмов

        [NonSerialized]
        public static int objectsCounter = FileTasks.GetValue();


        public Graph()                          // строго в этом порядке
        {
            Random rand = new Random();
            int size = rand.Next(3, 20);
            connectMatrix = GetMatrix(size);
            timeArray = new TimeSpan[8];
            Stopwatch watch = new Stopwatch();

            watch = Stopwatch.StartNew();
            firstDegList = GetFirsDegList(ref connectMatrix);
            watch.Stop();
            timeArray[0] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            secondDegList = GetSecondDegList(ref connectMatrix, ref firstDegList);
            watch.Stop();
            timeArray[1] = watch.Elapsed;

            nodes = firstDegList.Length;

            edges = CountEdges(ref firstDegList);

            watch = Stopwatch.StartNew();
            randicIndex = GetRandicIndex(ref connectMatrix, ref firstDegList);
            watch.Stop();
            timeArray[2] = watch.Elapsed;

            watch = Stopwatch.StartNew();  
            wienerIndex = GetWienerIndex(connectMatrix);
            watch.Stop();
            timeArray[3] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            determinant = GetDeterminant(connectMatrix);
            watch.Stop();
            timeArray[4] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            density = GetDensity(nodes, edges);
            watch.Stop();
            timeArray[5] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            components = GetComponents(ref connectMatrix);
            watch.Stop();
            timeArray[6] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            cyclomaticNumber = GetCyclomaticNumber(nodes, edges, components);
            watch.Stop();
            timeArray[7] = watch.Elapsed;

            objectsCounter++;
        }
        public Graph(int size)                  // строго в этом порядке. Дано число вершин
        {
            timeArray = new TimeSpan[8];
            connectMatrix = GetMatrix(size);
            Stopwatch watch = new Stopwatch();

            watch = Stopwatch.StartNew();
            firstDegList = GetFirsDegList(ref connectMatrix);
            watch.Stop();
            timeArray[0] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            secondDegList = GetSecondDegList(ref connectMatrix, ref firstDegList);
            watch.Stop();
            timeArray[1] = watch.Elapsed;

            nodes = size;

            edges = CountEdges(ref firstDegList);

            watch = Stopwatch.StartNew();
            randicIndex = GetRandicIndex(ref connectMatrix, ref firstDegList);
            watch.Stop();
            timeArray[2] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            wienerIndex = GetWienerIndex(connectMatrix);
            watch.Stop();
            timeArray[3] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            determinant = GetDeterminant(connectMatrix);
            watch.Stop();
            timeArray[4] = watch.Elapsed;         

            watch = Stopwatch.StartNew();
            density = GetDensity(nodes, edges);
            watch.Stop();
            timeArray[5] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            components = GetComponents(ref connectMatrix);
            watch.Stop();
            timeArray[6] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            cyclomaticNumber = GetCyclomaticNumber(nodes, edges, components);
            watch.Stop();
            timeArray[7] = watch.Elapsed;

            objectsCounter++;
        }
        public Graph(int size, int edgesCount)  // строго в этом порядке. Дано число вершин и ребер
        {
            timeArray = new TimeSpan[8];
            connectMatrix = GetMatrix(size, edgesCount);
            Stopwatch watch = new Stopwatch();

            watch = Stopwatch.StartNew();
            firstDegList = GetFirsDegList(ref connectMatrix);
            watch.Stop();
            timeArray[0] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            secondDegList = GetSecondDegList(ref connectMatrix, ref firstDegList);
            watch.Stop();
            timeArray[1] = watch.Elapsed;

            nodes = size;

            edges = edgesCount;

            watch = Stopwatch.StartNew();
            randicIndex = GetRandicIndex(ref connectMatrix, ref firstDegList);
            watch.Stop();
            timeArray[2] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            wienerIndex = GetWienerIndex(connectMatrix);
            watch.Stop();
            timeArray[3] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            determinant = GetDeterminant(connectMatrix);
            watch.Stop();
            timeArray[4] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            density = GetDensity(nodes, edges);
            watch.Stop();
            timeArray[5] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            components = GetComponents(ref connectMatrix);
            watch.Stop();
            timeArray[6] = watch.Elapsed;

            watch = Stopwatch.StartNew();
            cyclomaticNumber = GetCyclomaticNumber(nodes, edges, components);
            watch.Stop();
            timeArray[7] = watch.Elapsed;

            objectsCounter++;
        }

        public int Nodes
        {
            get { return nodes; }
        }
        public int Edges
        {
            get { return edges; }
        }
        public int[,] ConnectMatrix
        {
            get { return connectMatrix; }
        }
        public int[] FirstDegList
        {
            get { return firstDegList; }
        }
        public int[][] SecondDegList
        {
            get { return secondDegList; }
        }
        public double RandicIndex
        {
            get { return randicIndex; }
        }
        public int WienerIndex
        {
            get { return wienerIndex; }
        }
        public int Determinant
        {
            get { return determinant; }
        }
        public double Density
        {
            get { return density; }
        }
        public int Components
        {
            get { return components; }
        }
        public int CyclomaticNumber
        {
            get { return cyclomaticNumber; }
        }
        public TimeSpan[] TimeArray
        {
            get { return timeArray; }
        }

        private static int[,] GetMatrix(int size)
        {
            Random rand = new Random();
            int[,] matrix = new int[size, size];
            int columnCounter = 1;

            for (int i = 0; i < size; i++)
            {
                for (int j = columnCounter; j < size; j++)
                {
                    matrix[i, j] = rand.Next(0, 2);

                    if (matrix[i, j] == 1)
                        matrix[j, i] = 1;
                }
                columnCounter++;
            }
            return matrix;
        }

        private static int[,] GetMatrix(int size, int edgesCounter)
        {
            Random rand = new Random();
            int[,] matrix = new int[size, size];        

            while (edgesCounter != 0)
            {
                int columnCounter = 1;

                for (int i = 0; i < size; i++)
                {
                    for (int j = columnCounter; j < size; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            matrix[i, j] = rand.Next(0, 2);

                            if (matrix[i, j] == 1)
                            {
                                matrix[j, i] = 1;
                                edgesCounter--;
                            }
                        }

                        if (edgesCounter == 0)
                            return matrix;
                    }
                    columnCounter++;
                }
            }
            return matrix;
        }

        private static int[] GetFirsDegList(ref int[,] connectMatrix)
        {
            int[] firstDegList = new int[connectMatrix.GetLength(0)];
            
            for(int i = 0; i < connectMatrix.GetLength(0); i++)
                for(int j = 0; j < connectMatrix.GetLength(1); j++)
                    if (connectMatrix[i, j] == 1)
                        firstDegList[i]++;

            return firstDegList;

        }

        private static int[][] GetSecondDegList(ref int[,] connectMatrix, ref int[] firstDegList)
        {
            int[][] secondDegList = new int[firstDegList.Length][];
            for (int i = 0; i < secondDegList.Length; i++)
                secondDegList[i] = new int[firstDegList[i]];

            for(int i = 0; i < connectMatrix.GetLength(0); i++)
            {
                int counter = 0;

                for(int j = 0; j < connectMatrix.GetLength(1); j++)
                    if (connectMatrix[i, j] == 1)
                    {
                        secondDegList[i][counter] = firstDegList[j];
                        counter++;
                    }
            }

            return secondDegList;
        }
        private static int CountEdges(ref int[] firstDegList)
        {
            int sum = 0;

            foreach (int element in firstDegList)
                sum += element;

            return sum / 2;
        }
        private static double GetRandicIndex(ref int[,] connectMatrix, ref int[] firstDegList)
        {
            double randicIndex = 0;
            int columnCounter = 1;
            int size = connectMatrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = columnCounter; j < size; j++)
                {
                    if(connectMatrix[i, j] == 1)
                    {
                        randicIndex += 1.0 / Math.Sqrt(firstDegList[i] * firstDegList[j]);
                    }
                }
                columnCounter++;
            }

            return randicIndex;
        }
        private static int GetWienerIndex(int[,] connectMatrix)
        {
            int wienerIndex = 0;
            int[,] distanceMatrix = GetDistanceMatrix(ref connectMatrix);
            int size = distanceMatrix.GetLength(0);
            int columnCounter = 1;

            // алгоритм Флойда - Уоршелла
            for (int k = 0; k < size; k++)
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        distanceMatrix[i, j] = Math.Min(distanceMatrix[i, j], distanceMatrix[i, k] + distanceMatrix[k, j]);

            for (int i = 0; i < size; i++)
            {
                for (int j = columnCounter; j < size; j++)
                    if (distanceMatrix[i, j] < 1000)
                        wienerIndex += distanceMatrix[i, j];

                columnCounter++;
            }

            return wienerIndex;
        }
        private static int GetDeterminant(int[,] matrix)
        {
            int sign = 1;
            int result = 0;

            if (matrix.Length == 4)
            {
                int value = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

                return value;
            }

            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                int[,] minor = GetMinor(matrix, column);
                result += sign * matrix[0, column] * GetDeterminant(minor);
                sign = -sign;
            }

            return result;
        }
        private static double GetDensity(int nodes, int edges)
        {
            double result = (2 * edges) / (double)(nodes * (nodes - 1));

            return result;
        }
        private static int GetComponents(ref int[,] connectMatrix)
        {
            // алгоритм поиска в ширину

            int result = 0;
            Queue<int> queue = new Queue<int>();
            int size = connectMatrix.GetLength(0);
            bool[] usedNodes = new bool[size];
            int columnCount = 1;

            for(int i = 0; i < size; i++)
            {
                if (!usedNodes[i])
                {
                    usedNodes[i] = true;
                    queue.Enqueue(i);

                    while(queue.Count != 0)
                    {
                        int currentNode = queue.Dequeue();

                        for(int column = columnCount; column < size; column++)
                            if(connectMatrix[currentNode, column] == 1 && !usedNodes[column])
                            {
                                usedNodes[column] = true;
                                queue.Enqueue(column);
                            }
                    }

                    result++;
                }
            }

            return result;
        }
        private static int GetCyclomaticNumber(int nodes, int edges, int components)
        {
            int result = edges - nodes + components;

            return result;
        }

        private static int[,] GetMinor(int[,] matrix, int column)
        {
            int size = matrix.GetLength(0);
            int[,] minor = new int[size - 1, size - 1];

            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < column; j++)
                    minor[i - 1, j] = matrix[i, j];

                for (int j = column + 1; j < size; j++)
                    minor[i - 1, j - 1] = matrix[i, j];
            }
            return minor;
        }
        private static int[,] GetDistanceMatrix(ref int[,] connectMatrix)
        {
            int size = connectMatrix.GetLength(0);
            int[,] matrixCopy = new int[size, size];

            Array.Copy(connectMatrix, matrixCopy, size * size);
            int columnCounter = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = columnCounter; j < size; j++)
                    if (matrixCopy[i, j] == 0)
                    {
                        matrixCopy[i, j] = 10000;
                        matrixCopy[j, i] = 10000;
                    }
                columnCounter++;
            }

            return matrixCopy;
        }
    }
}
