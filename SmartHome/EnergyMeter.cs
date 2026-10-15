namespace SmartHome;

public class EnergyMeter
{
    private int _limit;
    private int _used;
    public int Limit => _limit;
    public int Used => _used;

    public EnergyMeter(int limit)
    {
        _limit = limit;
        _used = 0;
    }

    public bool Run(Device device, int hours)
    {
        if ((_used += device.Consumption(hours)) < _limit)
        {
            _used+=device.Consumption(hours);
            return true;
        }
        return false;
    }
}