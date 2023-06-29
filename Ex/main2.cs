using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Ex2 {
  public static void main2 () {

//       optionsBuilder.UseSqlite(@"Data Source = /home/runner/Rad/Rad2/contoso.db;");

        object[,] objsale = {
           {"Cash", 150, 130.40, "100"},
           {"AP",   250.0, 230, 220 }
         };
    
    ArrayList myAL = new ArrayList();
      myAL.Add("Hello");
      myAL.Add("World");
      myAL.Add("!");

      Console.WriteLine( "myAL" );
      Console.WriteLine( "    Count:    {0}", myAL.Count );
      Console.WriteLine( "    Capacity: {0}", myAL.Capacity );
      Console.Write( "    Values:" );
      PrintValues( myAL );

		IList<Student> studentList = new List<Student>() { 
				new Student( 1, "John", 13 ),      
  			new Student( 2, "Moin", 21 ), 
				new Student( 3, "Bill", 18 ),  
				new Student( 4, "Ram", 20 ), 
				new Student( 5, "Ron", 15), 
			};   
    
		var teenAgerStudent = from s in studentList
							  where s.Age > 12 && s.Age < 20
							  select s;
		Console.WriteLine("Teen age Students:");
						  
		foreach(Student std in teenAgerStudent)	
			Console.WriteLine(std.StudentName);

string[] names = {"Bill", "Steve", "James", "Mohan" };

var myLinqQuery = from name in names
                where name.Contains('a')
                select name;
    
foreach(var name in myLinqQuery)
    Console.Write(name + " ");     

  }   
  
  public static void PrintValues( IEnumerable myList )  {
      foreach ( Object obj in myList )
         Console.Write( "   {0}", obj );
      Console.WriteLine("\n");
    }

}

