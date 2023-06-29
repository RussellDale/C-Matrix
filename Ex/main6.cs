using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Node1;

public class Ex6 {
  public static void main6 () {
    Sports sports = new Sports();

    Console.WriteLine("sports {0}", sports[0]);

    Console.WriteLine("sports {0}", sports[7]);
    sports[7] = "Scoccer - Woman";
    Console.WriteLine("sports {0}", sports[7]);

    Sports.Nested nested = new Sports.Nested();
    
    string str = sports[7];
    Console.WriteLine("sports {0}", str);
    
    for(var i = 0; i <= sports.Length - 1; i++)
       Console.WriteLine("sports {0}", sports[i]);
    
        var students = new Dictionary<int, StudentName>()
        {
            { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
            { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
            { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
        };

        foreach(var index in Enumerable.Range(111, 3))
        {
            Console.WriteLine($"Student {index} is {students[index].FirstName} {students[index].LastName}");
        }
        Console.WriteLine();		
   
    LinkedListNode<String> lln = new LinkedListNode<String>("orange");

    LinkedList<String> ll = new LinkedList<String>();
    ll.AddLast(lln);
    ll.AddFirst("red");
    ll.AddLast("yellow");
    
    Console.WriteLine("Count: {0} Prev: {1} Curr: {2} Next: {3}",
      lln.List.Count, lln.Previous.Value, lln.Value, lln.Next.Value);
    
    LinkedList<String>.Enumerator em = ll.GetEnumerator();

     while (em.MoveNext()) {
       string val = em.Current;
       Console.WriteLine(val);
     }    

//    List<int[]> larrint = new List<int[]>() { { 1 }, { 2 } };
  
//    larrint.Add({ {1}, {2} });
    
    List<Student[]> larrstudent = new List<Student[]>();
//    larrstudent.Add(new Student[]() );
    
 
    List<Student> lstudents = new List<Student>();
		lstudents.Add(new Student( 1, "John", 13 ));      
  	lstudents.Add(new Student( 2, "Moin", 21 ));
		lstudents.Add(new Student( 3, "Bill", 18 ));  
		lstudents.Add(new Student( 4, "Ram", 20 )); 
		lstudents.Add(new Student( 5, "Ron", 15));
        
        foreach (Student val in lstudents)
        {
            Console.WriteLine("Student: {0} StudentID: {1} StudentName: {2} Age: {3}", 
              val, val.StudentID, val.StudentName, val.Age);
        }

    List<Student>.Enumerator em2 = lstudents.GetEnumerator();
     
     while (em2.MoveNext()) {
       Student val = em2.Current;
       Console.WriteLine("Student: {0} StudentID: {1} StudentName: {2} Age: {3}", 
              val, val.StudentID, val.StudentName, val.Age);
       }   

    LinkedList<Student> llstudent = new LinkedList<Student>();
		llstudent.AddFirst(new Student( 1, "John", 13 ));   
    
    Console.WriteLine("Count: {0}", llstudent.Count);

    foreach(Student val in llstudent)
        {
            Console.WriteLine("Student: {0} StudentID: {1} StudentName: {2} Age: {3}", 
              val, val.StudentID, val.StudentName, val.Age);
        }
    
    LinkedList<Student>.Enumerator em1 = llstudent.GetEnumerator();
 
     while (em1.MoveNext()) {
       Student val = em1.Current;
       Console.WriteLine("Student: {0} StudentID: {1} StudentName: {2} Age: {3}", 
              val, val.StudentID, val.StudentName, val.Age);
       } 
    
    LinkedListNode<Student> llnstudent = new LinkedListNode<Student>(new Student( 5, "Ron", 15 ));

    llstudent.AddLast(llnstudent); 
    Console.WriteLine("Count: {0}", llnstudent.List.Count);
 
    llstudent.AddFirst(new Student( 2, "Moin", 21 )); 
    Console.WriteLine("Count: {0}", llnstudent.List.Count);

    llstudent.AddLast(new Student( 3, "Bill", 18 )); 
    Console.WriteLine("Count: {0}", llnstudent.List.Count);
    
   Console.WriteLine("Count: {0} Prev: {1} Curr: {2} Next: {3}",
     llnstudent.List.Count, llnstudent.Previous.Value.StudentName, 
     llnstudent.Value.StudentName, llnstudent.Next.Value.StudentName);
    


    List<Part[]> arrpart = new List<Part[]>();

//    List<Part[]> arrpart1 = new List<Part[]>() { PartName = "crank arm", PartId = 1234 } ;

    
//    arrpart.Add(new Part[] { { PartName = "crank arm", PartId = 1234 } ,
//                             { PartName = "chain ring" , PartId = 1434 }  } );
    
        List<Part> parts = new List<Part>();

        // Add parts to the list.
        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
        parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

        // Write out the parts in the list. This will call the overridden ToString method
        // in the Part class.
        Console.WriteLine();    
        foreach (Part aPart in parts)
        { 
            Console.WriteLine("{0} - PartName: {1} PartId: {2}", 
              aPart, aPart.PartName, aPart.PartId);
        }

    Console.WriteLine("empart:");
    
    List<Part>.Enumerator empart = parts.GetEnumerator();

     while (empart.MoveNext()) {
      Part  val = empart.Current;
      Console.WriteLine(val);
     }    
   
    
        // Check the list for part #1734. This calls the IEquatable.Equals method
        // of the Part class, which checks the PartId for equality.
        Console.WriteLine("\nContains(\"1734\"): {0}",
        parts.Contains(new Part { PartId = 1734, PartName = "" }));

        // Insert a new item at position 2.
        Console.WriteLine("\nInsert(2, \"1834\")");
        parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

        //Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }

        Console.WriteLine("\nParts[3]: {0}", parts[3]);

        Console.WriteLine("\nRemove(\"1534\")");

        // This will remove part 1534 even though the PartName is different,
        // because the Equals method only checks PartId for equality.
        parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }
        Console.WriteLine("\nRemoveAt(3)");
        // This will remove the part at index 3.
        parts.RemoveAt(3);

        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }


List<string> dinosaurs = new List<string>();

Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

dinosaurs.Add("Tyrannosaurus");
dinosaurs.Add("Amargasaurus");
dinosaurs.Add("Mamenchisaurus");
dinosaurs.Add("Deinonychus");
dinosaurs.Add("Compsognathus");
Console.WriteLine();
foreach(string dinosaur in dinosaurs)
{
    Console.WriteLine(dinosaur);
}

Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
Console.WriteLine("Count: {0}", dinosaurs.Count);

Console.WriteLine("\nContains(\"Deinonychus\"): {0}",
    dinosaurs.Contains("Deinonychus"));

Console.WriteLine("\nInsert(2, \"Compsognathus\")");
dinosaurs.Insert(2, "Compsognathus");

Console.WriteLine();
foreach(string dinosaur in dinosaurs)
{
    Console.WriteLine(dinosaur);
}

// Shows accessing the list using the Item property.
Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);

Console.WriteLine("\nRemove(\"Compsognathus\")");
dinosaurs.Remove("Compsognathus");

Console.WriteLine();
foreach(string dinosaur in dinosaurs)
{
    Console.WriteLine(dinosaur);
}

    Console.WriteLine("emdino:");
    
    List<String>.Enumerator emdino = dinosaurs.GetEnumerator();

     while (emdino.MoveNext()) {
       string val = emdino.Current;
       Console.WriteLine(val);
     }    
    
dinosaurs.TrimExcess();
Console.WriteLine("\nTrimExcess()");
Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
Console.WriteLine("Count: {0}", dinosaurs.Count);

dinosaurs.Clear();
Console.WriteLine("\nClear()");
Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
Console.WriteLine("Count: {0}", dinosaurs.Count);

  }
}
