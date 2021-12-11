﻿using System.Collections.Generic;

namespace VisitorBenchmark.TestCases
{
    public class DynamicCast04Classes
    {
        abstract class Unit
        {
        }

        #region Unit implementations
        class ArtificerUnit : Unit
        {
            public int GunDamage = 1;
        }

        class BarbarianUnit : Unit
        {
            public int SwordDamage = 1;
        }

        class BardUnit : Unit
        {
            public int FluteDamage = 1;
        }

        class BoatUnit : Unit
        {
            public int CargoDamage = 1;
        }
        #endregion

        static int ComputeUnitDamage(ArtificerUnit artificer) { return artificer.GunDamage; }
        static int ComputeUnitDamage(BarbarianUnit barbarian) { return barbarian.SwordDamage; }
        static int ComputeUnitDamage(BardUnit bard) { return bard.FluteDamage; }
        static int ComputeUnitDamage(BoatUnit boat) { return boat.CargoDamage; }




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
                damage += ComputeUnitDamage((dynamic)unit);
            }
        }
    }
}
