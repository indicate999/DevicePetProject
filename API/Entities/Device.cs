using System;

namespace API.Entities;

public class Device
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string ModelName { get; set; }
    public string OperatingSystem { get; set; }
}
