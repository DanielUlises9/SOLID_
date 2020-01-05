using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BlueTeam : Human
    {
        private int _health;
        private int _damage;
        private bool _isAlive;

        public BlueTeam()
        {

        }
        public BlueTeam(int _health, int _damage, bool _isAlive)
        {
            this._health = _health;
            this._damage = _damage;
            this._isAlive = _isAlive;
        }

        public override int Health
        {
            get { return _health; }
        }
        public override bool IsAlive { get { return _isAlive; } }
        public override int Damage { get { return _damage; } }

        public void GetDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
                isDead();
        }
        private void isDead()
        {
            _isAlive = false;
        }

        public override string ToString()
        {
            return $"Health: {_health} Damage: {_damage} is Alive: {IsAlive}";
        }
    }
}
