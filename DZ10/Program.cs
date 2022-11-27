Console.WriteLine("Enter a three-digit integer number");
int number = Convert.ToInt32(Console.ReadLine());
int second_digit = number/10%10;
Console.WriteLine($"The second digit of the number is {second_digit}");

