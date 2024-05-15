using GmlCore.Interfaces.Servers;

namespace Gml.Models.Servers;


public class MinecraftServer : IProfileServer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Port { get; set; }
}
