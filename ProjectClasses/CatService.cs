namespace AnimalStore
{
    public class CatService
    {
        public void SayHello(Cat cat)
        {
            Console.WriteLine($"{cat.Color} cat that weights {cat.WeightInGramms} says Meow");
        }
        public void BringKittensToEatFood(Cat cat)
        {
            foreach (var kitten in cat.Kittens)
            {
                Console.WriteLine($"Cat {cat.Name} carries {kitten.Color} kitten {kitten.Name}");
            }
        }

        public void BringKittensToEatFood(Cat cat, string foodType)
        {
            foreach (var kitten in cat.Kittens)
            {
                Console.WriteLine($"Cat {cat.Name} carries {kitten.Color} kitten {kitten.Name} to eat {foodType}");
            }
        }

        public void BringKittensToEatFood(Cat cat, int maxKittens)
        {
            int kittensToShow = Math.Min(maxKittens, cat.Kittens.Count);
            for (int i = 0; i < kittensToShow; i++)
            {
                Console.WriteLine($"Cat {cat.Name} carries {cat.Kittens[i].Color} kitten #{i + 1} {cat.Kittens[i].Name}");
            }
        }
    }
}
