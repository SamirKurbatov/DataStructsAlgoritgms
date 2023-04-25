using DataStructs.DuplexList;
using DataStructs.Stack;
using System.Diagnostics.Tracing;


#region LinkedList
//var list = new LinkedList<int>();


//list.Add(2);
//list.Add(3);
//list.Add(4);

//list.InsertAfter(4, 66);


//foreach (var item in list)
//{
//    Console.Write(item + " ");
//}

//Console.ReadLine();
#endregion

#region LinkedStack
//var linkedStack = new LinkedStack<int>();
//linkedStack.Push(10);
//linkedStack.Push(20);
//linkedStack.Push(30);

//Console.WriteLine(linkedStack.Pop());
//Console.WriteLine(linkedStack.Pop());
//Console.WriteLine(linkedStack.Peek());
//Console.ReadLine();

#endregion

#region ArrayStack

//var arrayStack = new ArrayStack<int>(5);
//Console.WriteLine(arrayStack.Count);
//arrayStack.Push(100);
//arrayStack.Push(200);
//Console.WriteLine(arrayStack.Count);
//arrayStack.Push(300);
//arrayStack.Push(400);
//arrayStack.Push(500);

//Console.WriteLine(arrayStack.Peek());
//Console.WriteLine(arrayStack.Pop());
//Console.WriteLine(arrayStack.Pop());
//Console.WriteLine(arrayStack.Peek());

#endregion


#region DuplexList

var duplexList = new DuplexLinkedList<int>();

duplexList.Add(1);
duplexList.Add(2);
duplexList.Add(3);
duplexList.Add(4);
duplexList.Add(5);

foreach (var duplex in duplexList)
{
    Console.Write(duplex + " ");
}

Console.WriteLine("-----");
Console.WriteLine("-----");
Console.WriteLine("-----");
var reverse = duplexList.Reverse();

foreach (var duplex in reverse)
{
    Console.Write(duplex + " ");
}

Console.ReadLine();
#endregion
