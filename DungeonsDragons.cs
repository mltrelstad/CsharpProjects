/* This program helps create a profile for a character
 * to be used in a game of Dungeons & Dragons.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;

abstract class CharacterInfo
{
    public string Name { get; set; }
    public string Gender { get; set; }

    public abstract string FightingStyle { get; }
    public abstract string PowerType { get; set; }
    public abstract string HealingType { get; set; }

    public virtual void Introduction()
    {
        Console.WriteLine($"Welcome, {Name}!");
        Console.WriteLine($"You are a {Gender} {FightingStyle}.");
        Console.WriteLine($"Your power type is {PowerType} and your healing type is {HealingType}.");
    }
}

class Fighter : CharacterInfo
{
    public override string FightingStyle => "Fighter";
    public override string PowerType { get; set; }
    public override string HealingType { get; set; }
}

class Wizard : CharacterInfo
{
    public override string FightingStyle => "Wizard";
    public override string PowerType { get; set; }
    public override string HealingType { get; set; }
}

class Paladin : CharacterInfo
{
    public override string FightingStyle => "Paladin";
    public override string PowerType { get; set; }
    public override string HealingType { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("You have entered the world of DUNGEONS & DRAGONS");
        Console.WriteLine("================================================\r\n");
        Console.WriteLine("You are looking at the fighter style classes. \nBe warned, you will be in the thick of all the fighting!\r\n");
        Console.WriteLine("Please enter your character's name:");
        string name = Console.ReadLine();

        Console.Write("Enter your their gender: ");
        string gender = Console.ReadLine();

        Console.WriteLine("Choose a class:");
        Console.WriteLine("1. Fighter");
        Console.WriteLine("2. Wizard");
        Console.WriteLine("3. Paladin");
        Console.Write("Enter the class number: ");
        int classChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose a power type:");
        Console.WriteLine("1. Magic");
        Console.WriteLine("2. Nature");
        Console.WriteLine("3. Demonic");
        Console.Write("Enter the power type number: ");
        int powerChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose a healing type:");
        Console.WriteLine("1. Hands-On");
        Console.WriteLine("2. Item");
        Console.WriteLine("3. Spell");
        Console.Write("Enter the healing type number: ");
        int healingChoice = int.Parse(Console.ReadLine());
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();

        CharacterInfo character;
        string characterClass;

        switch (classChoice)
        {
            case 1:
                character = new Fighter();
                characterClass = "Fighter";
                break;
            case 2:
                character = new Wizard();
                characterClass = "Wizard";
                break;
            case 3:
                character = new Paladin();
                characterClass = "Paladin";
                break;
            default:
                Console.WriteLine("Invalid class choice. Exiting program.");
                return;
        }

        character.Name = name;
        character.Gender = gender;
        string characterPower;

        switch (powerChoice)
        {
            case 1:
                if (character is Fighter)
                {
                    ((Fighter)character).PowerType = "Magic";
                }
                else if (character is Wizard || character is Paladin)
                {
                    character.PowerType = "Magic";
                }
                characterPower = "Magic";
                break;
            case 2:
                character.PowerType = "Nature";
                characterPower = "Nature";
                break;
            case 3:
                character.PowerType = "Demonic";
                characterPower = "Demonic";
                break;
            default:
                Console.WriteLine("Invalid power type choice. Exiting program.");
                return;
        }

        string characterHeal;
        switch (healingChoice)
        {
            case 1:
                if (character is Fighter)
                {
                    ((Fighter)character).HealingType = "Hands-On";
                }
                else if (character is Wizard || character is Paladin)
                {
                    character.HealingType = "Hands-On";
                }
                characterHeal = "Hands-On";
                break;
            case 2:
                character.HealingType = "Item";
                characterHeal = "Item";
                break;
            case 3:
                if (character is Fighter || character is Wizard)
                {
                    character.HealingType = "Spell";
                }
                else if (character is Paladin)
                {
                    ((Paladin)character).HealingType = "Spell";
                }
                characterHeal = "Spell";
                break;
            default:
                Console.WriteLine("Invalid healing type choice. Exiting program.");
                return;
        }
        Console.WriteLine("- - - - - - - - - - - - - - -");
        Console.WriteLine("Your Character:\n");
        Console.WriteLine("Name: " + name + "\n" +
                          "Class: " + characterClass + "\n" +
                          "Power: " + characterPower + "\n" +
                          "Healing: " + characterHeal);
        Console.WriteLine("- - - - - - - - - - - - - - -");
        Console.ReadLine();
    }
}
    