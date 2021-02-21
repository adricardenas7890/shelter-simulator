using System;
using ShelterSimulator.Models.Intake.IntakeShelterAnimal;
using ShelterSimulator.Models.Location.IBuilding;
namespace ShelterSimulator.Areas.Intake
{
    public class IntakeAnimal : IIntakeShelterAnimal
    {

        public bool CanAnimalBeAdmitted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PlaceAnimalInBuilding(IShelterAnimal shelterAnimal, IBuilding building)
        {
            // Place ShelterAnimal object + Building object into Temp DB dbo.AnimalPlacement
            // 
        }

        // TODO: Replace IShelterAnimal with ShelterAnimal
        public void PlaceAnimalInSystem(string name, string age, string gender)
        {
            // Insert ShelterAnimal object into Temp DB dbo.ShelterAnimals
            //
            //return new ShelterAnimal();
        }
    }
}
