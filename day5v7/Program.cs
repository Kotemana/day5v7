using AnimalStore;

var cat = new Cat("Vasiliy");
var service = new CatService();
service.SayHello(cat);
cat.Kittens.Add(new Cat("Barsik") { Color = CatColor.Ginger });
cat.Kittens.Add(new Cat("Roma") { Color = CatColor.GingerWhite });
cat.Kittens.Add(new Cat() { Name = "Nyasha", Color = CatColor.Black });

service.BringKittensToEatFood(cat);
Console.WriteLine("now with string");
service.BringKittensToEatFood(cat, "Milk");
Console.WriteLine("now with max");
service.BringKittensToEatFood(cat, 2);