using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    internal class Game
    {
        UI ui = new UI();
        public Character hero, villain;

        public void Start()
        {

            hero = new Character();
            villain = new Character();

            ui.CopyrightText();
            MusicBox.PlayIntroSong();

            //Sankarille osa arvoista kysytään käyttäjältä ja loput arvotaan.
            ui.AskCharacterStats(ref hero);
            hero.FillInRest();


            //Pahikselle generoidaan kaikki arvot satunnaisesti.
            villain.Init();

            //Aloitetaas pelin tapahtumien koodaaminen

            ui.StartGame(hero.GetName());


            ui.Wait();
            ui.BlankLine();
            ui.ContinueStory();
            ui.Wait();
            ui.ClearConsole();

            //Taistelu
            bool playersTurn = true;
            int playersChoice;



            while (hero.GetHP() > 0 && villain.GetHP() > 0)
            {
                //player's turn
                if (playersTurn)
                {
                    //show your health
                    ui.HeroFightStats(ref hero);
                    //show dragon's health
                    ui.DragonFightStats(ref villain);
                    //show options
                    ui.Actionstext();

                    //get the player's choice
                    playersChoice = -1;
                    bool acceptableAction = false;
                    while (!acceptableAction)
                    {
                        int.TryParse(Console.ReadLine(), out playersChoice);
                        if (playersChoice == 1 || playersChoice == 2)
                        {
                            acceptableAction = true;
                        }
                        else
                        {
                            ui.BadAction();
                        }

                    }

                    if (playersChoice == 1)
                    {
                        //attack with sword, target dragon
                        ui.HeroAttack(ref hero, villain);
                        //end the player's turn
                        playersTurn = EndTurn(playersTurn);
                    }
                    else if (playersChoice == 2)
                    {
                        //Wait
                        ui.Wait();
                        //end the player's turn
                        playersTurn = EndTurn(playersTurn);
                    }
                    else
                    {
                        ui.Wait();
                        playersTurn = EndTurn(playersTurn);
                    }

                }
                //dragon's turn
                if (!playersTurn)
                {
                    if (villain.GetHP() > 0)
                    {
                        //attack player
                        ui.VillainAttack(ref hero, villain);
                        playersTurn = BeginTurn(playersTurn);
                    }
                }
            }
            //if player is still alive, display winning message
            if (hero.GetHP() > 0 || hero.GetHP() > 0 && villain.GetHP() > 0)
            {
                ui.Wait();
                ui.ClearConsole();
                ui.EndResultOfFight();
                ui.HeroFightStats(ref hero);
                ui.DragonFightStats(ref villain);
                ui.HeroWinningMessage(ref villain);
            }
            //else if dragon is alive display losing message
            else if (villain.GetHP() > 0)
            {
                ui.Wait();
                ui.ClearConsole();
                ui.EndResultOfFight();
                ui.DragonFightStats(ref villain);
                ui.HeroFightStats(ref hero);
                ui.HeroLosingMessage(ref hero);
            }
            ui.Wait();
            ui.ClearConsole();



            ui.EndProgram();
        }

        //utility methods
        public static bool EndTurn(bool playersTurn)
        {
            return playersTurn = false;
        }
        public static bool BeginTurn(bool playersTurn)
        {
            return playersTurn = true;
        }
    }
}
