namespace SmartHome;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        
        DimmableLight dimmableLight = new("Nappali lámpa",75);
        Console.WriteLine(dimmableLight.GetDescription());
        Console.WriteLine($"{dimmableLight.TurnOn()}, {dimmableLight.TurnOn()}");
        Console.WriteLine($"{dimmableLight.GetDescription()} {dimmableLight.Consumption(5)}");

        Heater heater = new("Fürdőszobai fűtés",22);
        Console.WriteLine($"{heater.GetDescription()} {heater.Consumption(5)} {Device.Count}");
        Console.WriteLine($"{heater.TurnOn()}");
        heater.OpenWindow();
        Console.WriteLine($"{heater.TurnOn()}");
        heater.CloseWindow();
        Console.WriteLine($"{heater.TurnOn()}");

        Fridge fridge = new("Konyhai hűtő", false);
        Console.WriteLine($"{fridge.GetDescription()} {fridge.Consumption(24)}");
        Console.WriteLine($"{fridge.TurnOff()} {fridge.GetDescription()}");
        Console.WriteLine(Device.MoreConsuming(heater,dimmableLight,2).Name);
        Console.WriteLine(Device.MoreConsuming(heater,dimmableLight,2).Name);

        EnergyMeter energyMeter = new(10000);
        Console.WriteLine($"{energyMeter.Run(heater, 3)}, {energyMeter.Remaining()}");
        Console.WriteLine($"{energyMeter.Run(fridge, 24)}, {energyMeter.Remaining()}");
        Console.WriteLine($"{energyMeter.Run(dimmableLight, 5)}, {energyMeter.Remaining()}");
        Console.WriteLine($"{energyMeter.Run(heater, 3)}, {energyMeter.Remaining()}");
        Console.WriteLine($"{energyMeter.Run(fridge, 24)}, {energyMeter.Remaining()}");
        Console.WriteLine(heater.GetDescription());
        Console.WriteLine(fridge.GetDescription());

    }
}