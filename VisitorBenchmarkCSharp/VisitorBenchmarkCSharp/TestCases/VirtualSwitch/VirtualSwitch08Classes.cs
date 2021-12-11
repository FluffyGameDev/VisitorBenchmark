using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VisitorBenchmark.TestCases
{
    public class VirtualSwitch08Classes
    {
        enum UnitType
        {
            ArtificerUnit,
            BarbarianUnit,
            BardUnit,
            BoatUnit,
            ClericUnit,
            DancerUnit,
            DruidUnit,
            FighterUnit
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

        class ClericUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.ClericUnit; }

            public int MaceDamage = 1;
        }

        class DancerUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.DancerUnit; }

            public int MojoDamage = 1;
        }

        class DruidUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.DruidUnit; }

            public int AnimalFormDamage = 1;
        }

        class FighterUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.FighterUnit; }

            public int ShortSwordDamage = 1;
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
                case UnitType.ClericUnit: return Unsafe.As<ClericUnit>(unit).MaceDamage;
                case UnitType.DancerUnit: return Unsafe.As<DancerUnit>(unit).MojoDamage;
                case UnitType.DruidUnit: return Unsafe.As<DruidUnit>(unit).AnimalFormDamage;
                case UnitType.FighterUnit: return Unsafe.As<FighterUnit>(unit).ShortSwordDamage;
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
