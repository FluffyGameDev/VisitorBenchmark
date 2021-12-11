using System.Collections.Generic;

namespace VisitorBenchmark.TestCases
{
    public class Visitor08Classes
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
            ComputeDamageUnitVisitor damageVisitor = new ComputeDamageUnitVisitor();
            foreach (Unit unit in ms_Units)
            {
                unit.Accept(damageVisitor);
            }
        }
    }
}