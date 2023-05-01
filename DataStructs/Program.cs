using DataStructs.Dictionary;
using DataStructs.DuplexDeque;
using DataStructs.Hash;
using DataStructs.HashTable;
using DataStructs.Map;


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

//var duplexDequeu = new DuplexLinkedDeque<int>();

//duplexDequeu.PushFront(1);
//duplexDequeu.PushFront(2);
//duplexDequeu.PushFront(3);
//duplexDequeu.PushBack(4);
//duplexDequeu.PushBack(5);

//Console.WriteLine(duplexDequeu.PopFront());
//Console.WriteLine(duplexDequeu.PopFront());
//Console.WriteLine(duplexDequeu.PopBack());
//Console.WriteLine(duplexDequeu.PopBack());
//Console.WriteLine(duplexDequeu.PopFront());

#endregion

#region HashSet
//var set = new EasyHashSet<int>(new int[] { 1, 2, 3, 4, 5 });
//var set2 = new EasyHashSet<int>(new int[] { 2, 5, 6, 7, 11 });

//var result = set.Union(set2);

//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}

//var res = set.Intersect(set2);

//Console.WriteLine();
//foreach (var item in res)
//{
//    Console.Write(item + " ");
//}

//var resb = set.Difference(set2);

//foreach (var item in resb)
//{
//    Console.Write(item + " ");
//}


//Console.WriteLine();
//var resc = set.SymmetricDifference(set2);

//foreach (var item in resc)
//{
//    Console.Write(item + " ");
//}
#endregion

#region HashTable

//var hashTable = new HashTable<int>(10);

//hashTable.Add(1);
//hashTable.Add(2);
//hashTable.Add(3);
//hashTable.Add(4);

//Console.Write(hashTable.Search(3));

#endregion

#region EasyMap

//var easyMap = new EasyMap<int, string>();

//easyMap.Add(new Item<int, string>(1, "Один"));
//easyMap.Add(new Item<int, string>(2, "Два"));
//easyMap.Add(new Item<int, string>(3, "Три"));
//easyMap.Add(new Item<int, string>(4, "Четыре"));
//easyMap.Add(new Item<int, string>(5, "Пять"));


//foreach (var item in easyMap)
//{
//    Console.WriteLine(item + " ");
//}

//Console.WriteLine(easyMap.Search(3) ?? "Не найдено");

//easyMap.Remove(3);
//easyMap.Remove(1);

//foreach (var item in easyMap)
//{
//    Console.WriteLine(item + " ");
//}

#endregion

#region Dictionary(Custom)

//var dictionary = new Dict<int, string>();

//dictionary.Add(new Item<int, string>(1, "Самир"));
//dictionary.Add(new Item<int, string>(1, "Самир"));
//dictionary.Add(new Item<int, string>(2, "Боря"));
//dictionary.Add(new Item<int, string>(3, "Член"));
//dictionary.Add(new Item<int, string>(4, "Некит"));
//dictionary.Add(new Item<int, string>(5, "Дюша"));
//dictionary.Add(new Item<int, string>(511, "Пятьсот одинадцать"));


//foreach (var item in dictionary)
//{
//    Console.WriteLine(item + " ");
//}

//dictionary.Remove(5323);
//Console.WriteLine();


//foreach (var item in dictionary)
//{
//    Console.WriteLine(item + " ");
//}

//Console.WriteLine(dictionary.Search(31) ?? "Не найдено");

#endregion


Dictionary<int, string> dict = new();

dict.Add(2, "Самир");

foreach (var item in dict)
{
    Console.WriteLine(item + " ");
}