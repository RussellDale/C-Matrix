public class Employee
{
    public int Salary;

    public Employee() { }

    public Employee(int annualSalary)
    {
        Salary = annualSalary;
    }
/*
    public Employee(int weeklySalary, int numberOfWeeks)
    {
        Salary = weeklySalary * numberOfWeeks;
    }
*/
    public Employee(int weeklySalary, int numberOfWeeks)
        : this(weeklySalary * numberOfWeeks)
    {
    }  
}
