using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex
{
    abstract class GameUnit
    {
        public enum UnitTypes
        {
            HeavyInfantry = 1,
            LightInfantry = 2,
            Skirmishers = 3,
            Archers = 4,
            Cavalry = 5,
            LightCavalry = 6,
            SkyHunters = 7,
            Bombardier = 8,
            SiegeEngines = 9,
            SpellCasters = 10
        }

        public enum UnitRaces
        {
            Mortal = 1,
            Beast = 2,
            Magical = 3,
            Mechanical = 4
        }

        public enum MovementTypes
        {
            Open = 1,
            Closed = 2,
            Mounted = 3,
            Air = 4
        }

        public enum AttackTypes
        {
            Physical = 1,
            Magical = 2,
            Mechanical = 3
        }

        public enum UnitAlignments
        {
            Good = 1,
            Any = 2,
            Evil = 3
        }

        /* ------------ Members ------------ */
        public string Name;
        public int UnitType;
        public int Cost;
        public int ResearchGrade;
        public int Race;
        public int Life;
        public int Armor;
        public int MagicResist;
        public int Movement;
        public int MovementType;
        public int SpottingRange;
        public int NumberOfAttacks;
        public int MeleeAttack;
        public int MeleeAttackType;
        public int SkirmishAttack;
        public int SkirmishAttackType;
        public int RangeAttack;
        public int RangeAttackType;
        public int SeigeAttack;
        public int SeigeAttackType;
        public int OwnerAlignment;

        /* ------------ Methods ------------ */
    }
}
