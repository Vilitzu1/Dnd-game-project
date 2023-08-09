using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    internal class Character
    {


        Weapon w = null;

        //Basic information about the character
        private string name;
        private int level;

        private string raceNclass;
        private string background;
        private string playerName;
        private int experiencePoints;
        private string alignment;
        private string adventuringGroup;

        //Main values
        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;

        // Modifier values
        private int strengthAbilitymodifier;
        private int dexterityAbilitymodifier;
        private int constitutionAbilitymodifier;
        private int intelligenceAbilitymodifier;
        private int wisdomAbilitymodifier;
        private int charismaAbilitymodifier;

        //Inspiration
        private int inspiration;
        //Proficiency
        private int proficiencyBonus;

        //Saving throws
        private int savingThrowStrenght;
        private int savingThrowDexterity;
        private int savingThrowConstitution;
        private int savingThrowIntelligence;
        private int savingThrowWisdom;
        private int savingThrowCharisma;

        //Skills
        private int acrobatics;
        private int animalHandling;
        private int arcana;
        private int athletics;
        private int deception;
        private int history;
        private int insight;
        private int intimidation;
        private int investigation;
        private int medicine;
        private int nature;
        private int perception;
        private int performance;
        private int persuasion;
        private int religion;
        private int sleightOfHand;
        private int stealth;
        private int survival;


        //Passive perception
        private int passivePerception;

        //Armor class and HP stuff
        private int armorClass;
        private int HP;
        private int initiative;
        private int speed;
        private int vision;
        private int aTTACKHP;
        private int aTTACK;

        //Other proficienciens and languages
        private string oPL;

        //Features and Traits
        private string fAT;

        //Inventory and Equipment
        private string iAE;

        //Name is not null check.
        public string GetName()
        {
            if (name != null && name.Length != 0)
            {
                return name;
            }
            else
            {
                return "You can't even remember your own name...";
            }
        }

        //New value is set if name lenght does not equal 0
        public void SetName(string newName)
        {
            if (newName.Length != 0)
            {
                name = newName;
            }
        }

        //Get Level
        public int GetLevel()
        {
            return level;
        }

        //Set level
        public void SetLevel(int newLevel)
        {
            level = newLevel;
        }

        //Get race and class
        public string GetraceNclass()
        {
            return raceNclass;
        }
        //Set race and class
        public void SetraceNclass(string newRaceNclass)
        {
            raceNclass = newRaceNclass;
        }

        //Get background
        public string GetBackground()
        {
            return background;
        }

        //Set background
        public void SetBackground(string newBackground)
        {
            background = newBackground;
        }

        //Get playername
        public string GetplayerName()
        {
            return playerName;
        }

        //Set playerName
        public void SetplayerName(string newPlayerName)
        {
            playerName = newPlayerName;
        }

        //Get experiencepoints
        public int Getexperiencepoints()
        {
            return experiencePoints;
        }

        //Set experiencepoints
        public void Setexperiencepoints(int newExperiencePoints)
        {
            experiencePoints = newExperiencePoints;
        }
        //Get alignment
        public string GetAlignment()
        {
            return alignment;
        }

        //Set alignment
        public void SetAlignment(string newAlignment)
        {
            alignment = newAlignment;
        }

        //Get adventuringGroup
        public string GetAdventuringGroup()
        {
            return adventuringGroup;
        }

        //Set adventuringGroup
        public void SetAdventuringGroup(string newAdventuringGroup)
        {
            adventuringGroup = newAdventuringGroup;
        }

        //Get Strength
        public int GetStrength()
        {
            return strength;
        }

        //Set Strength
        public void SetStrength(int newStrength)
        {
            strength = newStrength;
        }

        //Get dexterity
        public int Getdexterity()
        {
            return dexterity;
        }

        //Set dexterity
        public void Setdexterity(int newDexterity)
        {
            dexterity = newDexterity;
        }

        //Get constitution
        public int GetConstitution()
        {
            return constitution;
        }

        //Set constitution
        public void SetConstitution(int newConstitution)
        {
            constitution = newConstitution;
        }
        //Get intelligence
        public int GetIntelligence()
        {
            return intelligence;
        }

        //Set intelligence
        public void SetIntelligence(int newIntelligence)
        {
            intelligence = newIntelligence;
        }

        //Get wisdom
        public int GetWisdom()
        {
            return wisdom;
        }

        //Set wisdom
        public void SetWisdom(int newWisdom)
        {
            wisdom = newWisdom;
        }

        //Get charisma
        public int GetCharisma()
        {
            return charisma;
        }

        //Set charisma
        public void SetCharisma(int newCharisma)
        {
            charisma = newCharisma;
        }

        //Get strenghtabilitymodifier
        public int GetstrengthAbilitymodifier()
        {
            return strengthAbilitymodifier;
        }

        //Set strengthabilitymodifier
        public void SetstrengthAbilitymodifier(int newstrengthAbilitymodifier)
        {
            strengthAbilitymodifier = newstrengthAbilitymodifier;
        }

        //Get dexterityAbilitymodifier
        public int GetdexterityAbilitymodifier()
        {
            return dexterityAbilitymodifier;
        }

        //Set dexterityAbilitymodifier
        public void SetdexterityAbilitymodifier(int newdexterityAbilitymodifier)
        {
            dexterityAbilitymodifier = newdexterityAbilitymodifier;
        }

        //Get constitutionAbilitymodifier
        public int GetconstitutionAbilitymodifier()
        {
            return constitutionAbilitymodifier;
        }

        //Set constitutionAbilitymodifier
        public void SetconstitutionAbilitymodifier(int newconstitutionAbilitymodifier)
        {
            constitutionAbilitymodifier = newconstitutionAbilitymodifier;
        }

        //Get intelligenceAbilitymodifier
        public int GetintelligenceAbilitymodifier()
        {
            return intelligenceAbilitymodifier;
        }

        //Set intelligenceAbilitymodifier
        public void SetintelligenceAbilitymodifier(int newintelligenceAbilitymodifier)
        {
            intelligenceAbilitymodifier = newintelligenceAbilitymodifier;
        }

        //Get wisdomAbilitymodifier
        public int GetwisdomAbilitymodifier()
        {
            return wisdomAbilitymodifier;
        }

        //Set wisdomAbilitymodifier
        public void SetwisdomAbilitymodifier(int newwisdomAbilitymodifier)
        {
            wisdomAbilitymodifier = newwisdomAbilitymodifier;
        }

        //Get charismaAbilitymodifier
        public int GetcharismaAbilitymodifier()
        {
            return charismaAbilitymodifier;
        }

        //Set charismaAbilitymodifier
        public void SetcharismaAbilitymodifier(int newcharismaAbilitymodifier)
        {
            charismaAbilitymodifier = newcharismaAbilitymodifier;
        }

        //Get inspiration
        public int Getinspiration()
        {
            return inspiration;
        }

        //Set inspiration
        public void Setinspiration(int newinspiration)
        {
            inspiration = newinspiration;
        }

        //Get proficiencyBonus
        public int GetproficiencyBonus()
        {
            return proficiencyBonus;
        }

        //Set proficiencyBonus
        public void SetproficiencyBonus(int newproficiencyBonus)
        {
            proficiencyBonus = newproficiencyBonus;
        }

        //Get savingThrowStrength
        public int GetsavingThrowStrenght()
        {
            return savingThrowStrenght;
        }

        //Set savingThrowStrenght
        public void SetsavingThrowStrength(int newsavingThrowStrenght)
        {
            savingThrowStrenght = newsavingThrowStrenght;
        }

        //Get savingThrowDexterity
        public int GetsavingThrowDexterity()
        {
            return savingThrowDexterity;
        }

        //Set savingThrowDexterity
        public void SetsavingThrowDexterity(int newsavingThrowDexterity)
        {
            savingThrowDexterity = newsavingThrowDexterity;
        }


        //Get savingThrowConstitution
        public int GetsavingThrowConstitution()
        {
            return savingThrowConstitution;
        }

        //Set savingThrowConstitution
        public void SetsavingThrowConstitution(int newsavingThrowConstitution)
        {
            savingThrowConstitution = newsavingThrowConstitution;
        }

        //Get savingThrowIntelligence
        public int GetsavingThrowIntelligence()
        {
            return savingThrowIntelligence;
        }

        //Set savingThrowIntelligence
        public void SetsavingThrowIntelligence(int newsavingThrowIntelligence)
        {
            savingThrowIntelligence = newsavingThrowIntelligence;
        }

        //Get savingThrowWisdom
        public int GetsavingThrowWisdom()
        {
            return savingThrowWisdom;
        }

        //Set savingThrowWisdom
        public void SetsavingThrowWisdom(int newsavingThrowWisdom)
        {
            savingThrowWisdom = newsavingThrowWisdom;
        }

        //Get savingThrowCharisma
        public int GetsavingThrowCharisma()
        {
            return savingThrowCharisma;
        }

        //Set savingThrowCharisma
        public void SetsavingThrowCharisma(int newsavingThrowCharisma)
        {
            savingThrowCharisma = newsavingThrowCharisma;
        }

        //Get acrobatics
        public int GetAcrobatics()
        {
            return acrobatics;
        }

        //Set acrobatics
        public void SetAcrobatics(int newAcrobatics)
        {
            acrobatics = newAcrobatics;
        }

        //Get animalHandling
        public int GetAnimalHandling()
        {
            return animalHandling;
        }

        //Set animalHandling
        public void SetAnimalHandling(int newAnimalHandling)
        {
            animalHandling = newAnimalHandling;
        }

        //Get Arcana
        public int GetArcana()
        {
            return arcana;
        }

        //Set Arcana
        public void SetArcana(int newArcana)
        {
            arcana = newArcana;
        }

        //Get athletics
        public int GetAthletics()
        {
            return athletics;
        }

        //Set athletics
        public void SetAthletics(int newAthletics)
        {
            athletics = newAthletics;
        }

        //Get Deception
        public int GetDeception()
        {
            return deception;
        }

        //Set Deception
        public void SetDeception(int newDeception)
        {
            deception = newDeception;
        }

        //Get history
        public int GetHistory()
        {
            return history;
        }

        //Set History
        public void SetHistory(int newHistory)
        {
            history = newHistory;
        }

        //Get Insight
        public int GetInsight()
        {
            return insight;
        }

        //Set Insight
        public void SetInsight(int newInsight)
        {
            insight = newInsight;
        }

        //Get Intimidation
        public int GetIntimidation()
        {
            return intimidation;
        }

        //Set Intimidation
        public void SetIntimidation(int newIntimidation)
        {
            intimidation = newIntimidation;
        }

        //Get investigation
        public int GetInvestigation()
        {
            return investigation;
        }

        //Set Investigation
        public void SetInvestigation(int newInvestigation)
        {
            investigation = newInvestigation;
        }

        //Get Medicine
        public int GetMedicine()
        {
            return medicine;
        }

        //Set Medicine
        public void SetMedicine(int newMedicine)
        {
            medicine = newMedicine;
        }

        //Get nature
        public int GetNature()
        {
            return nature;
        }

        //Set nature
        public void SetNature(int newNature)
        {
            nature = newNature;
        }

        //Get perception
        public int GetPerception()
        {
            return perception;
        }

        //Set perception
        public void SetPerception(int newPerception)
        {
            perception = newPerception;
        }

        //Get Performance
        public int GetPerformance()
        {
            return performance;
        }

        //Set Performance
        public void SetPerformance(int newPerformance)
        {
            performance = newPerformance;
        }

        //Get Persuasion
        public int GetPersuasion()
        {
            return persuasion;
        }

        //Set Persuasion
        public void SetPersuasion(int newPersuasion)
        {
            persuasion = newPersuasion;
        }

        //Get Religion
        public int GetReligion()
        {
            return religion;
        }

        //Set Religion
        public void SetReligion(int newReligion)
        {
            religion = newReligion;
        }

        //Get sleightOfHand
        public int GetsleightOfHand()
        {
            return sleightOfHand;
        }

        //Set sleightOfHand
        public void SetsleightOfHand(int newsleightOfHand)
        {
            sleightOfHand = newsleightOfHand;
        }

        //Get stealth
        public int Getstealth()
        {
            return stealth;
        }

        //Set stealth
        public void Setstealth(int newstealth)
        {
            stealth = newstealth;
        }

        //Get survival
        public int Getsurvival()
        {
            return survival;
        }

        //Set Survival
        public void Setsurvival(int newsurvival)
        {
            survival = newsurvival;
        }

        //Get passivePerception
        public int GetpassivePerception()
        {
            return passivePerception;
        }

        //Set passivePerception
        public void SetpassivePerception(int newpassivePerception)
        {
            passivePerception = newpassivePerception;
        }

        //Get armorclass
        public int GetarmorClass()
        {
            return armorClass;
        }

        //Set armorclass
        public void SetarmorClass(int newarmorClass)
        {
            armorClass = newarmorClass;
        }

        //Get HP
        public int GetHP()
        {
            return HP;
        }

        //Set HP
        public void SetHP(int newHP)
        {
            HP = newHP;
        }

        //Get initiative
        public int Getinitiative()
        {
            return initiative;
        }

        //Set initiative
        public void Setinitiative(int newinitiative)
        {
            initiative = newinitiative;
        }

        //Get speed
        public int Getspeed()
        {
            return speed;
        }

        //Set speed
        public void Setspeed(int newspeed)
        {
            speed = newspeed;
        }

        //Get vision
        public int Getvision()
        {
            return vision;
        }

        //Set vision
        public void Setvision(int newvision)
        {
            vision = newvision;
        }

        //Get oPL
        public string GetoPL()
        {
            return oPL;
        }

        //Set oPL
        public void SetoPL(string newoPL)
        {
            oPL = newoPL;
        }

        //Get fAT
        public string GetfAT()
        {
            return fAT;
        }

        //Set fAT
        public void SetfAT(string newfAT)
        {
            fAT = newfAT;
        }

        //Get iAE
        public string GetiAE()
        {
            return iAE;

        }

        //Set iAE
        public void SetiAE(string newiAE)
        {
            iAE = newiAE;
        }

        public int GetaTTACKHP()
        {
            if (aTTACKHP > 0)
            {
                return aTTACKHP;
            }
            else
            {
                return Die.Roll1d20();
            }
        }

        public void SetaTTACKHP(int newaTTACKHP)
        {
            if (newaTTACKHP > 0)
            {
                aTTACKHP = newaTTACKHP;
            }
            else
            {
                aTTACKHP = Die.Roll1d20();
            }
        }

        public int GetaTTACK()
        {
            return aTTACK;
        }

        public void SetaTTACK(int newaTTACK)
        {
            aTTACK = newaTTACK;
        }

        public void FillInRest()
        {
            w = new Weapon();
            w.Init();
            //Name, level, strength arvot on kysytty jo
            SetraceNclass("Human Fighter");
            SetBackground("Soon to be hero");
            SetplayerName("Player");
            Setexperiencepoints(Die.Roll1d20());
            SetAlignment("Lawful Good");
            SetAdventuringGroup("Heroes");

            Setdexterity(Die.Roll1d20());
            SetConstitution(Die.Roll1d20());
            SetIntelligence(Die.Roll1d20());
            SetWisdom(Die.Roll1d20());
            SetCharisma(Die.Roll1d20());

            //Setting the strengthtabilitymodifier
            if (strength >= 20)
            {
                SetstrengthAbilitymodifier(5);
            }
            else if (strength >= 18)
            {
                SetstrengthAbilitymodifier(4);
            }
            else if (strength >= 16)
            {
                SetstrengthAbilitymodifier(3);
            }
            else if (strength >= 14)
            {
                SetstrengthAbilitymodifier(2);
            }
            else if (strength >= 12)
            {
                SetstrengthAbilitymodifier(1);
            }
            else if (strength >= 10)
            {
                SetstrengthAbilitymodifier(0);
            }
            else if (strength >= 8)
            {
                SetstrengthAbilitymodifier(-1);
            }
            else if (strength >= 6)
            {
                SetstrengthAbilitymodifier(-2);
            }
            else if (strength >= 4)
            {
                SetstrengthAbilitymodifier(-3);
            }
            else if (strength >= 2)
            {
                SetstrengthAbilitymodifier(-4);
            }
            else
            {
                SetstrengthAbilitymodifier(-5);
            }

            //Setting dexterityAbilityModifier
            if (dexterity >= 20)
            {
                SetdexterityAbilitymodifier(5);
            }
            else if (dexterity >= 18)
            {
                SetdexterityAbilitymodifier(4);
            }
            else if (dexterity >= 16)
            {
                SetdexterityAbilitymodifier(3);
            }
            else if (dexterity >= 14)
            {
                SetdexterityAbilitymodifier(2);
            }
            else if (dexterity >= 12)
            {
                SetdexterityAbilitymodifier(1);
            }
            else if (dexterity >= 10)
            {
                SetdexterityAbilitymodifier(0);
            }
            else if (dexterity >= 8)
            {
                SetdexterityAbilitymodifier(-1);
            }
            else if (dexterity >= 6)
            {
                SetdexterityAbilitymodifier(-2);
            }
            else if (dexterity >= 4)
            {
                SetdexterityAbilitymodifier(-3);
            }
            else if (dexterity >= 2)
            {
                SetdexterityAbilitymodifier(-4);
            }
            else
            {
                SetdexterityAbilitymodifier(-5);
            }


            //Setting constitutionAbilityModifier
            if (constitution >= 20)
            {
                SetconstitutionAbilitymodifier(5);
            }
            else if (constitution >= 18)
            {
                SetconstitutionAbilitymodifier(4);
            }
            else if (constitution >= 16)
            {
                SetconstitutionAbilitymodifier(3);
            }
            else if (constitution >= 14)
            {
                SetconstitutionAbilitymodifier(2);
            }
            else if (constitution >= 12)
            {
                SetconstitutionAbilitymodifier(1);
            }
            else if (constitution >= 10)
            {
                SetconstitutionAbilitymodifier(0);
            }
            else if (constitution >= 8)
            {
                SetconstitutionAbilitymodifier(-1);
            }
            else if (constitution >= 6)
            {
                SetconstitutionAbilitymodifier(-2);
            }
            else if (constitution >= 4)
            {
                SetconstitutionAbilitymodifier(-3);
            }
            else if (constitution >= 2)
            {
                SetconstitutionAbilitymodifier(-4);
            }
            else
            {
                SetconstitutionAbilitymodifier(-5);
            }


            //Setting intelligenceAbilityModifier
            if (intelligence >= 20)
            {
                SetintelligenceAbilitymodifier(5);
            }
            else if (intelligence >= 18)
            {
                SetintelligenceAbilitymodifier(4);
            }
            else if (intelligence >= 16)
            {
                SetintelligenceAbilitymodifier(3);
            }
            else if (intelligence >= 14)
            {
                SetintelligenceAbilitymodifier(2);
            }
            else if (intelligence >= 12)
            {
                SetintelligenceAbilitymodifier(1);
            }
            else if (intelligence >= 10)
            {
                SetintelligenceAbilitymodifier(0);
            }
            else if (intelligence >= 8)
            {
                SetintelligenceAbilitymodifier(-1);
            }
            else if (intelligence >= 6)
            {
                SetintelligenceAbilitymodifier(-2);
            }
            else if (intelligence >= 4)
            {
                SetintelligenceAbilitymodifier(-3);
            }
            else if (intelligence >= 2)
            {
                SetintelligenceAbilitymodifier(-4);
            }
            else
            {
                SetintelligenceAbilitymodifier(-5);
            }


            //Setting WisdomAbilityModifier
            if (wisdom >= 20)
            {
                SetwisdomAbilitymodifier(5);
            }
            else if (wisdom >= 18)
            {
                SetwisdomAbilitymodifier(4);
            }
            else if (wisdom >= 16)
            {
                SetwisdomAbilitymodifier(3);
            }
            else if (wisdom >= 14)
            {
                SetwisdomAbilitymodifier(2);
            }
            else if (wisdom >= 12)
            {
                SetwisdomAbilitymodifier(1);
            }
            else if (wisdom >= 10)
            {
                SetwisdomAbilitymodifier(0);
            }
            else if (wisdom >= 8)
            {
                SetwisdomAbilitymodifier(-1);
            }
            else if (wisdom >= 6)
            {
                SetwisdomAbilitymodifier(-2);
            }
            else if (wisdom >= 4)
            {
                SetwisdomAbilitymodifier(-3);
            }
            else if (wisdom >= 2)
            {
                SetwisdomAbilitymodifier(-4);
            }
            else
            {
                SetwisdomAbilitymodifier(-5);
            }


            //Setting charismaAbilityModifier
            if (charisma >= 20)
            {
                SetcharismaAbilitymodifier(5);
            }
            else if (charisma >= 18)
            {
                SetcharismaAbilitymodifier(4);
            }
            else if (charisma >= 16)
            {
                SetcharismaAbilitymodifier(3);
            }
            else if (charisma >= 14)
            {
                SetcharismaAbilitymodifier(2);
            }
            else if (charisma >= 12)
            {
                SetcharismaAbilitymodifier(1);
            }
            else if (charisma >= 10)
            {
                SetcharismaAbilitymodifier(0);
            }
            else if (charisma >= 8)
            {
                SetcharismaAbilitymodifier(-1);
            }
            else if (charisma >= 6)
            {
                SetcharismaAbilitymodifier(-2);
            }
            else if (charisma >= 4)
            {
                SetcharismaAbilitymodifier(-3);
            }
            else if (charisma >= 2)
            {
                SetcharismaAbilitymodifier(-4);
            }
            else
            {
                SetcharismaAbilitymodifier(-5);
            }

            //inspiration
            Setinspiration(0);

            //proficiency bonus

            if (level >= 17)
            {
                SetproficiencyBonus(6);
            }
            else if (level >= 13)
            {
                SetproficiencyBonus(5);
            }
            else if (level >= 9)
            {
                SetproficiencyBonus(4);
            }
            else if (level >= 5)
            {
                SetproficiencyBonus(3);
            }
            else if (level >= 0)
            {
                SetproficiencyBonus(2);
            }
            else
            {
                SetproficiencyBonus(0);
            }


            //Pelastusheitot
            SetsavingThrowStrength(Die.Roll1d20() + GetstrengthAbilitymodifier());
            SetsavingThrowDexterity(Die.Roll1d20() + GetdexterityAbilitymodifier());
            SetsavingThrowConstitution(Die.Roll1d20() + GetconstitutionAbilitymodifier());
            SetsavingThrowIntelligence(Die.Roll1d20() + GetintelligenceAbilitymodifier());
            SetsavingThrowWisdom(Die.Roll1d20() + GetwisdomAbilitymodifier());
            SetsavingThrowCharisma(Die.Roll1d20() + GetcharismaAbilitymodifier());

            //Taidot
            SetAcrobatics(GetsavingThrowDexterity() + GetproficiencyBonus());
            SetAnimalHandling(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetArcana(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetAthletics(GetsavingThrowStrenght() + GetproficiencyBonus());
            SetDeception(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetHistory(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetInsight(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetIntimidation(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetInvestigation(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetMedicine(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetNature(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetPerception(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetPerformance(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetPersuasion(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetReligion(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetsleightOfHand(GetsavingThrowDexterity() + GetproficiencyBonus());
            Setstealth(GetsavingThrowDexterity() + GetproficiencyBonus());
            Setsurvival(GetsavingThrowWisdom() + GetproficiencyBonus());

            //Passive Perception
            SetpassivePerception(10 + GetproficiencyBonus() + GetwisdomAbilitymodifier());

            //Armorclass and Hp things
            SetarmorClass(10 + GetdexterityAbilitymodifier());
            SetHP(Die.Roll1d20() + Die.Roll1d20() + Die.Roll1d20());
            Setinitiative(Die.Roll1d20() + GetdexterityAbilitymodifier());
            Setspeed(Die.Roll1d20() + Die.Roll1d20());
            Setvision(Die.Roll1d20() + Die.Roll1d20() + Die.Roll1d20());
            SetoPL("Not set");
            SetfAT("Not set");
            SetiAE(w.GetName());
            SetaTTACK(w.GetAttack());
            SetaTTACKHP(GetaTTACK() + GetstrengthAbilitymodifier() + GetproficiencyBonus());






        }

        public void Init()
        {
            w = new Weapon();
            w.Init();
            SetName("Executioner Dragon");
            SetLevel(Die.Roll1d20());
            SetraceNclass("Dragon");
            SetBackground("Desendant of great dragon Elvarg");
            SetplayerName("AI");
            Setexperiencepoints(Die.Roll1d20());
            SetAlignment("Chaotic Evil");
            SetAdventuringGroup("Villains");

            SetStrength(Die.Roll1d20());
            Setdexterity(Die.Roll1d20());
            SetConstitution(Die.Roll1d20());
            SetIntelligence(Die.Roll1d20());
            SetWisdom(Die.Roll1d20());
            SetCharisma(Die.Roll1d20());

            //Setting strenght abilitymodifier
            if (strength >= 20)
            {
                SetstrengthAbilitymodifier(5);
            }
            else if (strength >= 18)
            {
                SetstrengthAbilitymodifier(4);
            }
            else if (strength >= 16)
            {
                SetstrengthAbilitymodifier(3);
            }
            else if (strength >= 14)
            {
                SetstrengthAbilitymodifier(2);
            }
            else if (strength >= 12)
            {
                SetstrengthAbilitymodifier(1);
            }
            else if (strength >= 10)
            {
                SetstrengthAbilitymodifier(0);
            }
            else if (strength >= 8)
            {
                SetstrengthAbilitymodifier(-1);
            }
            else if (strength >= 6)
            {
                SetstrengthAbilitymodifier(-2);
            }
            else if (strength >= 4)
            {
                SetstrengthAbilitymodifier(-3);
            }
            else if (strength >= 2)
            {
                SetstrengthAbilitymodifier(-4);
            }
            else
            {
                SetstrengthAbilitymodifier(-5);
            }


            //Setting dexterityAbilityModifier
            if (dexterity >= 20)
            {
                SetdexterityAbilitymodifier(5);
            }
            else if (dexterity >= 18)
            {
                SetdexterityAbilitymodifier(4);
            }
            else if (dexterity >= 16)
            {
                SetdexterityAbilitymodifier(3);
            }
            else if (dexterity >= 14)
            {
                SetdexterityAbilitymodifier(2);
            }
            else if (dexterity >= 12)
            {
                SetdexterityAbilitymodifier(1);
            }
            else if (dexterity >= 10)
            {
                SetdexterityAbilitymodifier(0);
            }
            else if (dexterity >= 8)
            {
                SetdexterityAbilitymodifier(-1);
            }
            else if (dexterity >= 6)
            {
                SetdexterityAbilitymodifier(-2);
            }
            else if (dexterity >= 4)
            {
                SetdexterityAbilitymodifier(-3);
            }
            else if (dexterity >= 2)
            {
                SetdexterityAbilitymodifier(-4);
            }
            else
            {
                SetdexterityAbilitymodifier(-5);
            }


            //Setting constitutionAbilityModifier
            if (constitution >= 20)
            {
                SetconstitutionAbilitymodifier(5);
            }
            else if (constitution >= 18)
            {
                SetconstitutionAbilitymodifier(4);
            }
            else if (constitution >= 16)
            {
                SetconstitutionAbilitymodifier(3);
            }
            else if (constitution >= 14)
            {
                SetconstitutionAbilitymodifier(2);
            }
            else if (constitution >= 12)
            {
                SetconstitutionAbilitymodifier(1);
            }
            else if (constitution >= 10)
            {
                SetconstitutionAbilitymodifier(0);
            }
            else if (constitution >= 8)
            {
                SetconstitutionAbilitymodifier(-1);
            }
            else if (constitution >= 6)
            {
                SetconstitutionAbilitymodifier(-2);
            }
            else if (constitution >= 4)
            {
                SetconstitutionAbilitymodifier(-3);
            }
            else if (constitution >= 2)
            {
                SetconstitutionAbilitymodifier(-4);
            }
            else
            {
                SetconstitutionAbilitymodifier(-5);
            }


            //Setting intelligenceAbilityModifier
            if (intelligence >= 20)
            {
                SetintelligenceAbilitymodifier(5);
            }
            else if (intelligence >= 18)
            {
                SetintelligenceAbilitymodifier(4);
            }
            else if (intelligence >= 16)
            {
                SetintelligenceAbilitymodifier(3);
            }
            else if (intelligence >= 14)
            {
                SetintelligenceAbilitymodifier(2);
            }
            else if (intelligence >= 12)
            {
                SetintelligenceAbilitymodifier(1);
            }
            else if (intelligence >= 10)
            {
                SetintelligenceAbilitymodifier(0);
            }
            else if (intelligence >= 8)
            {
                SetintelligenceAbilitymodifier(-1);
            }
            else if (intelligence >= 6)
            {
                SetintelligenceAbilitymodifier(-2);
            }
            else if (intelligence >= 4)
            {
                SetintelligenceAbilitymodifier(-3);
            }
            else if (intelligence >= 2)
            {
                SetintelligenceAbilitymodifier(-4);
            }
            else
            {
                SetintelligenceAbilitymodifier(-5);
            }


            //Setting WisdomAbilityModifier
            if (wisdom >= 20)
            {
                SetwisdomAbilitymodifier(5);
            }
            else if (wisdom >= 18)
            {
                SetwisdomAbilitymodifier(4);
            }
            else if (wisdom >= 16)
            {
                SetwisdomAbilitymodifier(3);
            }
            else if (wisdom >= 14)
            {
                SetwisdomAbilitymodifier(2);
            }
            else if (wisdom >= 12)
            {
                SetwisdomAbilitymodifier(1);
            }
            else if (wisdom >= 10)
            {
                SetwisdomAbilitymodifier(0);
            }
            else if (wisdom >= 8)
            {
                SetwisdomAbilitymodifier(-1);
            }
            else if (wisdom >= 6)
            {
                SetwisdomAbilitymodifier(-2);
            }
            else if (wisdom >= 4)
            {
                SetwisdomAbilitymodifier(-3);
            }
            else if (wisdom >= 2)
            {
                SetwisdomAbilitymodifier(-4);
            }
            else
            {
                SetwisdomAbilitymodifier(-5);
            }


            //Setting charismaAbilityModifier
            if (charisma >= 20)
            {
                SetcharismaAbilitymodifier(5);
            }
            else if (charisma >= 18)
            {
                SetcharismaAbilitymodifier(4);
            }
            else if (charisma >= 16)
            {
                SetcharismaAbilitymodifier(3);
            }
            else if (charisma >= 14)
            {
                SetcharismaAbilitymodifier(2);
            }
            else if (charisma >= 12)
            {
                SetcharismaAbilitymodifier(1);
            }
            else if (charisma >= 10)
            {
                SetcharismaAbilitymodifier(0);
            }
            else if (charisma >= 8)
            {
                SetcharismaAbilitymodifier(-1);
            }
            else if (charisma >= 6)
            {
                SetcharismaAbilitymodifier(-2);
            }
            else if (charisma >= 4)
            {
                SetcharismaAbilitymodifier(-3);
            }
            else if (charisma >= 2)
            {
                SetcharismaAbilitymodifier(-4);
            }
            else
            {
                SetcharismaAbilitymodifier(-5);
            }

            //inspiration
            Setinspiration(0);

            //proficiency bonus

            if (level >= 17)
            {
                SetproficiencyBonus(6);
            }
            else if (level >= 13)
            {
                SetproficiencyBonus(5);
            }
            else if (level >= 9)
            {
                SetproficiencyBonus(4);
            }
            else if (level >= 5)
            {
                SetproficiencyBonus(3);
            }
            else if (level >= 0)
            {
                SetproficiencyBonus(2);
            }
            else
            {
                SetproficiencyBonus(0);
            }

            //Pelastusheitot
            SetsavingThrowStrength(Die.Roll1d20() + GetstrengthAbilitymodifier());
            SetsavingThrowDexterity(Die.Roll1d20() + GetdexterityAbilitymodifier());
            SetsavingThrowConstitution(Die.Roll1d20() + GetconstitutionAbilitymodifier());
            SetsavingThrowIntelligence(Die.Roll1d20() + GetintelligenceAbilitymodifier());
            SetsavingThrowWisdom(Die.Roll1d20() + GetwisdomAbilitymodifier());
            SetsavingThrowCharisma(Die.Roll1d20() + GetcharismaAbilitymodifier());

            //Taidot
            SetAcrobatics(GetsavingThrowDexterity() + GetproficiencyBonus());
            SetAnimalHandling(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetArcana(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetAthletics(GetsavingThrowStrenght() + GetproficiencyBonus());
            SetDeception(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetHistory(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetInsight(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetIntimidation(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetInvestigation(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetMedicine(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetNature(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetPerception(GetsavingThrowWisdom() + GetproficiencyBonus());
            SetPerformance(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetPersuasion(GetsavingThrowCharisma() + GetproficiencyBonus());
            SetReligion(GetsavingThrowIntelligence() + GetproficiencyBonus());
            SetsleightOfHand(GetsavingThrowDexterity() + GetproficiencyBonus());
            Setstealth(GetsavingThrowDexterity() + GetproficiencyBonus());
            Setsurvival(GetsavingThrowWisdom() + GetproficiencyBonus());

            //Passive Perception
            SetpassivePerception(10 + GetproficiencyBonus() + GetwisdomAbilitymodifier());

            //Armorclass and Hp things
            SetarmorClass(10 + GetdexterityAbilitymodifier());
            SetHP(Die.Roll1d20() + Die.Roll1d20() + Die.Roll1d20());
            Setinitiative(Die.Roll1d20() + GetdexterityAbilitymodifier());
            Setspeed(Die.Roll1d20() + Die.Roll1d20());
            Setvision(Die.Roll1d20() + Die.Roll1d20() + Die.Roll1d20());
            SetoPL("Not set");
            SetfAT("Not set");
            SetiAE(w.GetName());
            SetaTTACK(w.GetAttack());
            SetaTTACKHP(GetaTTACK() + GetstrengthAbilitymodifier() + GetproficiencyBonus());

        }
    }
}
