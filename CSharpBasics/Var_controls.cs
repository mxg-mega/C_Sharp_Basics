// // Integer variable
// int age = 25;

// // Floating-point variable
// float height = 5.9f;

// // Double variable
// double weight = 70.5;

// // Character variable
// char grade = 'A';

// // Boolean variable
// bool isEnrolled = true;

// // String variable
// string name = "Alice";

// int num1 = 10;
// int num2 = 5;

// // Display variables in the console
// Console.WriteLine("Name: " + name);
// Console.WriteLine("Age: " + age);
// Console.WriteLine("Height: " + height + " ft");
// Console.WriteLine("Weight: " + weight + " kg");
// Console.WriteLine("Grade: " + grade);
// Console.WriteLine("Enrolled: " + isEnrolled);
// Console.WriteLine("\n-------- Hello, World! ---------\n");


// Console.WriteLine("Basic Calculator\n");
// int sum = num1 + num2;
// Console.WriteLine("Sum: " + sum);

// int difference = num1 - num2;
// Console.WriteLine("Subtraction: " + difference);

// int multiplicataion = num1 * num2;
// Console.WriteLine("Multiplication: " + multiplicataion);

// int division = num1 / num2;
// Console.WriteLine("Division: " + division);

// int modulus = num1 % num2;
// Console.WriteLine("Modulus: " + modulus);

// Console.WriteLine("\n------- Flow Control -------\n");

// int score = 85;

// // Using if-else
// if (score >= 90)
// {
//     Console.WriteLine("Grade: A");
// }
// else if (score >= 80)
// {
//     Console.WriteLine("Grade: B");
// }
// else if (score >= 70)
// {
//     Console.WriteLine("Grade: C");
// }
// else
// {
//     Console.WriteLine("Grade: F");
// }

// // Using switch
// int day = 3; // Let's say 1=Monday, 2=Tuesday, etc.

// switch (day)
// {
//     case 1:
//         Console.WriteLine("It's Monday!");
//         break;
//     case 2:
//         Console.WriteLine("It's Tuesday!");
//         break;
//     case 3:
//         Console.WriteLine("It's Wednesday!");
//         break;
//     case 4:
//         Console.WriteLine("It's Thursday!");
//         break;
//     case 5:
//         Console.WriteLine("It's Friday!");
//         break;
//     case 6:
//         Console.WriteLine("It's Saturday!");
//         break;
//     case 7:
//         Console.WriteLine("It's Sunday!");
//         break;
//     default:
//         Console.WriteLine("Unknown day.");
//         break;
// }
// Console.WriteLine("\n-------- Simple Calculator -------\n");

// Console.WriteLine("Simple Calculator");

// Console.Write("Enter first number: ");
// num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Choose an operation:");
// Console.WriteLine("1. Addition");
// Console.WriteLine("2. Subtraction");
// Console.WriteLine("3. Multiplication");
// Console.WriteLine("4. Division");
// Console.WriteLine("5. Modulus");
// Console.Write("Enter your choice (1/2/3/4): ");
// int choice = Convert.ToInt32(Console.ReadLine());

// switch (choice)
// {
//     case 1:
//         Console.WriteLine("Addition");
//         Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
//         break;
//     case 2:
//         Console.WriteLine("Subtraction");
//         Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
//         break;
//     case 3:
//         Console.WriteLine("Multiplication");
//         Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
//         break;
//     case 4:
//         Console.WriteLine("Division");

//         if (num2 > 0)
//         {
//             Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
//         }
//         else
//         {
//             Console.WriteLine("Cannot divide by Zero");
//         }
//         break;
//     case 5:
//         Console.WriteLine("Remainder (Modulus)");

//         if (num2 != 0)
//         {
//             Console.WriteLine($"Result: {num1} % {num2} = {num1 % num2}");
//         }
//         else
//         {
//             Console.WriteLine("Cannot divide by Zero");
//         }

//         break;

//     default:
//         Console.WriteLine("Invalid Option!! Please input a valid option");
//         break;
// }