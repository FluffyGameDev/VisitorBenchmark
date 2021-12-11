using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VisitorBenchmark.TestCases
{
    public class VirtualCall16Classes
    {
        abstract class Unit
        {
            public abstract int GetUnitDamage();
        }

    #region Unit implementations
        class ArtificerUnit : Unit
        {
            public override int GetUnitDamage() { return GunDamage; }

            public int GunDamage = 1;
        }

        class BarbarianUnit : Unit
        {
            public override int GetUnitDamage() { return SwordDamage; }

            public int SwordDamage = 1;
        }

        class BardUnit : Unit
        {
            public override int GetUnitDamage() { return FluteDamage; }

            public int FluteDamage = 1;
        }

        class BoatUnit : Unit
        {
            public override int GetUnitDamage() { return CargoDamage; }

            public int CargoDamage = 1;
        }

        class ClericUnit : Unit
        {
            public override int GetUnitDamage() { return MaceDamage; }

            public int MaceDamage = 1;
        }

        class DancerUnit : Unit
        {
            public override int GetUnitDamage() { return MojoDamage; }

            public int MojoDamage = 1;
        }

        class DruidUnit : Unit
        {
            public override int GetUnitDamage() { return AnimalFormDamage; }

            public int AnimalFormDamage = 1;
        }

        class FighterUnit : Unit
        {
            public override int GetUnitDamage() { return ShortSwordDamage; }

            public int ShortSwordDamage = 1;
        }

        class MonkUnit : Unit
        {
            public override int GetUnitDamage() { return FistDamage; }

            public int FistDamage = 1;
        }

        class NinjaUnit : Unit
        {
            public override int GetUnitDamage() { return KunaiDamage; }

            public int KunaiDamage = 1;
        }

        class PaladinUnit : Unit
        {
            public override int GetUnitDamage() { return FaithDamage; }

            public int FaithDamage = 1;
        }

        class RangerUnit : Unit
        {
            public override int GetUnitDamage() { return BowDamage; }

            public int BowDamage = 1;
        }

        class RogueUnit : Unit
        {
            public override int GetUnitDamage() { return DaggerDamage; }

            public int DaggerDamage = 1;
        }

        class SorcererUnit : Unit
        {
            public override int GetUnitDamage() { return BookDamage; }

            public int BookDamage = 1;
        }

        class WarlockUnit : Unit
        {
            public override int GetUnitDamage() { return PatronDamage; }

            public int PatronDamage = 1;
        }

        class WizardUnit : Unit
        {
            public override int GetUnitDamage() { return WandDamage; }

            public int WandDamage = 1;
        }
        #endregion




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
                damage += unit.GetUnitDamage();
            }
        }
    }
}
