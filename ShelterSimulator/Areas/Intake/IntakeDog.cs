using System;
using ShelterSimulator.Models.Intake.IntakeDog;
using ShelterSimulator.Models.Location.IBuilding;


namespace ShelterSimulator.Areas.Intake
{
    public class IntakeDog : IIntakeDog
    {

        public bool CanAnimalBeAdmitted { get; set; }

        public  void CreateDogRecord(IShelterAnimal shelterAnimal) 
        {
        }

        public void AddDogToSystem(IDog dog)
        {

        }

        public void AddDogScoreToSystem(IDog dog, IDogScore dogScore)
        {
            throw new NotImplementedException();
        }

        public void PlaceAnimalInBuilding(IShelterAnimal shelterAnimal, IBuilding building)
        {
            throw new NotImplementedException();
        }

        public void PlaceAnimalInSystem(string name, string gender, string age)
        {
            // Insert 
        }
    }
}
