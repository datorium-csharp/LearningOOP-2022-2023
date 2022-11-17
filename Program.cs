
class Human
{
    public string name;
    public int age;
    public string eyeColor = "Blue";

    public void Introduce()
    {
        Console.WriteLine($"Hey, my name is {this.name} and I am {this.age} years old.");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"I am eating {food}.");
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
        var human1 = new Human();//new virtual human is born
        human1.name = "Anna";
        human1.age = 16;
        //Console.WriteLine($"Hi, my name is {human1.name} and I am {human1.age} years old.");
        human1.Introduce();
        Console.WriteLine($"{human1.name} has {human1.eyeColor} eyes.");
        human1.Eat("avocado");
        human1.StopEating();

        var human2 = new Human();
        human2.name = "Markus";
        human2.age = 19;
        human2.eyeColor = "Brown";
        human2.Introduce();
        Console.WriteLine($"{human2.name} has {human2.eyeColor} eyes.");
    }
}
