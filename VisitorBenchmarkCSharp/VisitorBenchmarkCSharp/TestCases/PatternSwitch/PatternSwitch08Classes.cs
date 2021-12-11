using System.Collections.Generic;

namespace VisitorBenchmark.TestCases
{
    public class PatternSwitch08Classes
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

        class ClericUnit : Unit
        {
            public int MaceDamage = 1;
        }

        class DancerUnit : Unit
        {
            public int MojoDamage = 1;
        }

        class DruidUnit : Unit
        {
            public int AnimalFormDamage = 1;
        }

        class FighterUnit : Unit
        {
            public int ShortSwordDamage = 1;
        }
        #endregion

        static int ComputeUnitDamage(Unit unit)
        {
            return unit switch
            {
                ArtificerUnit artificer => artificer.GunDamage,
                BarbarianUnit barbarian => barbarian.SwordDamage,
                BardUnit bard => bard.FluteDamage,
                BoatUnit boat => boat.CargoDamage,
                ClericUnit cleric => cleric.MaceDamage,
                DancerUnit dancer => dancer.MojoDamage,
                DruidUnit druid => druid.AnimalFormDamage,
                FighterUnit fighter => fighter.ShortSwordDamage,
                _ => throw new System.NotImplementedException()
            };
        }




        static List<Unit> ms_Units = null;

        public static void Init()
        {
            if (ms_Units == null)
            {
                ms_Units = new List<Unit>();
                for (uint i = 0; i < 1024; ++i)
                {
                    switch (i % 8)
                    {
                        case 0:  { ms_Units.Add(new ArtificerUnit()); break; }
                        case 1:  { ms_Units.Add(new BarbarianUnit()); break; }
                        case 2:  { ms_Units.Add(new BardUnit()); break; }
                        case 3:  { ms_Units.Add(new BoatUnit()); break; }
                        case 4:  { ms_Units.Add(new ClericUnit()); break; }
                        case 5:  { ms_Units.Add(new DancerUnit()); break; }
                        case 6:  { ms_Units.Add(new DruidUnit()); break; }
                        case 7:  { ms_Units.Add(new FighterUnit()); break; }
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
