Random random = new Random(); 

int dice1 = random.Next(1,7);
int dice2 = random.Next(1,7);

int sum = dice1 + dice2;

Console.WriteLine($"Tärning 1: {dice1}"); 
Console.WriteLine($"Tärning 2: {dice2}");
Console.WriteLine($"Summan av tärningarna: {sum}");

if (sum == 12)
{
    Console.WriteLine("Grattis! Du har vunnit!");

}
else
{
    Console.WriteLine("Tyvärr, du har inte vunnit den här gången."); 
}
