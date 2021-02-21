using System;
using ShelterSimulator.Models.Intake.IntakeShelterAnimal;
namespace ShelterSimulator.Models.Intake.IntakeCat
{
    public interface IIntakeCat : IIntakeShelterAnimal
    {
        public void AddCatScoreToSystem();      
    }
}
