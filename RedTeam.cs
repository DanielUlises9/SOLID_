using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RedTeam : Human
    {
        private int _health;
        private int _damage;
        private bool _isAlive;

        public RedTeam(int _health, int _damage, bool _isAlive)
        {
            this._health = _health;
            this._damage = _damage;
            this._isAlive = _isAlive;
        }

        public override int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public override bool IsAlive { get { return _isAlive; } set { IsAlive = value; } }
        public override int Damage { get { return _damage; } set { _damage = value; } }

        public void GetDamage(int damage)
        {
            _health -= damage;
        }
    }
}
