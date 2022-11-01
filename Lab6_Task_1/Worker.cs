namespace Lab6_Task_1;

public class Worker : Employee, IComparable<Worker>, ICloneable
{
    private string Workplace { get; }

    public Worker(string name, string surname, string patronymic, string sex, int age, double experience, string workplace) : base(name, surname, patronymic, sex, age, experience)
    {
        Workplace = workplace;
    }

    protected Worker(Worker copy) : base(copy)
    {
        Workplace = copy.Workplace;
    }

    public override void Show()
    {
        base.Show();
        Console.Write($"Workplace: {Workplace}\n");
    }

    public int CompareTo(Worker? other)
    {
        var result = String.Compare(Workplace, other?.Workplace, StringComparison.Ordinal);
        return result == 0 ? base.CompareTo(other) : result;
    }

    public new object Clone()
    {
        return new Worker(this);
    }
}