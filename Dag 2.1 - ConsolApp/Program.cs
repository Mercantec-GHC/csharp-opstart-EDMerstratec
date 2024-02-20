// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);*/

//int result = Random.Next();

/*Random roll = new();
Console.WriteLine(roll.Next(1, 7));
*/

/*Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First Roll: {roll1}");
Console.WriteLine($"Second Roll: {roll2}");
Console.WriteLine($"Third Roll: {roll3}");
*/

/*int firstValue = 500;
int secondValue = 600;
int[] largerValue = {firstValue,secondValue};


Console.WriteLine(Math.Floor((firstValue+secondValue),largerValue);
//Just use Math.Max(), dummy
*/

/*If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
*/

/*Random dice = new();

int die1 = dice.Next(1, 7);
int die2 = dice.Next(1, 7);
int die3 = dice.Next(1, 7);
int cutoff = 15;
int dieSum = (die1 + die2 + die3);

Console.WriteLine($"You rolled: {dieSum} ({die1},{die2},{die3})");

if (die1 == die2 || die2 == die3 || die1 == die3)
{
    Console.WriteLine("Doubles for +2");
    dieSum += 2;
}
else if (die1 == die2 && die2 == die3)
{
    Console.WriteLine("Triples for +6");
    dieSum += 6;
}

if (dieSum >= cutoff )
{
    Console.WriteLine("Ya win!");
}
else
{
    Console.WriteLine("Ya lose!");
}
*/

/*Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
/* if 10 days, if x days renew and save 10%, if 1 day 20%, if expired, else nothing
 **/
/*
if (daysUntilExpiration < 1)
{
    Console.WriteLine("Expired");
}
else if  (daysUntilExpiration < 2)
{
    Console.WriteLine("One day left");
}
else if (daysUntilExpiration < 6)
{
    Console.WriteLine($"Expires in {daysUntilExpiration} days");
}
else if (daysUntilExpiration < 11)
{
    Console.WriteLine("Expires soon. Ish.");
}
*/

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/
/*
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
*/


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");