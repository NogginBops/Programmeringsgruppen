using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();

            a.Add(10);

            a.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine(a.Get(0) + "  " + a.Get(1));
            
            LinkedList<int> b = new LinkedList<int>();

            b.Add(10);

            b.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine(b.Get(0) + "  " + b.Get(1));

            Console.ReadKey();
        }
    }

    class List<T>
    {
        T[] array;
        int carret;

        public List()
        {
            array = new T[1];
            carret = 0;
        }

        public void Add(T obj)
        {
            if (carret >= array.Length)
            {
                T[] temp = array;

                array = new T[carret + 5];

                Array.Copy(temp, array, temp.Length);
            }
            array[carret] = obj;
            carret++;
        }

        public T Get(int i)
        {
            return array[i];
        }

        public int Length()
        {
            return carret;
        }
    }

    class LinkedList<T>
    {
        class Node
        {
            public T value;
            public Node next;
            public Node prev;

            public Node(T value)
            {
                this.value = value;
            }

            public void SetPrev(Node prev)
            {
                this.prev = prev;
            }

            public void SetNext(Node next)
            {
                this.next = next;
            }
        }

        Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node(value);
                return;
            }

            Node temp = head;

            head = new Node(value);

            head.SetNext(temp);

            temp.SetPrev(head);
        }

        public T Get(int i)
        {
            Node node = head;

            while (i-- > 0)
            {
                node = node.next;
            }

            return node.value;
        }

        public int Length()
        {
            if (head == null)
            {
                return 0;
            }

            Node node = head;

            int length = 0;

            while (node.next != null)
            {
                node = node.next;
                length++;
            }

            return length;
        }
    }
}
