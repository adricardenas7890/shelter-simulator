using System;
using ShelterSimulator.Models.Intake.IntakeShelterAnimal;

namespace ShelterSimulator.Models.Intake.IntakeDog
{
    public interface IIntakeDog : IIntakeShelterAnimal
    {
        public void AddDogScoreToSystem(IDog dog, IDogScore docScore);
    }
}
