/*

//activity
string employeeName = ("Elsa Versailles");
string address = ("Manila PH");
string education = ("College");
string contactNumber = ("09128673214");
string emailAdd = ("elsa@coldmail.com");
int expectedSalary = (30000);
int experience = (5);
int age = (24);

Console.WriteLine("Employee Console \n");

Console.WriteLine("Name: " + employeeName);
Console.WriteLine("Address: " + address);
Console.WriteLine("Education: " + education);
Console.WriteLine("Phone #: " + contactNumber);
Console.WriteLine("Email: " + emailAdd);
Console.WriteLine("Salary: " + expectedSalary);
Console.WriteLine("Work Experience: " + experience);
Console.WriteLine("Age: " + age);

int x = 1;
int y = 1;
Console.WriteLine(x + y);
//end of activity

string input = Console.ReadLine();
int exp = Convert.ToInt32(input);
Console.WriteLine("You entered: " + (exp + 1));

double expyr = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Hi " + expyr);

Console.WriteLine(50 / 10 * 100 + 15);

//activty
Console.WriteLine("Enter hours per Day");

string strWorkedHours = Console.ReadLine();
int workedHours = Convert.ToInt32(strWorkedHours);
Console.WriteLine("Enter Day of Work");
string strWorkedDay = Console.ReadLine();
int workedDay = Convert.ToInt32(strWorkedDay);
Console.WriteLine(workedHours * workedDay);
//end of activity
*/


Console.WriteLine("Matriculation Calculator \n");

Console.WriteLine("Enter number of units for Subject 1");
string Sub1unitCount = Console.ReadLine();
float Sub1UnitPrice = float.Parse(Sub1unitCount);
double totalSub1Price = (Sub1UnitPrice * 513.50);


Console.WriteLine("Enter number of units for Subject 2");
string Sub2unitCount = Console.ReadLine();
float Sub2UnitPrice = float.Parse(Sub2unitCount);
double totalSub2Price = (Sub2UnitPrice * 513.50);


Console.WriteLine("Enter number of units for Subject 3");
string Sub3unitCount = Console.ReadLine();
float Sub3UnitPrice = float.Parse(Sub3unitCount);
double totalSub3Price = (Sub3UnitPrice * 513.50);


Console.WriteLine("Enter number of units for Subject 4");
string Sub4unitCount = Console.ReadLine();
float Sub4UnitPrice = float.Parse(Sub4unitCount);
double totalSub4Price = (Sub4UnitPrice * 513.50);


Console.WriteLine("Enter number of units for Subject 5");
string Sub5unitCount = Console.ReadLine();
float Sub5UnitPrice = float.Parse(Sub5unitCount);
double totalSub5Price = (Sub5UnitPrice * 513.50);

Console.WriteLine("Enter your Discount in Percent");
string discount = Console.ReadLine();
float discount1 = float.Parse(discount);
float discountTotal = discount1 / 100;


double total = totalSub1Price + totalSub2Price + totalSub3Price + totalSub4Price + totalSub5Price; 
double subtotal1 = (total * 0.30);
double misc = 800 + subtotal1;

double subTotal = total + misc;
double subtotal2 = subTotal * discountTotal;
double sub = subTotal - subtotal2;

Console.WriteLine("Your tuition fee is: " + sub);
