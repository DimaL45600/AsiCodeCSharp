namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList2l<string> list = new LinkedList2l<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("Hello");
            list.Print();
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Remove("5"));
            Console.WriteLine(list.Remove("2"));
            list.Print();
            list.Clear();
            list.Print();
        }

    }
    public class Node1l<T>
    {
        public T Data { get; set; }
        public Node1l<T>? Next { get; set; }

        public Node1l(T data)
        {
            Data = data;
        }
    }
    public class Node2l<T>
    {
        public T Data { get; set; }
        public Node2l<T>? Next { get; set; }
        public Node2l<T>? Prev { get; set; }

        public Node2l(T data)
        {
            Data = data;
        }
    }
    public class LinkedList1l<T>
    {
        Node1l<T>? head;
        Node1l<T>? tail;
        int count;

        public void Add(T data)
        {
            Node1l<T> node = new Node1l<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail!.Next = node;
            }
            tail = node;
            count++;
        }
        public bool Remove(T data)
        {
            Node1l<T>? current = head;
            Node1l<T>? prev = null;

            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data))
                {
                    if (prev == null)
                    {
                        head = head?.Next;
                        if (head == null) tail = null;
                    }
                    else
                    {
                        prev.Next = current.Next;

                        if (current.Next == null) tail = prev;
                    }
                    count--;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return head == null; } }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void Print()
        {
            if (!IsEmpty)
            {
                Node1l<T>? current = head;
                while (current != null)
                {
                    Console.Write(current.Data);
                    if (current.Next != null) Console.Write(", ");
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("List empty");
            }
        }
    }
    public class LinkedList2l<T>
    {
        Node2l<T>? head;
        Node2l<T>? tail;
        int count;

        public void Add(T data)
        {
            Node2l<T> node = new Node2l<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail!.Next = node;
                node.Prev = tail;
            }
            tail = node;
            count++;
        }
        public bool Remove(T data)
        {
            Node2l<T>? current = head;

            while (current != null)
            {
                if(current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if(current != null)
            {
                if(current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    tail = current.Prev;
                }

                if(current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }

            return false;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return head == null; } }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void Print()
        {
            if (!IsEmpty)
            {
                Node2l<T>? current = head;
                while (current != null)
                {
                    Console.Write(current.Data);
                    if (current.Next != null) Console.Write(", ");
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("List empty");
            }
        }
    }
}
