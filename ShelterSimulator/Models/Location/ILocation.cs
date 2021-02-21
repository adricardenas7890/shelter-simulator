using System;
namespace ShelterSimulator.Models.Location
{
    public interface ILocation
    {
        // Parent interface 
        // Home + Building to inherit 

        public string Name { get; set; }
        public string PhysicalAddress { get; set; }
    }
}
