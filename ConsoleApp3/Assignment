using System;

public class Assignment
{
    public static void Main(string[] args)
    {
        // Declare gwa variable
        double gwa = 0;
        
        // Getting input for prelim grade
        Console.WriteLine("Enter Prelim grade:");
        string prelim = Console.ReadLine();
        double Prelim = double.Parse(prelim);
        
        // Getting input for midterm grade
        Console.WriteLine("Enter Midterm grade:");
        string midterm = Console.ReadLine();
        double Midterm = double.Parse(midterm);
        
        // Getting input for finals grade
        Console.WriteLine("Enter Finals grade:");
        string finals = Console.ReadLine();
        double Finals = double.Parse(finals);
        
        // Calculating the weighted grades
        double Prelims2 = (0.30 * Prelim);
        double Midterms2 = (0.30 * Midterm);
        double Finals2 = (0.40 * Finals);
        
        // Calculating the final grade
        double FinalGrade = Prelims2 + Midterms2 + Finals2;
        
        // Determine the GWA based on the final grade using the image criteria
        if (FinalGrade >= 97 && FinalGrade <= 100)
        {
            gwa = 1.0;
        }
        else if (FinalGrade >= 94 && FinalGrade <= 96)
        {
            gwa = 1.25;
        }
        else if (FinalGrade >= 91 && FinalGrade <= 93)
        {
            gwa = 1.5;
        }
        else if (FinalGrade >= 89 && FinalGrade <= 90)
        {
            gwa = 1.75;
        }
        else if (FinalGrade >= 86 && FinalGrade <= 88)
        {
            gwa = 2.0;
        }
        else if (FinalGrade >= 83 && FinalGrade <= 85)
        {
            gwa = 2.25;
        }
        else if (FinalGrade >= 81 && FinalGrade <= 82)
        {
            gwa = 2.5;
        }
        else if (FinalGrade >= 78 && FinalGrade <= 80)
        {
            gwa = 2.75;
        }
        else if (FinalGrade >= 75 && FinalGrade <= 77)
        {
            gwa = 3.0;
        }
        else if (FinalGrade < 75)
        {
            gwa = 5.0; // For grades below 75
        }
        
        // Display the final grade and GWA
        Console.WriteLine("Your final semester grade is: " + FinalGrade);
        Console.WriteLine("Your GWA is: " + gwa);
    }
}
