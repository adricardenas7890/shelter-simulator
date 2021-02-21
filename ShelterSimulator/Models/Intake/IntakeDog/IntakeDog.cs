using System;
using ShelterSimulator.Models.Intake.IntakeDog;

namespace ShelterSimulator.Models.Intake.IntakeDog
{
    public class IntakeDog : IIntakeDog
    {
        public bool CanAnimalBeAdmitted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddDogScoreToSystem(IDog dog, IDogScore dogScore)
        {
            
        }

        public void PlaceAnimalInSystem()
        {
            throw new NotImplementedException();
        }

        public void PlaceAnimalInBuilding()
        {
            throw new NotImplementedException();
        }

    }
}
