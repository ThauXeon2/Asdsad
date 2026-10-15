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
        Console.WriteLine($"{fridge.TurnOFf()} {fridge.GetDescription()}");
        Console.WriteLine(Device.MoreConsuming(heater,dimmableLight,2).Name);
        Console.WriteLine(Device.MoreConsuming(heater,dimmableLight,2).Name);
        

    }
}