﻿

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");




/*
Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);
*/


// Acesso direto o metodo Random.Next()
// int result = Random.Next();
