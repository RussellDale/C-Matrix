public class Sports
{
   public class Nested {}
  
   private string[] types = { "Baseball", "Basketball", "Football",
                              "Hockey", "Soccer", "Tennis",
                              "Volleyball", "" };

    public int Length { get => types.Length; }
  
//  public T this [int i] => arr[i];
  
   public string this[int i]
   {
      get => types[i];
      set => types[i] = value;
   }
}