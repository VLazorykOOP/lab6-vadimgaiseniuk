namespace Lab6_Task_1;

public class Employee : Person, IComparable<Employee>, ICloneable
{

    private double Experience { get; }
    
    public Employee(string name, string surname, string patronymic, string sex, int age, double experience) : base(name, surname, patronymic, sex, age)
    {
        Experience = experience;
    }

    public Employee(Employee copy) : base(copy)
    {
        Experience = copy.Experience;
    }

    public override void Show()
    {
        base.Show();

        Console.WriteLine($"Employee`s experience: {Experience}\n");
    }

    public int CompareTo(Employee? other)
    {
        var result = Experience.CompareTo(other?.Experience);
        return result == 0 ? base.CompareTo(other) : result;
    }

    public object Clone()
    {
        return new Employee(this);
    }
}
