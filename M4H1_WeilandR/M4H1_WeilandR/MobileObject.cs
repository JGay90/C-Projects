using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4H1_WeilandR
{
    class MobileObject
    {
        //Fields
        public int _HP = 0;
        public int _AC = 0;
        public int _AB = 0;
        public int _DMG = 0;
        public bool _CanAttack = true;
        

        //Constructor
        public MobileObject(int HP, int AC, int AB, int DMG, bool CanAttack)
        {
            _HP = HP;
            _AC = AC;
            _AB = AB;
            _DMG = DMG;
            _CanAttack = CanAttack;
        }

        //HP Property
        public int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        //AC Property
        public int AC
        {
            get { return _AC; }
            set { _AC = value; }
        }

        //AB Property
        public int AB
        {
            get { return _AB; }
            set { _AB = value; }
        }

        //DMG Property
        public int DMG
        {
            get { return _DMG; }
            set { _DMG = value; }
        }

        //CanAttack Property
        public bool CanAttack
        {
            get { return _CanAttack; }
            set { _CanAttack = value; }
        }

        //OnSpawn method causes an effect upon the enemy spawning in.
        public void OnSpawn()
        {

        }

        //OnCombatStart method determines what happens when the combat starts.
        public void OnCombatStart()
        {

        }

        //OnDeath method determines what happens when a death occurs.
        public void OnDeath()
        {

        }
    }
}
