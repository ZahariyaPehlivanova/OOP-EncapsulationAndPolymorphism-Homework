using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Game_Engine.Characters
{
    using Objects;
    using Interfaces;
    class Healer : Character,IHeal
    {
        public Healer(string id,int x,int y,int healthPoints,int defensePoints,int healPoints,Team team,int range)
            :base(id,x,y,healthPoints,defensePoints,team,range)
        {
            this.HealPoints = healPoints;
        }
        public int HealPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets = from target in targetsList
                          where target.IsAlive && target.Team == this.Team && target != this
                          orderby target.HealthPoints
                          select target;
            return targets.FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(", Healing: {0}",this.HealPoints);
        }
    }
}
