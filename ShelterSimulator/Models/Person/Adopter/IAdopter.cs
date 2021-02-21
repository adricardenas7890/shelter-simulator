using System;
namespace ShelterSimulator.Models.Person.Adopter
{
    public interface IAdopter : IPerson
    {
        public Boolean InterestedInDogs { get; set; }
        public Boolean InterestedInCats { get; set; }
        public Boolean InterestedInOtherAnimals { get; set; }
    }
}
