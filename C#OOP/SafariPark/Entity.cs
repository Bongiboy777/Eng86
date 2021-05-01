using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Entity: IMoveable
    {

        private int _health;
        public int Health { get => _health; }

        private Damage _defense;
        public Damage Defense { get => _defense; set => _defense = value; }

        public virtual string Move()
        {
            return $"Walking along.";
        }

        public virtual string Move(int times)
        {
            return $"Walking along {times} times.";
        }

        public Entity(Damage defense,int health = 50)
        {
            _health = health < 10 ? 10: health > 100? 100: health;
            _defense = defense;
        }

        public Entity(int health = 50)
        {
            Defense = new Damage(Element.WATER,5,5,5);
            _health = health < 1 ? 1 : health > 100 ? 100 : health;
        }
    }
}
