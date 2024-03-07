using System;

    internal class Exercise4
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Height(cm):");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Age(years):");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sex(m/f): ");
        char sex = Convert.ToChar(Console.ReadLine());

        Console.WriteLine();
        Greutate greutate = new Greutate(); 

        switch(sex)
        {
            case 'm':
                {
                    float weight = greutate.ManWeight(height, age);
                    greutate.displayWeight(weight);
                    break;
                }
            case 'f':
                {
                    float weight = greutate.WomenWeight(height, age);
                    greutate.displayWeight(weight);
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid choice.");
                    break;
                }

        }
    }
}

class Greutate
{
    public float ManWeight(int height, int age)
    {
        return (float)(height-100-(height-150)/4) + ((age-20)/4);
    }
    public float WomenWeight(int height, int age) {
        return (float)(height - 100 - ((height - 150) / 2.5)) + ((age - 20) / 6);
    }

    public void displayWeight(float weight)
    {
        Console.WriteLine("Your ideal weight is: "+ weight+ " kg.");
    }
}
