namespace Lab6_Task_1;

public static class Program
{
    public static void Main()
    {
        var person = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 0);
        var employee = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2);
        var employee1 = new Employee("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.1);
        var worker = new Worker("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 2.6, "Microsoft");
        var engineer = new Engineer("Vadim", "Gaiseniuk", "Anatoliyovich", "Male", 19, 1.4, "Bachelor");
        
        person.Show();
        Console.WriteLine("---------------------------------------------");
        employee.Show();
        Console.WriteLine("---------------------------------------------");
        worker.Show();
        Console.WriteLine("---------------------------------------------");
        engineer.Show();
        Console.WriteLine("---------------------------------------------");
        
        Console.WriteLine($"person == employee: {person.CompareTo(employee)}");
        Console.WriteLine($"employee == employee2: {employee.CompareTo(employee1)}");
        Console.WriteLine($"worker == engineer: {worker.CompareTo(engineer)}");

        var personCopy = person.Clone() as Employee;
        Console.WriteLine($"person == personCopy: {person.CompareTo(personCopy)}");
    }
}