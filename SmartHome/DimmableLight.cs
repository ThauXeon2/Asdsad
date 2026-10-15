namespace SmartHome;

public class DimmableLight : Device
{
    private int _brightness;
    public int Brightness{
        get => _brightness;
        set
        {
            if(value<0)
                _brightness = 0;
            if(value>100)
                _brightness = 100;
            _brightness = value;
        }
        
    }
    public DimmableLight(string name, int brightness) : base(name)=> Brightness = brightness;
    protected override int PowerUsage() => (int)(Brightness / 10);
    public new string GetDescription() => $"{Name} ({(IsOn ? "be" : "ki")}), fényerő: {Brightness}%";
}