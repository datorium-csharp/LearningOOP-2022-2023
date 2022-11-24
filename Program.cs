
class Human
{
    public static string ClassName = "Human";
    public static int Count = 0;

    public string name;
    public int age;
    public string eyeColor = "Blue";

    public Human(string argName, int argAge)
    {
        this.name = argName;
        this.age = argAge;
        Console.WriteLine($"Hello, {this.name} is born!");
        Human.Count++;
    }
    
    public void Introduce()
    {
        Console.WriteLine($"Hey, my name is {this.name} and I am {this.age} years old.");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{this.name} is eating {food}.");
    }

    public void StopEating()
    {
        Console.WriteLine("I have stopped eating.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        List<Human> humans = new List<Human>();

        humans.Add(new Human("Anna", 16));
        humans.Add(new Human("John", 20));
        humans.Add(new Human("Jenifer", 5));
        humans.Add(new Human("Oskars", 25));
        humans.Add(new Human("Indrek", 18));
        humans.Add(new Human("Teele", 22));
        humans.Add(new Human("Alex", 19));

        Console.WriteLine($"You have spawned {Human.Count} humans.");

        for (int i = 0; i < humans.Count; i++)
        {
            humans[i].Introduce();
        }

        foreach (var human in humans)
        {
            human.Eat("Avocado");
        }        
    }
}
