using System;
namespace ShelterSimulator.Models.Person.Adopter
{
    public interface IAdopter : IPerson
    {

        public Boolean InterestedInDogs { get; set; }
        public Boolean InterestedInCats { get; set; }
        public Boolean InterestedInOtherAnimals { get; set; }
        public Boolean SmallAnimals { get; set; }
        public Boolean MediumAnimals { get; set; }
        public Boolean LargeAnimals { get; set; }
        public Boolean SpecialNeeds { get; set; }
        public Boolean HouseTrained { get; set; }

    }
}
