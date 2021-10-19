using System;

// string n = "3";

// int m = 4;

// int r = n + m;

// int y;
// if (n == "3")
// {
//   y = 3;
// }

// System.Console.WriteLine(r);

int age = 0;
bool success = false;

while (success != true)
{
  Console.WriteLine("Your age:");
  string input = Console.ReadLine();

  // int age = int.Parse(input);

  success = int.TryParse(input, out age);
}

if (success == true)
{
  if (age < 18)
  {
    Console.WriteLine("Du får inte ta körkort!");
  }
  else
  {
    Console.WriteLine("Du får ta körkort!");
  }
}


Console.ReadLine();
