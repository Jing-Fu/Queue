using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStruct
{
    public class QueueNode
    {
        public int data { get; private set; }
        public QueueNode nextNode;
        public QueueNode(int data)
        {
            this.data = data;
        }
    }
    public class Queue
    {
        private int length;
        private QueueNode topNode;
        private QueueNode tailNode;
        public bool IsEmpty { get { return (topNode == null); } }
        public void Enqueue(int data)
        {
            if (IsEmpty)
            {
                topNode = new QueueNode(data);
                tailNode = topNode;
                length++;
                return;
            }

            tailNode.nextNode = new QueueNode(data);
            tailNode = tailNode.nextNode;
            length++;
        }

        public int Dequeue()
        {
            int data;
            if (IsEmpty)
            {
                throw new Exception("Empty");
            }
            else
            {
                data = topNode.data;
                topNode = topNode.nextNode;
                length--;
            }
            return data;
        }

        public int Peek()
        {
            return topNode.data;
        }

        public void ShowQueue()
        {
            if (IsEmpty)
            {
                return;
            }

            QueueNode currNode = topNode;
            while (currNode != null)
            {
                Console.WriteLine(currNode.data);
                currNode = currNode.nextNode;
            }
        }

        public int Capacity()
        {
            return length;
        }
    }
}