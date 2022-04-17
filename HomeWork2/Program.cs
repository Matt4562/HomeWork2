// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;


string greeting = "Kā tevi sauc?";

Console.WriteLine(greeting);

string userName = Console.ReadLine();

String userGreating = "Sveiks, " + userName + "!";

Console.WriteLine(userGreating);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Kāds ir tavs vecums?");

int userNumber = int.Parse(Console.ReadLine());
int addedToUserNumber = userNumber + 1;

Console.WriteLine("Nākamgad tev paliks " + addedToUserNumber);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
int fourthNumber = int.Parse(Console.ReadLine());


int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine(maxNumber);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber1 = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber1 = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber1 = int.Parse(Console.ReadLine());


int firstMinNumber = Math.Min(firstNumber1, secondNumber1);
int secondMinNumber = Math.Min(firstMinNumber, thirdNumber1);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);

Console.WriteLine(minNumber);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber2 = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber2 = int.Parse(Console.ReadLine());

int result = firstNumber2 % secondNumber2;
Console.WriteLine(result);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi skaitli");

int number = int.Parse(Console.ReadLine());

bool isEven = number % 2 == 0;

Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
double firstNumber3 = double.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi otro skaitli");
double secondNumber3 = double.Parse(Console.ReadLine());

double area = firstNumber3 * secondNumber3;
double toRound = Math.Round(area, 2);

Console.WriteLine(toRound);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu, ievadi trijstūra malas garumu");
int number1 = int.Parse(Console.ReadLine());

int area1 = number1 * number1 / 2;
Console.WriteLine(area1);



Console.WriteLine();
Console.WriteLine("===============================================================");
Console.WriteLine();



Console.WriteLine("Lūdzu ievadi savu vārdu");
string userName2 = Console.ReadLine();

Console.WriteLine("Lūdzu ievadi savu vecumu");
int userAge = Console.ReadLine().Length;

Console.WriteLine($"Sveiks {userName2}, tavs vecums ir {userAge}.");




