using System.Collections.Generic;

namespace VisitorBenchmark.TestCases
{
    public class DynamicCast16Classes
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

        class MonkUnit : Unit
        {
            public int FistDamage = 1;
        }

        class NinjaUnit : Unit
        {
            public int KunaiDamage = 1;
        }

        class PaladinUnit : Unit
        {
            public int FaithDamage = 1;
        }

        class RangerUnit : Unit
        {
            public int BowDamage = 1;
        }

        class RogueUnit : Unit
        {
            public int DaggerDamage = 1;
        }

        class SorcererUnit : Unit
        {
            public int BookDamage = 1;
        }

        class WarlockUnit : Unit
        {
            public int PatronDamage = 1;
        }

        class WizardUnit : Unit
        {
            public int WandDamage = 1;
        }
        #endregion

        static int ComputeUnitDamage(ArtificerUnit artificer) { return artificer.GunDamage; }
        static int ComputeUnitDamage(BarbarianUnit barbarian) { return barbarian.SwordDamage; }
        static int ComputeUnitDamage(BardUnit bard) { return bard.FluteDamage; }
        static int ComputeUnitDamage(BoatUnit boat) { return boat.CargoDamage; }
        static int ComputeUnitDamage(ClericUnit cleric) { return cleric.MaceDamage; }
        static int ComputeUnitDamage(DancerUnit dancer) { return dancer.MojoDamage; }
        static int ComputeUnitDamage(DruidUnit druid) { return druid.AnimalFormDamage; }
        static int ComputeUnitDamage(FighterUnit fighter) { return fighter.ShortSwordDamage; }
        static int ComputeUnitDamage(MonkUnit monk) { return monk.FistDamage; }
        static int ComputeUnitDamage(NinjaUnit ninja) { return ninja.KunaiDamage; }
        static int ComputeUnitDamage(PaladinUnit paladin) { return paladin.FaithDamage; }
        static int ComputeUnitDamage(RangerUnit ranger) { return ranger.BowDamage; }
        static int ComputeUnitDamage(RogueUnit rogue) { return rogue.DaggerDamage; }
        static int ComputeUnitDamage(SorcererUnit sorcerer) { return sorcerer.BookDamage; }
        static int ComputeUnitDamage(WarlockUnit warlock) { return warlock.PatronDamage; }
        static int ComputeUnitDamage(WizardUnit wizard) { return wizard.WandDamage; }




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
                damage += ComputeUnitDamage((dynamic)unit);
            }
        }
    }
}
