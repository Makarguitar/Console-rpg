using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_rpg
{
    class Character
    {
        public string name;
        public int hp = 100, damage = 30, luck = 30;
        public TypeOfCharacter type = TypeOfCharacter.None;
        public TypeOfBonus bonus = TypeOfBonus.None;
        
        public void Attack(Character target)
        {
            target.hp -= damage;
            Console.WriteLine($"<<<<<{name} has {hp}hp and has damaged {damage}hp to {target.name}>>>>>");
            if (target.hp <= 0)
            {
                Console.WriteLine($"{target.name} was defeated");
            }

        }
    }
}
