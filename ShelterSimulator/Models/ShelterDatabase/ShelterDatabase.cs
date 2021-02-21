using System;
namespace ShelterSimulator.Models.ShelterDatabase
{
    public class ShelterDatabase
    {
        public Guid AnimalID { get; set; }
        public IShelterAnimal ShelterAnimal { get; set; }

    }
}
