using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Ex3 {
  public static void main3 () {

//       optionsBuilder.UseSqlite(@"Data Source = /home/runner/Rad/Rad2/contoso.db;");
  
    
 //   Ex1.main1();
//    Ex2.main2();

        object[,] objsale = {
           {"Cash", 150, 130.40, "100"},
           {"AP",   250.0, 230, 220 }
         };

//    Console.WriteLine( "tmp         Count:    {0} dtIn: {1} dtOut: {2}", myAL.Count, dtIn.ToString(), dtOut.ToString() );
    
//         IList<Student[]> studentArr2;

//          IList<object[,]> objsales;
    
//        for(int i = 0; i < 2000000; i++)
//          objsales.Add(new object { {"Cash", 150, 130.40, "100"} } );
    
        var a = new[] { 1, 10, 100, 1000 }; // int[]
        var b = new[] { "hello", null, "world" }; // string[]

        // single-dimension jagged array
        var c = new[]
        {
            new[]{1,2,3,4},
            new[]{5,6,7,8,9}
        };

        // jagged array of strings
        var d = new[]
        {
            new[]{"Luca", "Mads", "Luke", "Dinesh"},
            new[]{"Karen", "Suma", "Frances"}
        };
    


      var contacts = new[]
      {
        new {
             Name = " Eugene Zabokritski",
             PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
        },
        new {
             Name = " Hanying Feng",
             PhoneNumbers = new[] { "650-555-0199" }
        }
     };

    ArrayList myAL = new ArrayList();

    DateTime dtIn = DateTime.Now;
    
    for(int i = 0; i < 9000000; i++)
      myAL.Add(i);

    DateTime dtOut = DateTime.Now;

    Console.WriteLine( "myAL -         Count:    {0} dtIn: {1} dtOut: {2}", myAL.Count, dtIn.ToString(), dtOut.ToString() );
    
    myAL.Clear();
    
		IList<int> myList = new List<int>() { };

    dtIn = DateTime.Now;
    
		for(int i = 0; i < 9000000; i++)
      myList.Add(i);

    dtOut = DateTime.Now;

    Console.WriteLine( "myList -       Count:    {0} dtIn: {1} dtOut: {2}", myList.Count, dtIn.ToString(), dtOut.ToString() );
    
    myList.Clear();

    IList<object> student2s = new List<object>() {};
    int iCount = 0;

    dtIn = DateTime.Now;

    for(int x = 0; x < 50; x++) {
      for(int i = 0; i < 2000000; i++)
    			student2s.Add(new Student( 1, "John", 13 ) );
      
     iCount += student2s.Count;
    
       student2s.Clear();
    } 
    dtOut = DateTime.Now;
    
     Console.WriteLine( "student2s -    Count:    {0} dtIn: {1} dtOut: {2}", iCount, dtIn.ToString(), dtOut.ToString() );
     
		IList<Student> student3s = new List<Student>();
    
    dtIn = DateTime.Now;
    for(int i = 0; i < 2000000; i++)
			student3s.Add(new Student( 1, "John", 13 ));
    dtOut = DateTime.Now;

     Console.WriteLine( "student3s -    Count:    {0} dtIn: {1} dtOut: {2}", student3s.Count, dtIn.ToString(), dtOut.ToString() );

    student3s.Clear();
    
    IList<Student[]> student4s = new List<Student[]>() {};

    dtIn = DateTime.Now;
//    for(int i = 0; i < 2000000; i++)                   
//    			student4s.Add( new Student() { StudentID = 1, StudentName = "John", Age = 13 } );
        
    dtOut = DateTime.Now;
    
    Console.WriteLine( "student4s -    Count:    {0} dtIn: {1} dtOut: {2}", student4s.Count, dtIn.ToString(), dtOut.ToString() );
    
  }   

}