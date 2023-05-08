using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;

            Next = null;

        }
    }
    public class CustomLinkedLisT
    {
        Node _head;
    
        public Node First => _head;
      
        public Node Next
        {
            get
            {
                return GetLastNode();
            }
        }
        int _count;

        public int Count
        {
            get
            {
                if (_count < 0)
                {
                    _count = 0;

                }
                return _count;
            }
            private set

            {
                _count = value;

            }

        }

        public Node GetLastNode()
        {
            Node tmp = _head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            return tmp;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            Count++;
            if (_head != null)
            {
                newNode.Next = _head;
            }
            _head = newNode;

        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            Count++;
            if (_head == null) {
                _head = newNode;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.Next = newNode;
        }
        public Node Find(int data) {
            Node tmp = _head;
            while (tmp.Next != null)
            {
                if (tmp.Data == data)
                {
                    return tmp;
                }
                tmp = tmp.Next;
            }
            return null;
        }
        public void RemoveAtFirst(int data) {

            if (data < 0)
            {
                throw new ArgumentOutOfRangeException("index" + data);
            }
            Node newNode = new Node(data);

            if (_head != null)
            {
                _head = _head.Next;
                return;

            }

            Count--;
            return;

        }
        

       
      // public void RemoveLast(int data)
      //    {
      //      Node newNode = new Node(data);
      //     if(_head != null)
   
      //              _head.Next=_head;
           
      //      _count--;   
        

      //}
      public void InserAfter(Node newNode,int  data)
        {      
            Node newNode2 = new Node(data);


            if (newNode==null)
            {
                Console.WriteLine("The given previous node"
                           + " cannot be null");
               
                return;
            }
            
            newNode2.Next = newNode.Next;
            newNode.Next = newNode2;
            
        }
        
        public void InserBefore(Node noder,int data)
        {
            Node newNode2 = new Node(data);
            Node currentNode = _head;
            while (currentNode != null&& currentNode.Next!=noder) {
                currentNode = currentNode.Next; 
            }
            newNode2.Next = noder;

            if(currentNode != null)
            {
                currentNode.Next = newNode2;
            }
            else
            {
                _head = newNode2;
            }
        }
        
             
            public void Print()
        {
            Node tmp =_head;
            while(tmp.Next != null)
            {
                Console.WriteLine(tmp.Data);
                tmp = tmp.Next;
            }
            Console.WriteLine(tmp.Data);
        }


        

    }

}
