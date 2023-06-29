using System;
using System.Collections;
using System.Linq;


class Ex1 {

  public static void main1 () {
        String[,] sale2022 = { { "Cash", "150" }, { "AP", "170" }, { "Inv", "230" }, { "Fun", "340" } };
        String[,] sale2021 = { { "Cash", "130" }, { "AP", "160" }, { "Inv", "220" }, { "Fun", "330" } };
        object[,] sale2020 = { { "Cash", "100" }, { "AP", "150" }, { "Inv", "200" }, { "Fun", "310" } };

        bs(sale2022); bs(sale2021); bs(sale2020);

        object[,] sale = {
          {"Cash", "150500600", "130", "100"},
          {"AP", "170", 160, "150"},
          {"Inv", "230", "220", "200"},
          {"Fun", 350.00, "330", "310"} };

        bs(sale);

        object[][,] jsale = new object[3][,]
        {
          new object[,] { {1, 2}, {3, 4}, {5, 6} },
          new object[,] { {10, 20} },
          new object[,] { {30} }
        };

        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", jsale.GetType(), jsale.Rank,
                          jsale.Length);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", jsale.GetType(), jsale[0].Rank,
                          jsale[0].Length);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", jsale.GetType(), jsale[1].Rank,
                          jsale[1].Length);
//Console.WriteLine("The object has {0} dimension(s) and a total of {1} elements.", jsale[3].Rank, jsale[3].Length);
   
        object[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] jmax1 = new object[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] { };

        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", jmax1.GetType(), jmax1.Rank,
                          jmax1.Length);

        Array myArr = Array.CreateInstance(typeof(int), 2, 3, 4);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", myArr.GetType(), myArr.Rank,
                          myArr.Length);

        Array myArr1 = Array.CreateInstance(typeof(long), 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", myArr1.GetType(), myArr1.Rank,
                          myArr1.Length);

        Array myArr2 = Array.CreateInstance(typeof(System.Linq.Enumerable), 3);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", myArr2.GetType(), myArr2.Rank,
                          myArr2.Length);
    
        DateTime[,] dt1 = {};
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", dt1.GetType(), dt1.Rank,
                          dt1.Length);

        Array dt2 = Array.CreateInstance(typeof(DateTime), 1, 2, 1);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", dt2.GetType(), dt2.Rank,
                          dt2.Length);
    
        Program[,,] pr1 = new Program[,,] {};  
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", pr1.GetType(), pr1.Rank,
                          pr1.Length);

        Array pr2 = Array.CreateInstance(typeof(Program), 1, 4, 6, 8);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", pr2.GetType(), pr2.Rank,
                          pr2.Length);
    
        Console.WriteLine();

        object[] values = { "word", true, 120, 136.3405, 'a',
                             typeof(byte), typeof(object), typeof(Array), typeof(System.Linq.Enumerable),
                             typeof(DateTime) };

        foreach (var value in values)
            Console.WriteLine("{0} - type {1}", value, value.GetType().Name);
        Console.WriteLine();

        object[,] objsale = {
           {"Cash", 150, 130.40, "100"},
           {"AP",   250.0, 230, 220 }
         };

        foreach (var value in objsale)
            Console.WriteLine("{0} - type {1}", value, value.GetType().Name);
    
        int[] intArray = new int[] {2, 3, 4};
        Action<int> action = new Action<int>(ShowSquares);
        Array.ForEach(intArray, action);
    
//        byte[] jsale1 = new byte[499999999];
        byte[] jsale1 = new byte[399999999];
    
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", jsale1.GetType(), jsale1.Rank,
                          jsale1.Length);
    
        Array.Resize<byte>(ref jsale1, 1);
        Console.WriteLine("The {0} has {1} dimension(s) and a total of {2} elements.", jsale1.GetType(), jsale1.Rank,
                          jsale1.Length);        
  }

  public static void ShowSquares(int val)
  {
     Console.WriteLine("{0:d} squared = {1:d}", val, val*val);
  }
  
  public static void bs(object[,] strbs)
  {
        var rLow = strbs.GetLowerBound(0);
        var rUpp = strbs.GetUpperBound(0);
        //           Console.WriteLine($"{rLow} {rUpp}");
        for (var r = rLow; r <= rUpp; r++)
        {
            object bs = null;
            var cLow = strbs.GetLowerBound(1);
            var cUpp = strbs.GetUpperBound(1);
            //           Console.WriteLine($"{cLow} {cUpp}");
            for (var c = cLow; c <= cUpp; c++)
            {
                if (bs == null)
                    bs = strbs[r, c];
                else                 
                    bs = bs + " " + Convert.ToInt64(strbs[r, c]).ToString("C");
            }
            Console.WriteLine(bs);
        }
        Console.WriteLine();
  }  
}
