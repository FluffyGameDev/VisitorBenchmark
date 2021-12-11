using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VisitorBenchmark.TestCases
{
    public class VirtualJumpTable04Classes
    {
        enum UnitType
        {
            ArtificerUnit,
            BarbarianUnit,
            BardUnit,
            BoatUnit
        }

        abstract class Unit
        {
            public abstract UnitType GetUnitType();
        }

    #region Unit implementations
        class ArtificerUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.ArtificerUnit; }

            public int GunDamage = 1;
        }

        class BarbarianUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.BarbarianUnit; }

            public int SwordDamage = 1;
        }

        class BardUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.BardUnit; }

            public int FluteDamage = 1;
        }

        class BoatUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.BoatUnit; }

            public int CargoDamage = 1;
        }
        #endregion

        static int ComputeArtificerUnitDamage(Unit unit)
        {
            return Unsafe.As<ArtificerUnit>(unit).GunDamage;
        }

        static int ComputeBarbarianUnitDamage(Unit unit)
        {
            return Unsafe.As<BarbarianUnit>(unit).SwordDamage;
        }

        static int ComputeBardUnitDamage(Unit unit)
        {
            return Unsafe.As<BardUnit>(unit).FluteDamage;
        }

        static int ComputeBoatUnitDamage(Unit unit)
        {
            return Unsafe.As<BoatUnit>(unit).CargoDamage;
        }

        delegate int JumpTableEntry(Unit unit);
        static JumpTableEntry[] ms_JumpTable = new JumpTableEntry[]
            {
                ComputeArtificerUnitDamage,
                ComputeBarbarianUnitDamage,
                ComputeBardUnitDamage,
                ComputeBoatUnitDamage
            };

        static int ComputeUnitDamage(Unit unit)
        {
            return ms_JumpTable[(uint)unit.GetUnitType()](unit);
        }




        static List<Unit> ms_Units = null;

        public static void Init()
        {
            if (ms_Units == null)
            {
                ms_Units = new List<Unit>();
                for (uint i = 0; i < 1024; ++i)
                {
                    switch (i % 4)
                    {
                        case 0:  { ms_Units.Add(new ArtificerUnit()); break; }
                        case 1:  { ms_Units.Add(new BarbarianUnit()); break; }
                        case 2:  { ms_Units.Add(new BardUnit()); break; }
                        case 3:  { ms_Units.Add(new BoatUnit()); break; }
                    }
                }
            }
        }

        public static void Test()
        {
            int damage = 0;
            foreach (Unit unit in ms_Units)
            {
                damage += ComputeUnitDamage(unit);
            }
        }
    }
}
