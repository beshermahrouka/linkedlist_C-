using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_final
{
    class linkedlist
    {
        private node head;        // this will be the entrance to the linked list
        private node current;    //This will be the last node
       



        // constructor 
        public linkedlist()
        {
            head = new node();
            current = head;
            current.Value = 0;
            current.Next = null;
            
        }





        // add node after the last node
        public void AddAtLast(object data)
        {
            node newNode = new node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
        }



        // add node after head
        public void AddFirst(object data)
        {

            node insert_first = new node();

            insert_first.Value = data;

            insert_first.Next = head.Next;

            head.Next = insert_first;

        }



        // add node after any node 
        public void Add_between(object search_data,object new_data)
        {

            node new_node = new node();
            new_node.Value = new_data;
            node s_node = head;

            while (s_node.Next != null)
            {

                s_node = s_node.Next;

                if (s_node.Value == search_data)
                {

                    new_node.Next = s_node.Next;
                    s_node.Next = new_node;

                }
            }

        }

              // remove node
        public void RemoveNode(object data)
        {

            node rn = head;
            while (rn.Next != null)
            {

                // the object of the removed value is not removed from memory
                if (rn.Next.Value == data)
                {

                    rn.Next = rn.Next.Next;
                }


                rn = rn.Next;

            }







        }

        // replace the value of any node
        public void ReplaceNode(object new_data, object old_data)
        {

            node rn = head;
            while (rn.Next != null)
            {
                rn = rn.Next;
                if (rn.Value == old_data)
                {

                    rn.Value = new_data;
                }


            }

        }


        // get the total elements inside the linked list
        public int Total_Elements()
        {
            int count = 0;


            node counter = head;

            while (counter.Next != null)
            {
                counter = counter.Next;
                count++;

            }


            Console.WriteLine("Total number of Elements:"+" "+count);
            Console.WriteLine();
            return count;   
        }





            // print all nodes inside the linked list
            public void PrintAllNodes()
            {
                //Traverse from head
                Console.Write("Head ->");
                node curr = head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    Console.Write(curr.Value);
                    Console.Write("->");
                }
                Console.Write("NULL");
                Console.WriteLine();
            }







        // print reversed linked-list
        public void ReverseLinkedlist()
        {

            List<object> MyLinkedlist_list = new List<object>();
            Console.Write("head ->");
            node T_node = head;

            while (T_node.Next != null)        // add nodes to the list
            {

                T_node = T_node.Next;


                MyLinkedlist_list.Add(T_node.Value);
            }

            for (int i = MyLinkedlist_list.Count - 1; i >= 0; i--)   //print reversed list (linked list)
            {

                Console.Write(MyLinkedlist_list[i]);
                Console.Write("->");
            }

            Console.Write("NULL");
            Console.WriteLine();

        }












       
    }
}
