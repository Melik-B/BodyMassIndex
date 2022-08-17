//bmi

//ALGORITHM

//1.1 Start.
//1.2 User is prompted for height in meters.
//1.3 The user is prompted for their weight in kilograms.
//1.4 Calculates the user's body mass index.


//vki

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcıdan metre cinsinden boyu istenir.
//1.3 Kullanıcıdan kilogram cinsinden kilosu istenir.
//1.4 Kullanıcının vücut kitle endeksini hesaplanır.



double height = ConvertToDouble("Height (m eg:1,75): ");
double weight = ConvertToDouble("weight (kg): ");
double bmi = IndexCalculation(height, weight);
Console.WriteLine($"Index: {bmi}");
ResultCalculation(bmi);
Console.ReadLine();

static void ResultCalculation(double bmi)
{
    Console.Write("BMİ: ");
    if (bmi < 18)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Underweight");
        Console.ResetColor();
    }
    else if (bmi >= 18 && bmi <= 25)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Normalweight");
        Console.ResetColor();
    }
    else if (bmi >= 25 && bmi < 30)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("Overweight");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Obese");
        Console.ResetColor();
    }
}

static double IndexCalculation(double height, double weight)
{
    return weight / (height * height);
}

static double ConvertToDouble(string text)
{
    Console.Write(text);
    double convertToDouble = Convert.ToDouble(Console.ReadLine());
    return convertToDouble;
}