using bridge.logic;

try
{
    Console.WriteLine("Enter the bridge: ");
    var bridge = Console.ReadLine();

    var myBridge = new MyBridge(bridge);
    myBridge.isvalidbridge(bridge);


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}