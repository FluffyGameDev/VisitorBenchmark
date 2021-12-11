using System.Collections.Generic;

namespace VisitorBenchmark.TestCases
{
    public class Visitor16Classes
    {
        interface UnitVisitor
        {
            void VisitArtificerUnit(ArtificerUnit artificer);
            void VisitBarbarianUnit(BarbarianUnit barbarian);
            void VisitBardUnit(BardUnit bard);
            void VisitBoatUnit(BoatUnit boat);
            void VisitClericUnit(ClericUnit cleric);
            void VisitDancerUnit(DancerUnit dancer);
            void VisitDruidUnit(DruidUnit druid);
            void VisitFighterUnit(FighterUnit fighter);
            void VisitMonkUnit(MonkUnit monk);
            void VisitNinjaUnit(NinjaUnit ninja);
            void VisitPaladinUnit(PaladinUnit paladin);
            void VisitRangerUnit(RangerUnit ranger);
            void VisitRogueUnit(RogueUnit rogue);
            void VisitSorcererUnit(SorcererUnit sorcerer);
            void VisitWarlockUnit(WarlockUnit warlock);
            void VisitWizardUnit(WizardUnit wizard);
        }

        abstract class Unit
        {
            public abstract void Accept(UnitVisitor visitor);
        }

    #region Unit implementations
        class ArtificerUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitArtificerUnit(this);
            }

            public int GunDamage = 1;
        }

        class BarbarianUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitBarbarianUnit(this);
            }

            public int SwordDamage = 1;
        }

        class BardUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitBardUnit(this);
            }

            public int FluteDamage = 1;
        }

        class BoatUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitBoatUnit(this);
            }

            public int CargoDamage = 1;
        }

        class ClericUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitClericUnit(this);
            }

            public int MaceDamage = 1;
        }

        class DancerUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitDancerUnit(this);
            }

            public int MojoDamage = 1;
        }

        class DruidUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitDruidUnit(this);
            }

            public int AnimalFormDamage = 1;
        }

        class FighterUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitFighterUnit(this);
            }

            public int ShortSwordDamage = 1;
        }

        class MonkUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitMonkUnit(this);
            }

            public int FistDamage = 1;
        }

        class NinjaUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitNinjaUnit(this);
            }

            public int KunaiDamage = 1;
        }

        class PaladinUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitPaladinUnit(this);
            }

            public int FaithDamage = 1;
        }

        class RangerUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitRangerUnit(this);
            }

            public int BowDamage = 1;
        }

        class RogueUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitRogueUnit(this);
            }

            public int DaggerDamage = 1;
        }

        class SorcererUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitSorcererUnit(this);
            }

            public int BookDamage = 1;
        }

        class WarlockUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitWarlockUnit(this);
            }

            public int PatronDamage = 1;
        }

        class WizardUnit : Unit
        {
            public override void Accept(UnitVisitor visitor)
            {
                visitor.VisitWizardUnit(this);
            }

            public int WandDamage = 1;
        }
        #endregion

        class ComputeDamageUnitVisitor : UnitVisitor
        {
            int m_Damage = 0;

            public void VisitArtificerUnit(ArtificerUnit artificer)
            {
                m_Damage += artificer.GunDamage;
            }

            public void VisitBarbarianUnit(BarbarianUnit barbarian)
            {
                m_Damage += barbarian.SwordDamage;
            }

            public void VisitBardUnit(BardUnit bard)
            {
                m_Damage += bard.FluteDamage;
            }

            public void VisitBoatUnit(BoatUnit boat)
            {
                m_Damage += boat.CargoDamage;
            }

            public void VisitClericUnit(ClericUnit cleric)
            {
                m_Damage += cleric.MaceDamage;
            }

            public void VisitDancerUnit(DancerUnit dancer)
            {
                m_Damage += dancer.MojoDamage;
            }

            public void VisitDruidUnit(DruidUnit druid)
            {
                m_Damage += druid.AnimalFormDamage;
            }

            public void VisitFighterUnit(FighterUnit fighter)
            {
                m_Damage += fighter.ShortSwordDamage;
            }

            public void VisitMonkUnit(MonkUnit monk)
            {
                m_Damage += monk.FistDamage;
            }

            public void VisitNinjaUnit(NinjaUnit ninja)
            {
                m_Damage += ninja.KunaiDamage;
            }

            public void VisitPaladinUnit(PaladinUnit paladin)
            {
                m_Damage += paladin.FaithDamage;
            }

            public void VisitRangerUnit(RangerUnit ranger)
            {
                m_Damage += ranger.BowDamage;
            }

            public void VisitRogueUnit(RogueUnit rogue)
            {
                m_Damage += rogue.DaggerDamage;
            }

            public void VisitSorcererUnit(SorcererUnit sorcerer)
            {
                m_Damage += sorcerer.BookDamage;
            }

            public void VisitWarlockUnit(WarlockUnit warlock)
            {
                m_Damage += warlock.PatronDamage;
            }

            public void VisitWizardUnit(WizardUnit wizard)
            {
                m_Damage += wizard.WandDamage;
            }
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
            ComputeDamageUnitVisitor damageVisitor = new ComputeDamageUnitVisitor();
            foreach (Unit unit in ms_Units)
            {
                unit.Accept(damageVisitor);
            }
        }
    }
}