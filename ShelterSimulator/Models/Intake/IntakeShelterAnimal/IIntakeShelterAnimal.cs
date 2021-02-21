using System;
using ShelterSimulator.Models.Location.IBuilding;

namespace ShelterSimulator.Models.Intake.IntakeShelterAnimal
{
    public interface IIntakeShelterAnimal
    {
        // INFO: Base interface for IntakeDog, IntakeCat... etc.
        // TODO: Check total shelter capacity for CanAnimalBeAdmitted
        //       Remove PlaceAnimalInBuilding and reserve for IntakeDog, IntakeCat... etc. Check building type vs. animal type.
        //
        // NOW:  Assume shelter has unlimited capacity
        //       Assume buildings can hold any type of animal

        public Boolean CanAnimalBeAdmitted { get; set; } // Ideally, this will be determined by building capacity. For now, always true.        
        public void PlaceAnimalInSystem(string name, string gender, string age); // Simple inputs will create new IShelterAnimal object.
        public void PlaceAnimalInBuilding(IShelterAnimal shelterAnimal, IBuilding building); // Insert record into dbo.ShelterPlacements (PK ShelterPlacementID, FK ShelterAnimal, FK BuildingID)
    }
}
