using System;
namespace ShelterSimulator
{
    public interface IDog : IAnimal
    {       
        public string Size { get; set; }
        public string Breed { get; set; }
        public Boolean Intact { get; set; }
    }
}
