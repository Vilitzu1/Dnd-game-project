using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    internal class UI
    {

        public void AskCharacterStats(ref Character thisDude)
        {

            int tmp;
            Console.WriteLine("Start by entering Character information");
            Console.Write("Give Character a name: ");
            thisDude.SetName(Console.ReadLine());

            Console.Write("Give Character a level: ");
            int.TryParse(Console.ReadLine(), out tmp);
            thisDude.SetLevel(tmp);

            Console.Write("Next give it a strength value: ");
            int.TryParse(Console.ReadLine(), out tmp);
            thisDude.SetStrength(tmp);


        }

        public void CopyrightText()
        {
            var today = DateTime.Now;
            Console.WriteLine("Welcome to play Shadow Combat Dungeon text adventure!");
            Console.WriteLine("Copyright Vili Finnilä 2023");
            Console.WriteLine("It is " + today);
            Console.WriteLine("");

        }

        public void ClearConsole()
        {
            Console.WriteLine("Clearing console!");
            Console.Clear();
        }

        public void NameofTheHero(string name)
        {
            Console.Write(name);




        }

        public void NameofTheVillain(string name)
        {
            Console.Write(name);


        }

        public void StartGame(string name)
        {
            ClearConsole();
            CopyrightText();

            Console.WriteLine("You awake in a cold, stone, dark room. You feel dizzy and have trouble remembering");
            Console.WriteLine("anything about your past or future.");
            Wait();
            Console.Write("You know your name is " + name);

        }

        public void ContinueStory()
        {
            Console.WriteLine("You grope around in the darkness until you find something that reminds you of a lever. You feel some resistance as");
            Console.WriteLine("you push the lever to another position. You feel the lever crumble as you force it, but you manage to push it up.");
            Console.WriteLine("You see how torches lit up, and you can see more clearly now. You begin walking towards an opening that leads you out.");
            Wait();
            Console.WriteLine("When you are on the otherside of the opening. You are blinded by the shine of massive amounts of gold coins.");
            Console.WriteLine("You start to grab the gold coins and stuff them to your bag. You drop one coin and it makes a loud echoing 'clink' sound.");
            Console.WriteLine("You freeze in place and start listening. You have a bad feeling about this place.");
            Console.WriteLine("You sence that a fight is near");

        }


        public void EndProgram()
        {
            Console.ResetColor();

            ClearConsole();
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Hopefully you liked this game!");
            Console.WriteLine("See you soon!");
            BlankLine();
            Console.WriteLine("Press Enter to end the program");
            Wait();
        }

        public void Wait()
        {
            Console.ReadLine();
        }

        public void HeroFightStats(ref Character hero)
        {

            Console.WriteLine("Name: " + hero.GetName());
            Console.WriteLine("Healt: " + hero.GetHP());
            Console.WriteLine("");

        }

        public void DragonFightStats(ref Character villain)
        {

            Console.WriteLine("Name: " + villain.GetName());
            Console.WriteLine("Health: " + villain.GetHP());
            Console.WriteLine("");
        }
        public void HeroWinningMessage(ref Character villain)
        {


            Console.WriteLine("");
            Console.WriteLine(villain.GetName() + " has died");
            BlankLine();
            Console.WriteLine("Congratulations! You have defeated the dragon!");
            MusicBox.PlayWinnermusic();

        }
        public void HeroLosingMessage(ref Character hero)
        {

            Console.WriteLine("");
            Console.WriteLine(hero.GetName() + " has died");
            BlankLine();
            Console.WriteLine("Game over. You have been defeated by the dragon!");
            MusicBox.PlayDefeatmusic();

        }
        public void BadAction()
        {
            Console.WriteLine("Action is not valid");
            Actionstext();
        }

        public void BlankLine()
        {
            Console.WriteLine("");
        }
        public void EndResultOfFight()
        {
            ClearConsole();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            ClearConsole();
            Console.WriteLine("-------------- Results --------------");
        }

        public void Actionstext()
        {
            Console.WriteLine("\nWhat will you do?");
            Console.WriteLine("1 - Attack");
            Console.WriteLine("2 - Do nothing");
        }
        public void HeroAttack(ref Character hero, Character villain)
        {
            int dmgToVillain = 0;
            int newrentti = 0;

            dmgToVillain = ((hero.GetaTTACKHP() - villain.GetarmorClass()));
            if (dmgToVillain > 0)
            {


            }
            else
            {
                dmgToVillain = Die.Roll1d6();
                BlankLine();
                Console.WriteLine("Heroes attack to dragon was blocked but still made damage");
            }

            newrentti = (villain.GetHP() - dmgToVillain);
            MusicBox.PlayFightSound();
            BlankLine();
            Console.WriteLine("You deal " + dmgToVillain + " to " + villain.GetName());

            villain.SetHP(newrentti);
        }


        public void VillainAttack(ref Character hero, Character villain)
        {
            int dmgToHero = 0;
            int newpentti = 0;

            dmgToHero = ((villain.GetaTTACKHP() - hero.GetarmorClass()));
            if (dmgToHero > 0)
            {


            }
            else
            {
                dmgToHero = Die.Roll1d6();

                Console.WriteLine("Dragons attack to hero was blocked but still made damage!");
            }

            newpentti = (hero.GetHP() - dmgToHero);
            MusicBox.PlayFightSound();
            Console.WriteLine(villain.GetName() + " deals " + dmgToHero + " to you");
            BlankLine();

            hero.SetHP(newpentti);



        }

    }
}
