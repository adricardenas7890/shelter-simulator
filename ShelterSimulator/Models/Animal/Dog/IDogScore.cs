using System;
namespace ShelterSimulator
{
    public interface IDogScore
    {
        public int DoesWellALone { get; set; }
        public int Children { get; set; }
        public int Cats { get; set; }
        public Boolean HouseBroken { get; set; }
        public Boolean CrateTrained { get; set; }
    }
}
