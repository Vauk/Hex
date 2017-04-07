using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex.Units.HeavyInfantry
{
    class Warband : GameUnit
    {
        public Warband()
        {
            this.Name = "Warband";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 8;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 15;
            this.Armor = 12;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 9;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Swordsmen : GameUnit
    {
        public Swordsmen()
        {
            this.Name = "Swordsmen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 22;
            this.ResearchGrade = 1;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 15;
            this.Armor = 15;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 12;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Pikemen : GameUnit
    {
        public Pikemen()
        {
            this.Name = "Pikemen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 40;
            this.ResearchGrade = 2;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 15;
            this.Armor = 18;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 15;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Legionarii : GameUnit
    {
        public Legionarii()
        {
            this.Name = "Legionarii";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 60;
            this.ResearchGrade = 3;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 15;
            this.Armor = 23;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 19;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 9;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Samurai : GameUnit
    {
        public Samurai()
        {
            this.Name = "Samurai";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 72;
            this.ResearchGrade = 4;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 15;
            this.Armor = 28;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 23;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class HeavySpearmen : GameUnit
    {
        public HeavySpearmen()
        {
            this.Name = "Heavy Spearmen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 86;
            this.ResearchGrade = 5;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 15;
            this.Armor = 31;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 27;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Lizardmen : GameUnit
    {
        public Lizardmen()
        {
            this.Name = "Lizardmen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 14;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Beast;
            this.Life = 15;
            this.Armor = 13;
            this.MagicResist = 75;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 4;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 11;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Barbarians : GameUnit
    {
        public Barbarians()
        {
            this.Name = "Barbarians";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 25;
            this.ResearchGrade = 1;
            this.Race = (int)UnitRaces.Beast;
            this.Life = 15;
            this.Armor = 18;
            this.MagicResist = 75;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 4;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 14;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Werebears : GameUnit
    {
        public Werebears()
        {
            this.Name = "Werebears";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 37;
            this.ResearchGrade = 2;
            this.Race = (int)UnitRaces.Beast;
            this.Life = 15;
            this.Armor = 20;
            this.MagicResist = 75;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 4;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 18;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Lionmen : GameUnit
    {
        public Lionmen()
        {
            this.Name = "Lionmen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 53;
            this.ResearchGrade = 3;
            this.Race = (int)UnitRaces.Beast;
            this.Life = 15;
            this.Armor = 25;
            this.MagicResist = 75;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 4;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 23;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Elephantmen : GameUnit
    {
        public Elephantmen()
        {
            this.Name = "Elephantmen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 77;
            this.ResearchGrade = 5;
            this.Race = (int)UnitRaces.Beast;
            this.Life = 15;
            this.Armor = 28;
            this.MagicResist = 75;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 4;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 30;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class AirWarriors : GameUnit
    {
        public AirWarriors()
        {
            this.Name = "Air Warriors";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 14;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 15;
            this.Armor = 10;
            this.MagicResist = 90;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 13;
            this.MeleeAttackType = (int)AttackTypes.Magical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }
    class Treemen : GameUnit
    {
        public Treemen()
        {
            this.Name = "Treemen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 31;
            this.ResearchGrade = 1;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 15;
            this.Armor = 12;
            this.MagicResist = 90;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 17;
            this.MeleeAttackType = (int)AttackTypes.Magical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Giant : GameUnit
    {
        public Giant()
        {
            this.Name = "Giant";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 47;
            this.ResearchGrade = 2;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 10;
            this.Armor = 18;
            this.MagicResist = 90;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 20;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class EarthElemental : GameUnit
    {
        public EarthElemental()
        {
            this.Name = "Earth Elemental";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 65;
            this.ResearchGrade = 3;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 10;
            this.Armor = 22;
            this.MagicResist = 90;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 24;
            this.MeleeAttackType = (int)AttackTypes.Magical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Sandmen : GameUnit
    {
        public Sandmen()
        {
            this.Name = "Sandmen";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 88;
            this.ResearchGrade = 4;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 15;
            this.Armor = 26;
            this.MagicResist = 90;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 27;
            this.MeleeAttackType = (int)AttackTypes.Magical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class MonksofMeo : GameUnit
    {
        public MonksofMeo()
        {
            this.Name = "Monks of Meo";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 105;
            this.ResearchGrade = 5;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 15;
            this.Armor = 30;
            this.MagicResist = 90;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 30;
            this.MeleeAttackType = (int)AttackTypes.Magical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Bronzeman : GameUnit
    {
        public Bronzeman()
        {
            this.Name = "Bronzeman";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 7;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mechanical;
            this.Life = 10;
            this.Armor = 16;
            this.MagicResist = 50;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 10;
            this.MeleeAttackType = (int)AttackTypes.Mechanical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class IronGiant : GameUnit
    {
        public IronGiant()
        {
            this.Name = "Iron Giant";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 46;
            this.ResearchGrade = 3;
            this.Race = (int)UnitRaces.Mechanical;
            this.Life = 10;
            this.Armor = 28;
            this.MagicResist = 50;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 20;
            this.MeleeAttackType = (int)AttackTypes.Mechanical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class WarlordMechanus : GameUnit
    {
        public WarlordMechanus()
        {
            this.Name = "Warlord Mechanus";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 70;
            this.ResearchGrade = 5;
            this.Race = (int)UnitRaces.Mechanical;
            this.Life = 10;
            this.Armor = 35;
            this.MagicResist = 50;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Closed;
            this.SpottingRange = 2;
            this.NumberOfAttacks = 15;
            this.MeleeAttack = 28;
            this.MeleeAttackType = (int)AttackTypes.Mechanical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Corporal : GameUnit
    {
        public Corporal()
        {
            this.Name = "Corporal";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 35;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 15;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 15;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Sergeant : GameUnit
    {
        public Sergeant()
        {
            this.Name = "Sergeant";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 71;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 18;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 18;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Lieutenant : GameUnit
    {
        public Lieutenant()
        {
            this.Name = "Lieutenant";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 107;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 21;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 21;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Captain : GameUnit
    {
        public Captain()
        {
            this.Name = "Captain";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 143;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 24;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 24;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class General : GameUnit
    {
        public General()
        {
            this.Name = "General";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 180;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 28;
            this.MagicResist = 75;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 27;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Any;
        }
    }

    class Borric : GameUnit
    {
        public Borric()
        {
            this.Name = "Borric";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 118;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 22;
            this.MagicResist = 90;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 23;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Loric : GameUnit
    {
        public Loric()
        {
            this.Name = "Loric";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 204;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 20;
            this.MagicResist = 100;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 25;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }

    class Kraekvar : GameUnit
    {
        public Kraekvar()
        {
            this.Name = "Kraekvar";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 118;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Magical;
            this.Life = 10;
            this.Armor = 20;
            this.MagicResist = 90;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 32;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Evil;
        }
    }

    class MorgtheLasher : GameUnit
    {
        public MorgtheLasher()
        {
            this.Name = "Morg the Lasher";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 165;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 30;
            this.MagicResist = 80;
            this.Movement = 4;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 32;
            this.MeleeAttackType = (int)AttackTypes.Physical;
            this.SkirmishAttack = 0;
            this.SkirmishAttackType = (int)AttackTypes.Physical;
            this.RangeAttack = 0;
            this.RangeAttackType = (int)AttackTypes.Physical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Evil;
        }
    }

    class Dreggo : GameUnit
    {
        public Dreggo()
        {
            this.Name = "Dreggo";
            this.UnitType = (int)UnitTypes.HeavyInfantry;
            this.Cost = 205;
            this.ResearchGrade = 0;
            this.Race = (int)UnitRaces.Mortal;
            this.Life = 10;
            this.Armor = 20;
            this.MagicResist = 50;
            this.Movement = 3;
            this.MovementType = (int)MovementTypes.Open;
            this.SpottingRange = 3;
            this.NumberOfAttacks = 10;
            this.MeleeAttack = 20;
            this.MeleeAttackType = (int)AttackTypes.Mechanical;
            this.SkirmishAttack = 12;
            this.SkirmishAttackType = (int)AttackTypes.Mechanical;
            this.RangeAttack = 10;
            this.RangeAttackType = (int)AttackTypes.Mechanical;
            this.SeigeAttack = 0;
            this.SeigeAttackType = (int)AttackTypes.Physical;
            this.OwnerAlignment = (int)UnitAlignments.Good;
        }
    }
}
