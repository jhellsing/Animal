using ssss;

namespace ssss
 {
    class Program
    {
        public static void Main(string[] args)
        {
            Veterinar veterinar = new Veterinar();
            Animal[] animal = new Animal[3];
            animal[0] = new Dog("спасает", "корм", "приют");
            animal[1] = new Cat("линяет", "пельмени", "коммунар");
            animal[2] = new Horse("орет", "сено", "ставрово");
            
            for (int i = 0; i < animal.Length; i++)
            {
                veterinar.treatAnimal(animal[i]);
            }


        }  
    }
}
