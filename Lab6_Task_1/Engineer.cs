namespace Lab6_Task_1;

public class Engineer : Employee, IComparable<Engineer>, ICloneable
{
    private string Qualification { get; }

    public Engineer(string name, string surname, string patronymic, string sex, int age, double experience, string qualification) : base(name, surname, patronymic, sex, age, experience)
    {
        Qualification = qualification;
    }

    protected Engineer(Engineer copy) : base(copy)
    {
        Qualification = copy.Qualification;
    }

    public override void Show()
    {
        base.Show();
        
        Console.WriteLine($"Qualification in engineering: {Qualification}\n");
    }

    public int CompareTo(Engineer? other)
    {
        var result = String.Compare(Qualification, other.Qualification, StringComparison.Ordinal);
        return result == 0 ? base.CompareTo(other) : result;
    }

    public new object Clone()
    {
        return new Engineer(this);
    }
}