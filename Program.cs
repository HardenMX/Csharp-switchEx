/*

Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/
Random random = new Random();
int anyAttack = random.Next(1, 11);
bool heroAttackFirst = true;

int heroHealth = 10;
int monsterHealth = 10;

var heroInfo = [10, "MyName", true];

Console.WriteLine(heroHealth);
Console.WriteLine(monsterHealth);

do 
{
    Console.WriteLine("Hero attacks first!");
    anyAttack = random.Next(1, 11);
    Console.WriteLine($"And deals {anyAttack} damage");


    Console.WriteLine($"The Monster has {monsterHealth} HP left");
    Console.WriteLine($"The Hero has {heroHealth} HP left");

} while (heroHealth > 0 && monsterHealth > 0);

