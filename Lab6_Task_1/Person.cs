namespace Lab6_Task_1;

public class Person : IShowInfo, IComparable<Person>, ICloneable
{
    private string Name { get; }
    private string Surname { get; }
    private string Patronymic { get; }
    private string Sex { get; }
    private int Age { get; }

    protected Person(string name, string surname, string patronymic, string sex, int age) =>
        (Name, Surname, Patronymic, Sex, Age) = (name, surname, patronymic, sex, age);

    protected Person(Person copy) => (Name, Surname, Patronymic, Sex, Age) =
        (copy.Name, copy.Surname, copy.Patronymic, copy.Sex, copy.Age);
    
    public virtual void Show()
    {
        Console.WriteLine($"\nPerson`s Data:\n Name: {Name};\n Surname: {Surname};\n Patronymic: {Patronymic};\n Sex: {Sex};\n Age: {Age}\n");
    }

    public int CompareTo(Person? other)
    {
        var result = String.Compare(Name, other?.Name, StringComparison.Ordinal);
        if (result != 0) return result;

        result = String.Compare(Surname, other?.Surname, StringComparison.Ordinal);
        if (result != 0) return result;

        result = String.Compare(Patronymic, other?.Patronymic, StringComparison.Ordinal);
        if (result != 0) return result;

        result = String.Compare(Sex, other?.Sex, StringComparison.Ordinal);
        if (result != 0) return result;

        result = Age.CompareTo(other?.Age);
        if (result != 0) return result;

        return 0;
    }

    public object Clone()
    {
        return new Person(this);
    }
}