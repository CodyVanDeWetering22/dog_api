

namespace dog_api.Models;

public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public bool LikesToys { get; set; }
    public int NumberOfLegs { get; set; }
    public Dog(int id, string name, int age, bool likesToys, int numberOfLegs)
    {
        Id = id;
        Name = name;
        Age = age;
        LikesToys = likesToys;
        NumberOfLegs = numberOfLegs;
    }
}

