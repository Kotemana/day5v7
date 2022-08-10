using RestCountries;

namespace AnimalStore
{
    public class Cat
    {
        public string Name { get; set; }
        public int WeightInGramms { get; set; } = 3000;
        public CatColor Color { get; set; }
        public List<Cat> Kittens { get; set; } = new List<Cat>();
        public Country CountryOfOrigin { get; set; } = Country.Georgia;
        
        public Cat()
        {

        }
        public Cat(string name)
        {
            Name = name;
        }
        

    }
}