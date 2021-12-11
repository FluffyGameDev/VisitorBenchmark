using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VisitorBenchmark.TestCases
{
    public class NoVirtualJumpTable16Classes
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

        class ClericUnit : Unit
        {
            public ClericUnit()
                : base(UnitType.ClericUnit)
            {
            }

            public int MaceDamage = 1;
        }

        class DancerUnit : Unit
        {
            public DancerUnit()
                : base(UnitType.DancerUnit)
            {
            }

            public int MojoDamage = 1;
        }

        class DruidUnit : Unit
        {
            public DruidUnit()
                : base(UnitType.DruidUnit)
            {
            }

            public int AnimalFormDamage = 1;
        }

        class FighterUnit : Unit
        {
            public FighterUnit()
                : base(UnitType.FighterUnit)
            {
            }

            public int ShortSwordDamage = 1;
        }

        class MonkUnit : Unit
        {
            public MonkUnit()
                : base(UnitType.MonkUnit)
            {
            }

            public int FistDamage = 1;
        }

        class NinjaUnit : Unit
        {
            public NinjaUnit()
                : base(UnitType.NinjaUnit)
            {
            }

            public int KunaiDamage = 1;
        }

        class PaladinUnit : Unit
        {
            public PaladinUnit()
                : base(UnitType.PaladinUnit)
            {
            }

            public int FaithDamage = 1;
        }

        class RangerUnit : Unit
        {
            public RangerUnit()
                : base(UnitType.RangerUnit)
            {
            }

            public int BowDamage = 1;
        }

        class RogueUnit : Unit
        {
            public RogueUnit()
                : base(UnitType.RogueUnit)
            {
            }

            public int DaggerDamage = 1;
        }

        class SorcererUnit : Unit
        {
            public SorcererUnit()
                : base(UnitType.SorcererUnit)
            {
            }

            public int BookDamage = 1;
        }

        class WarlockUnit : Unit
        {
            public WarlockUnit()
                : base(UnitType.WarlockUnit)
            {
            }

            public int PatronDamage = 1;
        }

        class WizardUnit : Unit
        {
            public WizardUnit()
                : base(UnitType.WizardUnit)
            {
            }

            public int WandDamage = 1;
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

        static int ComputeClericUnitDamage(Unit unit)
        {
            return Unsafe.As<ClericUnit>(unit).MaceDamage;
        }

        static int ComputeDancerUnitDamage(Unit unit)
        {
            return Unsafe.As<DancerUnit>(unit).MojoDamage;
        }

        static int ComputeDruidUnitDamage(Unit unit)
        {
            return Unsafe.As<DruidUnit>(unit).AnimalFormDamage;
        }

        static int ComputeFighterUnitDamage(Unit unit)
        {
            return Unsafe.As<FighterUnit>(unit).ShortSwordDamage;
        }

        static int ComputeMonkUnitDamage(Unit unit)
        {
            return Unsafe.As<MonkUnit>(unit).FistDamage;
        }

        static int ComputeNinjaUnitDamage(Unit unit)
        {
            return Unsafe.As<NinjaUnit>(unit).KunaiDamage;
        }

        static int ComputePaladinUnitDamage(Unit unit)
        {
            return Unsafe.As<PaladinUnit>(unit).FaithDamage;
        }

        static int ComputeRangerUnitDamage(Unit unit)
        {
            return Unsafe.As<RangerUnit>(unit).BowDamage;
        }

        static int ComputeRogueUnitDamage(Unit unit)
        {
            return Unsafe.As<RogueUnit>(unit).DaggerDamage;
        }

        static int ComputeSorcererUnitDamage(Unit unit)
        {
            return Unsafe.As<SorcererUnit>(unit).BookDamage;
        }

        static int ComputeWarlockUnitDamage(Unit unit)
        {
            return Unsafe.As<WarlockUnit>(unit).PatronDamage;
        }

        static int ComputeWizardUnitDamage(Unit unit)
        {
            return Unsafe.As<WizardUnit>(unit).WandDamage;
        }

        delegate int JumpTableEntry(Unit unit);
        static JumpTableEntry[] ms_JumpTable = new JumpTableEntry[]
            {
                ComputeArtificerUnitDamage,
                ComputeBarbarianUnitDamage,
                ComputeBardUnitDamage,
                ComputeBoatUnitDamage,
                ComputeClericUnitDamage,
                ComputeDancerUnitDamage,
                ComputeDruidUnitDamage,
                ComputeFighterUnitDamage,
                ComputeMonkUnitDamage,
                ComputeNinjaUnitDamage,
                ComputePaladinUnitDamage,
                ComputeRangerUnitDamage,
                ComputeRogueUnitDamage,
                ComputeSorcererUnitDamage,
                ComputeWarlockUnitDamage,
                ComputeWizardUnitDamage,
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
