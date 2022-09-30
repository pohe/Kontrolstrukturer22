// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//int age = 57;
//Console.WriteLine("Starting to check age...");
//if (age < 18)
//{
//    Console.WriteLine("You are still a child...");
//}
//Console.WriteLine("Finished checking age");

//if (age < 18)
//    Console.WriteLine("You are still a child...");
//else
//    Console.WriteLine("You are an adult!");


//if (age > 12)
//{
//    if (age < 20)
//    {
//        Console.WriteLine("You are a teenager");
//    }
//}

//if (age > 12 && age < 20)
//{
//    Console.WriteLine("You are a teenager");
//}


int age = 25;
string message = "You are ";

//if (age < 18)
//{
//    message = message + "a child.";
//}
//else
//{
//    message = message + "an adult.";
//}

//message = message + ((age < 18) ? "a child." : "an adult.");




//Console.WriteLine(message );


//int score = 55;
//if (score >= 90)
//{
//    Console.WriteLine("Mark is: A");
//}
//else if (score >= 70)
//{
//    Console.WriteLine("Mark is: B");
//}
//else if (score >= 40)
//{
//    Console.WriteLine("Mark is: C");
//}
//else
//{
//    Console.WriteLine("Mark is: D");
//}


//int score = 55;
//if (score >= 90  && score <= 100)
//{
//    Console.WriteLine("Mark is: A");
//}
//if (score >= 70 && score <= 89)
//{
//    Console.WriteLine("Mark is: B");
//}
//if (score >= 40 && score <=69)
//{
//    Console.WriteLine("Mark is: C");
//}
//if (score >=0 && score <= 39)
//{
//    Console.WriteLine("Mark is: D");
//}
int childSupport = 0;
int noOfChildren = 2;
switch (noOfChildren)
{
    case 0:
        childSupport = 0;
        break;
    case 1:
        childSupport = 1200;
        break;
    case 2:
        childSupport = 2000;
        break;
    case 3:
        childSupport = 2600;
        break;
    default:
        childSupport = 3000;
        break;
}

