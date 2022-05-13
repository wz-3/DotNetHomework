using System;

namespace homework4
{
    class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T data { get; set; }
            public Node(T t)
            {
                Next = null;
                data = t;
            }
        }
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public GenericList()
            {
                tail = head = null;
            }
            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action)
            {
                for (Node<T> n = head; n != null; n = n.Next)
                {
                    action(n.data);
                }
            }
        }
        static void Main(string[] args)
            {
                GenericList<int> intList = new GenericList<int>();
                Console.WriteLine("请输入链表元素个数");    
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入链表元素范围");
                int lowerBound = int.Parse(Console.ReadLine());
                int upperBound = int.Parse(Console.ReadLine());
                Random random = new Random();
                for (int i=0;i<=x;i++)
                {
                    intList.Add(random.Next(lowerBound, upperBound));
                }
                intList.ForEach(Console.WriteLine);
                double maxNum=0, minNum=0,sum=0;
                intList.ForEach(n =>
                {
                    maxNum = (n > maxNum) ? n : maxNum;
                    minNum = (n < minNum) ? n : minNum;
                    sum = sum + n;
                });
                Console.WriteLine();
                Console.WriteLine("最大值为"+maxNum);
                Console.WriteLine("最小值为"+minNum);
                Console.WriteLine("和为"+sum);
            }
        
    }
}

