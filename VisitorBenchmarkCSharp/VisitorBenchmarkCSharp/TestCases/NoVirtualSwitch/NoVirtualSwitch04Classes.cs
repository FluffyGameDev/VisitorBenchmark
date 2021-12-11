﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VisitorBenchmark.TestCases
{
    public class NoVirtualSwitch04Classes
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
            public Unit(UnitType unitType)
            {
                m_UnitType = unitType;
            }

            public UnitType GetUnitType() { return m_UnitType; }

            private UnitType m_UnitType;
        }

    #region Unit implementations
        class ArtificerUnit : Unit
        {
            public ArtificerUnit()
                : base(UnitType.ArtificerUnit)
            {
            }

            public int GunDamage = 1;
        }

        class BarbarianUnit : Unit
        {
            public BarbarianUnit()
                : base(UnitType.BarbarianUnit)
            {
            }

            public int SwordDamage = 1;
        }

        class BardUnit : Unit
        {
            public BardUnit()
                : base(UnitType.BardUnit)
            {
            }

            public int FluteDamage = 1;
        }

        class BoatUnit : Unit
        {
            public BoatUnit()
                : base(UnitType.BoatUnit)
            {
            }

            public int CargoDamage = 1;
        }
        #endregion

        static int ComputeUnitDamage(Unit unit)
        {
            switch (unit.GetUnitType())
            {
                case UnitType.ArtificerUnit: return Unsafe.As<ArtificerUnit>(unit).GunDamage;
                case UnitType.BarbarianUnit: return Unsafe.As<BarbarianUnit>(unit).SwordDamage;
                case UnitType.BardUnit: return Unsafe.As<BardUnit>(unit).FluteDamage;
                case UnitType.BoatUnit: return Unsafe.As<BoatUnit>(unit).CargoDamage;
            }

            return 0;
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
