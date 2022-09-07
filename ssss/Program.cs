using ssss;

namespace ssss
 {
    class Program
    {
        public static void Main(string[] args)
        {
            Veterinar veterinar = new Veterinar();
            Animal[] animal = new Animal[3];
            animal[0] = new Dog(spasat: "спасает", food: "корм", location: "приют");
            animal[1] = new Cat(linyat: "линяет", food: "пельмени", location: "коммунар");
            animal[2] = new Horse(oret: "орет", food: "сено", location: "ставрово");
            Console.WriteLine(animal[0]);
            Console.WriteLine(animal[1]);
            Console.WriteLine(animal[2]);
            Console.WriteLine(veterinar.treatAnimal);

        }  
    }
}
