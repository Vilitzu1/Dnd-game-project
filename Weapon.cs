using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND
{
    internal class Weapon
    {
        private string name;
        private int attack;
        private int defence;
        private bool isBroken;

        //Name Getter
        public string GetName()
        {
            return name;
        }

        //Set name
        public void SetName(string newName)
        {
            name = newName;
        }

        //Get Attack
        public int GetAttack()
        {
            return attack;
        }

        //Set Attack
        public void SetAttack(int newAttack)
        {
            attack = newAttack;
        }

        //Get Defence
        public int GetDefence()
        {
            return defence;
        }

        //Set Defence
        public void SetDefence(int newDefence)
        {
            defence = newDefence;
        }

        //isBroken
        private void SetIsBroken(bool brokenVal)
        {
            isBroken = brokenVal;
        }

        public bool IsBroken()
        {
            return isBroken;
        }

        public void Init()
        {
            SetName("Blood-Forged Broadsword");
            SetAttack(Die.Roll1d20());
            SetDefence(Die.Roll1d6());
            SetIsBroken(false);

        }

    }
}
