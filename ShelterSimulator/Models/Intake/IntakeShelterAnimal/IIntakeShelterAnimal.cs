using System;
namespace ShelterSimulator.Models.Intake.IntakeShelterAnimal
{
    public interface IIntakeShelterAnimal
    {
        public Boolean CanAnimalBeAdmitted { get; set; }
        public void PlaceAnimalInSystem();
        public void PlaceAnimalInBuilding();
    }
}
