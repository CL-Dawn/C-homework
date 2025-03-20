using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Value { get; set; }
            public Node(T value) { Value = value;Next = null;}

        }
        public class GenericList<T>
        {
            public Node<T> head;
            public Node<T> tail;
            public GenericList()
            {
                tail = head = null;
            }
            public Node<T> Head { get => head; }
            public void Add(T value)
            {
                Node<T> n=new Node<T>(value);
                if(tail==null)
                {
                    head=tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action)
            {
                Node<T> node = head;
                while(node != null)
                {
                    action.Invoke(head.Value);
                    node = node.Next;
                }

            }
        }

        static void Main(string[] args)
        {
            GenericList<int>list= new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.ForEach(x=>Console.WriteLine(x));
            int max=list.head.Value;
            list.ForEach(x => { if (x > max) max = x; });
            int min=list.head.Value;    
            list.ForEach(x=> { if (x < min) min = x; });


        }
    }
}
