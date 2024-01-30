/*
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

Random random = new Random();
int attackDmg;
bool heroAttacksFirst = true;

int heroHealth = 10;
int monsterHealth = 10;
string enemyName = "Monster";
string friendlyName = "Hero";

do 
{
    attackDmg = random.Next(1, 11);
    if (heroAttacksFirst == true) {
        monsterHealth -= attackDmg;
        Console.WriteLine($"{enemyName} was damaged and lost {attackDmg} health and now has {monsterHealth} health");
        heroAttacksFirst = false;
    }
    else if (heroAttacksFirst == false){
        heroHealth -= attackDmg;
        Console.WriteLine($"{friendlyName} was damaged and lost {attackDmg} health and now has {heroHealth} health");
        heroAttacksFirst = true;
    }

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");

