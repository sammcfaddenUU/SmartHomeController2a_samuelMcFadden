using SmartHomeController;
using System.Net.NetworkInformation;

public class Program
{
    private static List<SmartDevice> devices = new List<SmartDevice>();
    public static void Main()
    {
        SmartSecurityCamera frontdoorCamera = new SmartSecurityCamera(34,"Front door Camera", "4k");
        SmartLight kitchenLight = new SmartLight(1,"Kitchen Light", 20.5, "Blue");
        SmartSpeaker livingroomSpeaker = new SmartSpeaker(1,"Livingroom Speaker", 10);
        SmartThermostat bathroomThermostat = new SmartThermostat(2,"Bathroom thermostat", 16.0, 19);

        devices.Add(frontdoorCamera);
        devices.Add(kitchenLight);
        devices.Add(livingroomSpeaker);
        devices.Add (bathroomThermostat);
        ViewAllDevices();
    }
    public static void ViewAllDevices()
    {
        SmartDevice device = null;
        Console.WriteLine("List all devices");
        foreach (var smartItem in devices)
        {
            device.GetStatus();
            Console.WriteLine();
        }
    }
}
