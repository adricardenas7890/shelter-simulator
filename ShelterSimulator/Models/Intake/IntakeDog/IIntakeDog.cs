using System;
using ShelterSimulator.Models.Intake.IntakeShelterAnimal;

namespace ShelterSimulator.Models.Intake.IntakeDog
{
    public interface IIntakeDog : IIntakeShelterAnimal
    {
        // TODO:    Consider moving AddDogScoreToSystem, this may need update/insert functionality independent of this.
        //          
        public void CreateDogRecord(IShelterAnimal shelterAnimal); // Create Dog from ShelterAnimal instance (PK DogID, FK ShelterDogID)
        public void AddDogToSystem(IDog dog); // Will add Dog record to dbo.Dogs (PK DogID, FK, ShelterDogID)
        public void AddDogScoreToSystem(IDog dog, IDogScore docScore); // Will add DogScore record on dbo.DogScore (PK DogScoreID, FK, DogID)
    }
}
