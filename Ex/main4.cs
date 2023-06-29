using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Node1;

class Ex4 {
  public static void main4 () {

//       optionsBuilder.UseSqlite(@"Data Source = /home/runner/Rad/Rad2/contoso.db;");
      
//   Ex1.main1();
//   Ex2.main2();
//   Ex3.main3();
//   Example.Main();
    
LinkedList1<Student> ll1 = new LinkedList1<Student>();
    
Node<Student> aa = new Node<Student>( new Student( 1, "Joe", 15 ) );

ll1.AddFirst(aa);  
Console.WriteLine("{0} {1} {2} {3}", aa.Data, aa.Data.StudentID, aa.Data.StudentName, aa.Data.Age );

  ll1.AddAfter(new Node<Student>( new Student( 2, "Don", 17 )), aa);
Console.WriteLine("{0} {1} {2} {3}", aa.Data, aa.Data.StudentID, aa.Data.StudentName, aa.Data.Age );
    
Node<Student> target1 = ll1.Find(aa.Data);
if (target1 != null)
    Console.WriteLine("found: " + target1.Data.StudentName);
else
    Console.WriteLine("foobar");

ll1.Remove(target1);

    
LinkedList1<string> ll = new LinkedList1<string>();

Node<string> a = new Node<string>("aaa");
ll.AddFirst(a);

Node<string> b = new Node<string>("bbb");
ll.AddFirst(b);

Node<string> c = new Node<string>("ccc");
ll.AddFirst(c);

Node<string> d = new Node<string>("ddd");
ll.AddFirst(d);
ll.Traverse();

Console.WriteLine("Add after a");
ll.AddAfter(new Node<string>("xxx"), a);
ll.Traverse();

Node<string> target = ll.Find("ddd");
if (target != null)
    Console.WriteLine("found: " + target.Data);
else
    Console.WriteLine("foobar");

Console.WriteLine("\nremoving " + target.Data);
ll.Remove(target);
ll.Traverse();

    
  }  


}
