using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public Dog(string pName, float pAge, string pOwner, Rating pRating)
    {
        name = pName;
        age = pAge;
        owner = pOwner;
        rating = pRating;
    }

    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public override string ToString()
    {
        return "Dog Name: " + name + "\nAge: " + age + "\nOwner: " + owner + "\nRating: " + rating;
    }
}
