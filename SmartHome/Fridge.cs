namespace SmartHome;

public class Fridge : Device
{
    private bool _isEcoMode;
    public bool IsEcoMode { get => _isEcoMode; set => _isEcoMode = value; }
    public Fridge(string name, bool isEcoMode) : base(name)
    {
        IsEcoMode = isEcoMode;
        TurnOn();
    }
    protected override int PowerUsage() => IsEcoMode ? 100 : 150;
    public new string GetDescription() => $"{Name} ({(IsOn ? "be" : "ki")}), {(IsEcoMode ? "eco mód" : "normál mód")}";
    public new bool TurnOFf() => false;
}