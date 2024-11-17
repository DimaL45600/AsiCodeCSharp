using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Algorytms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch sw = new Stopwatch();
            //int[] original = GenerateRandomArray(1000, 1, 100);
            //int[] array = original.ToArray();

            //Console.WriteLine(String.Join(", ", array));

            //int iter = 0;
            //int move = 0;
            //bool sorted = true;

            //iter = 0;
            //move = 0;
            //sw.Restart();
            //sw.Start();
            //do
            //{
            //    sorted = true;
            //    iter++;
            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        if (array[i] > array[i + 1])
            //        {
            //            //Console.WriteLine($"{array[i]} < {array[i+1]}");
            //            int temp = array[i];
            //            array[i] = array[i + 1];
            //            array[i + 1] = temp;
            //            sorted = false;
            //            move++;
            //        }
            //    }
            //} while (!sorted);
            //sw.Stop();
            //Console.WriteLine(String.Join(", ", array));
            //Console.WriteLine($"Iteration = {iter}; Move = {move}; Time = {sw.ElapsedTicks.ToString()}");

            //array = original.ToArray();
            //iter = 0;
            //move = 0;
            //sw.Restart();
            //sw.Start();
            //do
            //{
            //    sorted = true;
            //    iter++;
            //    for (int i = 0; i < array.Length-1; i++)
            //    {
            //        if (array[i] > array[i + 1])
            //        {
            //            //Console.WriteLine($"{array[i]} < {array[i+1]}");
            //            int temp = array[i];
            //            array[i] = array[i + 1];
            //            array[i + 1] = temp;
            //            sorted = false;
            //            move++;
            //        }
            //    }
            //    for (int i = array.Length - 1; i > 0; i--)
            //    {
            //        if (array[i] < array[i - 1])
            //        {
            //            //Console.WriteLine($"{array[i]} < {array[i+1]}");
            //            int temp = array[i];
            //            array[i] = array[i - 1];
            //            array[i - 1] = temp;
            //            sorted = false;
            //            move++;
            //        }
            //    }
            //} while (!sorted);
            //sw.Stop();
            //Console.WriteLine(String.Join(", ", array));
            //Console.WriteLine($"Iteration = {iter}; Move = {move}; Time = {sw.ElapsedTicks.ToString()}");

            //sw.Start();
            //array = original.ToArray();
            //QuickSort(array, 0, array.Length - 1);
            //sw.Stop();
            //Console.WriteLine(String.Join(", ", array));
            //Console.WriteLine($"Time = {sw.ElapsedTicks.ToString()}");

            //sw.Start();
            //array = original.ToArray();
            //InsertionSort(array, out iter, out move);
            //sw.Stop();
            //Console.WriteLine(String.Join(", ", array));
            //Console.WriteLine($"Iteration = {iter}; Move = {move}; Time = {sw.ElapsedTicks.ToString()}");


            //void InsertionSort(int[] array, out int iter, out int move )
            //{
            //    iter = 0;
            //    move = 0;
            //    int n  = array.Length;
            //    for (int i = 1; i < n; i++)
            //    {
            //        iter++;
            //        int key = array[i];
            //        int j = i - 1;
            //        while (j >= 0 && array[j] > key)
            //        {
            //            move++;
            //            array[j+1] = array[j];
            //            j--;
            //        }
            //        array[j+1] = key;
            //    }
            //}




            //void QuickSort(int[] array, int low, int high)
            //{
            //    if(low < high)
            //    {
            //        int pivotIndex = Partition(array, low, high);
            //        QuickSort(array, low, pivotIndex-1);
            //        QuickSort(array, pivotIndex + 1, high);
            //    }
            //}

            //int Partition(int[] array, int low, int high)
            //{
            //    int pivot = array[high];
            //    int i = low - 1;

            //    for(int j = low; j < high; j++)
            //    {
            //        if(array[j] < pivot)
            //        {
            //            i++;
            //            int temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }

            //    int swap = array[i + 1];
            //    array[i + 1] = array[high];
            //    array[high] = swap;
            //    return i + 1;
            //}

            //Graph graph = new Graph();
            //graph.addVertex(1);
            //graph.addVertex(2);
            //graph.addVertex(3);
            //graph.addVertex(4);
            //graph.addVertex(5);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(2, 4);
            //graph.AddEdge(4, 3);
            //graph.AddEdge(4, 5);
            //graph.Display();
            //graph.DFS(4);
            //Console.WriteLine("--------------------");
            //graph.BFS(4);

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(10);
            binaryTree.Insert(8);
            binaryTree.Insert(6);
            binaryTree.Insert(9);
            binaryTree.Insert(12);
            binaryTree.Insert(10);
            Console.WriteLine("--------------------");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine("--------------------");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine("--------------------");
            binaryTree.PostOrder(binaryTree.Root);
        }
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[size];

            for(int i = 0; i<size; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

    }


    public class TreeNode
    {
        public int value;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int value)
        {
            this.value = value;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode Root;

        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        public TreeNode InsertRecursive(TreeNode root, int value)
        {
            if (root == null)
            {
                return new TreeNode(value);
            }
            if(value < root.value)
            {
                root.left = InsertRecursive(root.left, value);
            }else if (value > root.value)
            {
                root.right = InsertRecursive(root.right, value);
            }

            return root;
        }

        public void PreOrder(TreeNode node)
        {
            if (node == null) return;

            Console.WriteLine(node.value);
            PreOrder(node.left);
            PreOrder(node.right);
        }

        public void InOrder(TreeNode node)
        {
            if (node == null) return;

            InOrder(node.left);
            Console.WriteLine(node.value);
            InOrder(node.right);
        }

        public void PostOrder(TreeNode node)
        {
            if (node == null) return;

            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node.value);
        }
    }

    public class Graph
    {
        private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

        public void addVertex(int vertex)
        {
            if(!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<int>();
            }
        }
        public void AddEdge(int from, int to)
        {
            if(adjList.ContainsKey(from) && adjList.ContainsKey(to))
            {
                adjList[from].Add(to);
                adjList[to].Add(from);
            }
        }
        public void Display()
        {
            foreach(var vertex in adjList)
            {
                Console.Write($"{vertex.Key}: ");
                foreach(var neighbor in vertex.Value)
                {
                    Console.Write($"{neighbor} ");
                }
                Console.WriteLine();
            }
        }
        public void DFS(int start)
        {
            var visited = new HashSet<int>();
            DFSRecursive(start, visited);
        }
        private void DFSRecursive(int vertex, HashSet<int> visited)
        {
            if (!visited.Contains(vertex))
            {
                Console.WriteLine(vertex.ToString());
                visited.Add(vertex);
                foreach (var neighbor in adjList[vertex])
                {
                    DFSRecursive(neighbor, visited);
                }
            }
        }

        public void BFS(int start)
        {
            var visted = new HashSet<int>();
            var queue = new Queue<int>();

            queue.Enqueue(start);
            visted.Add(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                Console.WriteLine(vertex);

                foreach(var nighbor in adjList[vertex])
                {
                    if (!visted.Contains(nighbor))
                    {
                        queue.Enqueue(nighbor);
                        visted.Add(nighbor);
                    }
                }
            }

        }
    }
}
