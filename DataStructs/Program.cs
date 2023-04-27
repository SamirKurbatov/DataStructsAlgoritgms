using DataStructs.DuplexDeque;


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

//var duplexList = new DuplexLinkedList<int>();

//duplexList.Add(1);
//duplexList.Add(2);
//duplexList.Add(3);
//duplexList.Add(4);
//duplexList.Add(5);

//foreach (var duplex in duplexList)
//{
//    Console.Write(duplex + " ");
//}

//Console.WriteLine("-----");
//Console.WriteLine("-----");
//Console.WriteLine("-----");
//var reverse = duplexList.Reverse();

//foreach (var duplex in reverse)
//{
//    Console.Write(duplex + " ");
//}

//Console.ReadLine();
#endregion

#region CircularList

//var list = new CircularList<int>();

//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);
//list.Add(5);


//list.Remove(3);

//foreach (var item in list)
//{
//    Console.Write(item + " ");
//}


//Console.ReadLine();

#endregion

#region EasyQqueue

//var easyQueue = new EasyQueue<int>();

//easyQueue.Enqueue(1);
//easyQueue.Enqueue(2);
//easyQueue.Enqueue(3);

//Console.WriteLine(easyQueue.Dequeue());

#endregion

#region ArrayQueue

//var arrayQueue = new ArrayQueue<int>(5);
//arrayQueue.Enqueue(1);
//arrayQueue.Enqueue(2);
//arrayQueue.Enqueue(3);

//Console.WriteLine(arrayQueue.Dequeue());
//Console.WriteLine(arrayQueue.Peek());
//Console.WriteLine(arrayQueue.Dequeue());
#endregion

#region LinkedQueue

//var linkedQueue = new LinkedQueue<int>();

//linkedQueue.Enqueue(0);
//linkedQueue.Enqueue(1);
//linkedQueue.Enqueue(2);
//linkedQueue.Enqueue(3);
//linkedQueue.Enqueue(4);
//linkedQueue.Enqueue(5);

//Console.WriteLine(linkedQueue.Dequeue());
//Console.WriteLine(linkedQueue.Dequeue());
//Console.WriteLine(linkedQueue.Dequeue());
//Console.WriteLine(linkedQueue.Dequeue());

#endregion

#region EasyDeque
//var easyDequeue = new EasyDeque<int>();

//easyDequeue.PushFront(0);

//easyDequeue.PushBack(1);
//easyDequeue.PushBack(2);
//easyDequeue.PushBack(3);

//Console.WriteLine(easyDequeue.PopBack());
//Console.WriteLine(easyDequeue.PopFront());


#endregion

#region DuplexDequeu

var duplexDequeu = new DuplexLinkedDeque<int>();

duplexDequeu.PushFront(1);
duplexDequeu.PushFront(2);
duplexDequeu.PushFront(3);
duplexDequeu.PushBack(4);
duplexDequeu.PushBack(5);

Console.WriteLine(duplexDequeu.PopFront());
Console.WriteLine(duplexDequeu.PopFront());
Console.WriteLine(duplexDequeu.PopBack());
Console.WriteLine(duplexDequeu.PopBack());
Console.WriteLine(duplexDequeu.PopFront());

#endregion
