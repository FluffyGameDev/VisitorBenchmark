using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VisitorBenchmark.TestCases
{
    public class VirtualSwitch16Classes
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
            FighterUnit,
            MonkUnit,
            NinjaUnit,
            PaladinUnit,
            RangerUnit,
            RogueUnit,
            SorcererUnit,
            WarlockUnit,
            WizardUnit
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

        class MonkUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.MonkUnit; }

            public int FistDamage = 1;
        }

        class NinjaUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.NinjaUnit; }

            public int KunaiDamage = 1;
        }

        class PaladinUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.PaladinUnit; }

            public int FaithDamage = 1;
        }

        class RangerUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.RangerUnit; }

            public int BowDamage = 1;
        }

        class RogueUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.RogueUnit; }

            public int DaggerDamage = 1;
        }

        class SorcererUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.SorcererUnit; }

            public int BookDamage = 1;
        }

        class WarlockUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.WarlockUnit; }

            public int PatronDamage = 1;
        }

        class WizardUnit : Unit
        {
            public override UnitType GetUnitType() { return UnitType.WizardUnit; }

            public int WandDamage = 1;
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
                case UnitType.MonkUnit: return Unsafe.As<MonkUnit>(unit).FistDamage;
                case UnitType.NinjaUnit: return Unsafe.As<NinjaUnit>(unit).KunaiDamage;
                case UnitType.PaladinUnit: return Unsafe.As<PaladinUnit>(unit).FaithDamage;
                case UnitType.RangerUnit: return Unsafe.As<RangerUnit>(unit).BowDamage;
                case UnitType.RogueUnit: return Unsafe.As<RogueUnit>(unit).DaggerDamage;
                case UnitType.SorcererUnit: return Unsafe.As<SorcererUnit>(unit).BookDamage;
                case UnitType.WarlockUnit: return Unsafe.As<WarlockUnit>(unit).PatronDamage;
                case UnitType.WizardUnit: return Unsafe.As<WizardUnit>(unit).WandDamage;
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
                    switch (i % 16)
                    {
                        case 0:  { ms_Units.Add(new ArtificerUnit()); break; }
                        case 1:  { ms_Units.Add(new BarbarianUnit()); break; }
                        case 2:  { ms_Units.Add(new BardUnit()); break; }
                        case 3:  { ms_Units.Add(new BoatUnit()); break; }
                        case 4:  { ms_Units.Add(new ClericUnit()); break; }
                        case 5:  { ms_Units.Add(new DancerUnit()); break; }
                        case 6:  { ms_Units.Add(new DruidUnit()); break; }
                        case 7:  { ms_Units.Add(new FighterUnit()); break; }
                        case 8:  { ms_Units.Add(new MonkUnit()); break; }
                        case 9:  { ms_Units.Add(new NinjaUnit()); break; }
                        case 10: { ms_Units.Add(new PaladinUnit()); break; }
                        case 11: { ms_Units.Add(new RangerUnit()); break; }
                        case 12: { ms_Units.Add(new RogueUnit()); break; }
                        case 13: { ms_Units.Add(new SorcererUnit()); break; }
                        case 14: { ms_Units.Add(new WarlockUnit()); break; }
                        case 15: { ms_Units.Add(new WizardUnit()); break; }
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
