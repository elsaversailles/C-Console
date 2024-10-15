using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("End of Year Pay");
            Console.WriteLine("Enter your monthly pay \n");

            Console.WriteLine("January: ");
            double jan = double.Parse(Console.ReadLine());

            Console.WriteLine("February: ");
            double feb = double.Parse(Console.ReadLine());

            Console.WriteLine("March: ");
            double march = double.Parse(Console.ReadLine());

            Console.WriteLine("April: ");
            double april = double.Parse(Console.ReadLine());

            Console.WriteLine("May: ");
            double may = double.Parse(Console.ReadLine());

            Console.WriteLine("June: ");
            double june = double.Parse(Console.ReadLine());

            Console.WriteLine("July: ");
            double july = double.Parse(Console.ReadLine());

            Console.WriteLine("August: ");
            double august = double.Parse(Console.ReadLine());

            Console.WriteLine("September: ");
            double sep = double.Parse(Console.ReadLine());

            Console.WriteLine("October: ");
            double oct = double.Parse(Console.ReadLine());

            Console.WriteLine("November: ");
            double nov = double.Parse(Console.ReadLine());

            Console.WriteLine("December: ");
            double dec = double.Parse(Console.ReadLine());

            Console.WriteLine("Years of stay");
            double stay = double.Parse(Console.ReadLine());

            //13th month pay

            double monthTotal = (jan +  feb + march + april + may + june + july + august + sep + oct + nov+ dec);
            double month13 = (monthTotal / 12);

            //14th month pay
            if (stay <= 5)
            {
                double month14 = (month13 * 0.70);
                if (monthTotal < 20400)
                {
                    Console.WriteLine("13th Month: ");
                    Console.WriteLine(month13);
                    Console.WriteLine("14th Month: ");
                    Console.WriteLine(month14);
                    Console.WriteLine("Gross Earnings: ");
                    double gross = (month13 + month14);
                    if (gross < 20400)
                    {
                        Console.WriteLine(gross);
                        double deduction = (0);
                        Console.WriteLine("Deductions");
                        Console.WriteLine(deduction);
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine("13th Month: ");
                    Console.WriteLine(month13);
                    Console.WriteLine("14th Month: ");
                    Console.WriteLine(month14);
                    Console.WriteLine("Gross Earnings: ");
                    Console.WriteLine(month13 + month14);
                    double gross = (month13 + month14);
                    if (gross < 20400)
                    {
                        Console.WriteLine(gross);
                        double deduction = (0);
                        Console.WriteLine("Deductions");
                        Console.WriteLine(deduction);
                        Console.ReadKey(true);
                    }
                }
            }

            else if (stay >= 6)
            {
                double month14 = (month13 * 0.90);
                if (monthTotal < 20400)
                {
                    Console.WriteLine("13th Month: ");
                    Console.WriteLine(month13);
                    Console.WriteLine("14th Month: ");
                    Console.WriteLine(month14);
                    Console.WriteLine("Gross Earnings: ");
                    double gross = (month13 + month14);
                    Console.WriteLine(gross);
                    double deduction = (0);
                    Console.WriteLine("Deductions");
                    Console.WriteLine(deduction);
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("13th Month: ");
                    Console.WriteLine(month13);
                    Console.WriteLine("14th Month: ");
                    Console.WriteLine(month14);
                    Console.WriteLine("Gross Earnings: ");
                    Console.WriteLine(month13 + month14);
                    double gross = (month13 + month14);
                    Console.WriteLine(gross);
                    double deduction = (gross - 20400);
                    double ded1 = (deduction * 0.05);
                    Console.WriteLine("Deduction: ");
                    Console.WriteLine(ded1);
                    Console.ReadKey(true);
                }
            }

            else
            {
                double month14 = (month13 * 1.10);
                if (monthTotal < 20400)
                {
                    Console.WriteLine("13th Month: ");
                    Console.WriteLine(month13);
                    Console.WriteLine("14th Month: ");
                    Console.WriteLine(month14);
                    Console.WriteLine("Gross Earnings: ");
                    double gross = (month13 + month14);
                    if (gross < 20400)
                    {
                        Console.WriteLine(gross);
                        double deduction = (0);
                        Console.WriteLine("Deductions");
                        Console.WriteLine(deduction);
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine("13th Month: ");
                    Console.WriteLine(month13);
                    Console.WriteLine("14th Month: ");
                    Console.WriteLine(month14);
                    Console.WriteLine("Gross Earnings: ");
                    Console.WriteLine(month13 + month14);
                    double gross = (month13 + month14);
                    if (gross > 20400)
                    {
                        Console.WriteLine(gross);
                        double deduction = (gross - 20400);
                        double ded1 = (deduction * 0.05);
                        Console.WriteLine("Deduction: ");
                        Console.WriteLine(ded1);
                        Console.ReadKey(true);
                    }
                }
            }
        }
        }
    }
