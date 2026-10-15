namespace SmartHome;

public class Heater : Device
{
    private int _targetTemperature;

    public int TargetTemperature
    {
        get => _targetTemperature;
        set
        {
            if(value is >=5 and <=30)
                _targetTemperature = value;
            _targetTemperature = 20;
        }
    }
    public Heater(string name, int targetTemperature) : base(name)=>TargetTemperature = targetTemperature;
    protected override int PowerUsage()=>TargetTemperature*100;
    public new string GetDescription() => $"{Name} ({(IsOn ? "be" : "ki")}), fényerő: {TargetTemperature}°C";
    private bool _isWindowOpen;
    public bool IsWindowOpen=>_isWindowOpen;
    public void OpenWindow()
    {
        _isWindowOpen = true;
        TurnOff();
    }

    public void CloseWindow()=>_isWindowOpen = false;

    public override bool TurnOn()
    {
        if (IsOn || IsWindowOpen)
            return false;
        return base.TurnOn();
    }
}