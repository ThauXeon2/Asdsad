namespace SmartHome;

public abstract class Device
{
    private string? _name;
    private bool _isOn;
    public string? Name { get => _name; set => _name = value; }
    public bool IsOn => _isOn;
    private static int _count = 0;
    public static int Count => _count;

    protected Device(string name)
    {
        Name = name;
        _isOn = false;
        _count++;
    }
    public virtual bool TurnOn()
    {
        if (!IsOn)
        {
            _isOn = true;
            return true;
        }
        return false;
    }
    public virtual bool TurnOff()
    {
        if (IsOn)
        {
            _isOn = false;
            return true;
        }
        return false;
    }
    public virtual string GetDescription() => $"{Name} ({(IsOn ? "be" : "ki")})";
    protected abstract int PowerUsage();

    public int Consumption(int hours)
    {
        if(hours<1 || !IsOn)
            return 0;
        return PowerUsage() * hours;
    }

    public static Device? MoreConsuming(Device first, Device second, int hours)=>first.Consumption(hours)==second.Consumption(hours) ? null : (first.Consumption(hours)>second.Consumption(hours) ? first : second);
    
}