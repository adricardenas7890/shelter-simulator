using System;
namespace ShelterSimulator.Models.ShelterDatabase
{
    public class ShelterDatabase
    {
        // Need to build out structure for DB
        // dbo.ShelterAnimals (PK ShelterAnimalID, FK, AnimalType)
        // dbo.Dogs             (PK DogID, FK ShelterAnimalID)
        // dbo.Cats             (PK CatID, FK ShelterAnimalID)

        // dbo.Locations        (PK LocationID, FK LocationType)
        // dbo.Buildings        (PK BuildingID, FK LocationID)
        // dbo.Homes            (PK HomeID, FK LocationID)

        // dbo.AnimalPlacement  (PK AnimalPlacementID, FK ShelterAnimalID, FK LocationID, FK ManagerID, FK VetID)

        // dbo.Entities         (PK EntityID, FK EntityTypeID)
        // dbo.Staff            (PK StaffID, FK EntityID, FK StaffTypeID)
        // dbo.Adopters         (PK AdopterID, FKEntityID)
    }
}
