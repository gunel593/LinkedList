using LinkedList;
using System.Collections.Generic;
using System.Runtime.InteropServices;

CustomLinkedLisT list = new CustomLinkedLisT();
list.AddFirst(0);
list.AddFirst(1);
list.AddFirst(2);
list.AddLast(3);
list.RemoveAtFirst(1);
//list.RemoveLast(0);
list.InserAfter(list.First, 5);
list.InserBefore(list.Next, 6);
list.Print();
