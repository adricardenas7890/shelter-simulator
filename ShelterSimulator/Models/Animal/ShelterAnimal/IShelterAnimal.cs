using System;
namespace ShelterSimulator
{
    public interface IShelterAnimal : IAnimal
    {
        public Guid ShelterAnimalID { get; set; }
        public string Name { get; set; }
        public string IntakeType { get; set; }
        public string AdoptionStatus { get; set; }
        public DateTime IntakeDate { get; set; }
        public DateTime AdoptionDate { get; set; }
        public Boolean Adopted { get; set; }
    }
}
