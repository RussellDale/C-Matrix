public class Student {
  public int StudentID { get; set; }
  public string StudentName { get; set; }
  public int Age { get; set; }  

  public Student(int studentID, string studentName, int age) {
    StudentID = studentID;
    StudentName = studentName;
    Age = age;
  }
}