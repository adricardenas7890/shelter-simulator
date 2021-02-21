using System;
namespace ShelterSimulator.Models.Location
{
    public interface ILocation
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string PhysicalAddress { get; set; }
    }
}
